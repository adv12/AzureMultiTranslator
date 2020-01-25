namespace AzureMultiTranslator
{
   public class TranslatedTextRow
   {
      public string Language { get; set; } = "";

      public string TranslatedText { get; set; } = "";

      public string BackTranslatedText { get; set; } = "";

      public string Copy => "Copy";

      public string Remove => "Remove";

      public TranslatedTextRow(string language)
      {
         Language = language;
      }
   }
}
