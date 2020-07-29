using System.Text.Json.Serialization;

namespace AnimalCrossingApp
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
    public class VillagerName
    {

        [JsonPropertyName("name-USen")]
        public string NameUSen { get; set; }
    }

}
