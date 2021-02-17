using System;
using RestSharp;
using Newtonsoft.Json;

namespace API
{
    class Program
    {
        static void Main(string[] args)
        {
            RestClient client = new RestClient("https://www.dnd5eapi.co/api/");

            RestRequest request = new RestRequest("classes/bard/");

            IRestResponse response = client.Get(request);

            //System.Console.WriteLine(response.Content);

            Class bard = JsonConvert.DeserializeObject<Class>(response.Content);
            System.Console.WriteLine(bard.name);
            System.Console.WriteLine(bard.hit_die);

            Console.ReadLine();
        }
    }
}
