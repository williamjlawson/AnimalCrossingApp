using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;

namespace AnimalCrossingApp
{
    class Program
    {
        static async Task Main(string[] args)
        {
            //http://acnhapi.com/v1a/villagers/{villagerID}
            HttpClient httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Add("User-Agent", "Bananas");
            Task<System.IO.Stream> stream = httpClient.GetStreamAsync("http://acnhapi.com/v1a/villagers/");
            List<Villager> villagers = await JsonSerializer.DeserializeAsync<List<Villager>>(await stream);

            string userBirthDay = "";
            string userBirthMonth = "";
            string birthDate = "";

            while (userBirthDay.ToLower().Trim() != "quit")
            {
                System.Console.WriteLine("What is the number of the day you were born on? Type quit to exit program");
                userBirthDay = System.Console.ReadLine();

                if (userBirthDay.ToLower().Trim() == "quit")
                {
                    break;
                }

                System.Console.WriteLine("What is the number of the month you were born on? Type quit to exit program");
                userBirthMonth = System.Console.ReadLine();

                if (userBirthMonth.ToLower().Trim() == "quit")
                {
                    break;
                }

                birthDate = userBirthDay + "/" + userBirthMonth;

                foreach (Villager currentVillager in villagers)
                {
                    if (currentVillager.Birthday == birthDate)
                    {
                        Console.WriteLine(currentVillager.Name.NameUSen + " the " + currentVillager.Species + " shares your birthday");
                    }
                }
            }
        }
    }
}
