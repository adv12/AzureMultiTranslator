// Copyright © 2020 Andrew Vardeman.  Published under the MIT license.
// See license.txt in the AzureMultiTranslator distribution or repository for the
// full text of the license.

using AzureMultiTranslator.Contracts;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace AzureMultiTranslator
{
    public class Translator
    {

        private Settings _settings;

        public Translator(Settings settings)
        {
            _settings = settings;
        }

        public async Task<List<string>> Translate(string from, string[] to, string inputText, bool html)
        {
            object[] body = new object[] { new { Text = inputText } };
            var requestBody = JsonConvert.SerializeObject(body);

            string textType = html ? "html" : "plain";
            string route = $"/translate?api-version=3.0&from={from}&to={string.Join("&to=", to)}&textType={textType}";

            using (var client = new HttpClient())
            using (var request = new HttpRequestMessage())
            {
                request.Method = HttpMethod.Post;
                request.RequestUri = new Uri(_settings.Endpoint + route);
                request.Content = new StringContent(requestBody, Encoding.UTF8, "application/json");
                request.Headers.Add("Ocp-Apim-Subscription-Key", _settings.SubscriptionKey);

                HttpResponseMessage response = await client.SendAsync(request).ConfigureAwait(false);

                string result = await response.Content.ReadAsStringAsync();
                List<string> translations = new List<string>();
                try
                {
                    TranslationResult[] deserializedOutput = JsonConvert.DeserializeObject<TranslationResult[]>(result);
                    foreach (TranslationResult o in deserializedOutput)
                    {
                        foreach (Translation t in o.Translations)
                        {
                            translations.Add(t.Text);
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw;
                }

                return translations;
            }
        }

    }
}
