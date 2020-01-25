using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using AzureMultiTranslator.Contracts;
using Newtonsoft.Json;

namespace AzureMultiTranslator
{
    public class Translator : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private string _subscriptionKey;
        public string SubscriptionKey
        {
            get => _subscriptionKey;
            set => SetField(ref _subscriptionKey, value);
        }

        private string _endpoint;

        public string Endpoint
        {
            get => _endpoint;
            set => SetField(ref _endpoint, value);
        }

        public Translator()
        {
            Endpoint = "https://api.cognitive.microsofttranslator.com";
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
                request.RequestUri = new Uri(Endpoint + route);
                request.Content = new StringContent(requestBody, Encoding.UTF8, "application/json");
                request.Headers.Add("Ocp-Apim-Subscription-Key", SubscriptionKey);

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

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value)) return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }

    }
}
