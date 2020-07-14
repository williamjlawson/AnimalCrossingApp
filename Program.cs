using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;

namespace AnimalCrossingApp 
{
    class Program
    {
        static async Task Main(string[] args)
        {
            //http://acnhapi.com/v1a/villagers/{villagerID}
            Console.WriteLine("Hello World!");
            var httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Add("User-Agent", "Bananas");
            var stream = httpClient.GetStreamAsync("http://acnhapi.com/v1a/villagers/");
            var villagers = await JsonSerializer.DeserializeAsync<List<Villager>>(await stream);
            System.Console.WriteLine(villagers[1].Birthday);
        }


    }

    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
    public class Name    {

        [JsonPropertyName("name-USen")]
        public string NameUSen { get; set; }  
    }

    public class CatchTranslations    {

        [JsonPropertyName("catch-USen")]
        public string CatchUSen { get; set; } 
    }

}
