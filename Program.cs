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

            // strings need to be declared before they can be use; strings need to take a value, pass an empty string 
            string userBirthDay = "";
            string userBirthMonth = "";
            string birthDate = "";

            // a while loop provides the bulk of the code in the program, running the code that prompts the user for the day they were born on and the month they were born on 
            // to lower changes into lowercase any capital letters typed that would otherwise prevent the code from working
            // trim takes out unnecessary spaces
            // the break stops the loop from running if the user types "quit"
            while (userBirthDay.ToLower().Trim() != "quit")
            {
                //the user types the date of the day they were born on (without the -st, -nd, -rd attached to the number) 
                // the console reads the inputed number*****
                System.Console.WriteLine("What is the number of the day you were born on? Type quit to exit program");
                userBirthDay = System.Console.ReadLine();

                
                // the break stops the loop from running if the user types "quit"
                // to lower changes into lowercase any capital letters typed that would otherwise prevent the code from working
                // trim takes out unnecessary spaces
                if (userBirthDay.ToLower().Trim() == "quit")
                {
                    break;
                }

                //the user types the date of the month they were born on (without the -st, -nd, -rd attached to the number) 
                System.Console.WriteLine("What is the number of the month you were born on? Type quit to exit program");
                userBirthMonth = System.Console.ReadLine();

                // the break stops the loop from running if the user types "quit"
                if (userBirthMonth.ToLower().Trim() == "quit")
                {
                    break;
                }

                // the two string containing the data collected from the user are concatenated into a single string
                // the single string is needed since the API call has the day and the month in a single string, which is stored in a Villager class 
                birthDate = userBirthDay + "/" + userBirthMonth;

                // the foreach loop cycles through the villagers 
                foreach (Villager currentVillager in villagers)
                {   //if the current villagers birthday is equal to the combined string that contains the number corresponding to the day and the month that the user entered,
                    
                    if (currentVillager.Birthday == birthDate)
                    {   // then the program will write that villager's name to the console 
                        Console.WriteLine(currentVillager.Name.NameUSen + " the " + currentVillager.Species + " shares your birthday");
                    }
                }
            }
        }
    }
}
