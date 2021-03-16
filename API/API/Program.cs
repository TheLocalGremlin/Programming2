using System;
using RestSharp;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace API
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<string> classes = new List<string>
            {
                "barbarian", "bard", "cleric", "druid", "fighter", "monk", "paladin", "rogue", "sorce"
            };

            RestClient client = new RestClient("https://www.dnd5eapi.co/api/");

            System.Console.WriteLine("1: Barbarian");
            System.Console.WriteLine();

            RestRequest request = new RestRequest("classes/bard/");

            IRestResponse response = client.Get(request);

            //System.Console.WriteLine(response.Content);

            Class newClass = JsonConvert.DeserializeObject<Class>(response.Content);
            System.Console.WriteLine(newClass.name);
            System.Console.WriteLine(newClass.hit_die);

            Console.ReadLine();
        }
    }
}
