using System.Text.Json.Serialization;

namespace AnimalCrossingApp
{
    public class Villager
    {

        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("file-name")]
        public string FileName { get; set; }

        [JsonPropertyName("name")]
        public Name Name { get; set; }

        [JsonPropertyName("personality")]
        public string Personality { get; set; }

        [JsonPropertyName("birthday-string")]
        public string BirthdayString { get; set; }

        [JsonPropertyName("birthday")]
        public string Birthday { get; set; }

        [JsonPropertyName("species")]
        public string Species { get; set; }

        [JsonPropertyName("gender")]
        public string Gender { get; set; }

        [JsonPropertyName("catch-phrase")]
        public string CatchPhrase { get; set; }

        [JsonPropertyName("icon_uri")]
        public string IconUri { get; set; }

        [JsonPropertyName("image_uri")]
        public string ImageUri { get; set; }

        [JsonPropertyName("catch-translations")]
        public CatchTranslations CatchTranslations { get; set; }

    }
}