using System;
using System.Collections.Generic;


namespace Pirate_Sim
{
    public class Port
    {
        public string name;

        static List<string> possibleNames = new List<string>()
        {"Grand Island Port", "Stormfury Landing", "Saltlake Harbor", "Newhaven Harbor", "Silver Bluff Wharf",
        "Hamfolk Landing", "The Landing of Graventham", "Bracestead Piers", "Turtle Bay", "Ringmeuse Port",
        "Repenville Port", "Avalon Landing", "Iturich Harbor", "Greymouth Wharf", "New Moon Landing", "Dartfolk Wharf",
        "Oceanfall Landing", "Wapester Harbor", "Water Whale Pier", "The Port of Buchline", "Picsea Wharf",
        "Albatross Point Harbor", "False River Port", };

        public int cargoValue;

        public bool mapSold;

        Random generator = new Random();

         public void Spawn()
        {
            int n = generator.Next(possibleNames.Count);
            name = possibleNames[n];

            cargoValue = generator.Next(5, 25);

            possibleNames.RemoveAt(n);

            int m = generator.Next(1, 100);

            if (m <= 25)
            {
                mapSold = true;
            }

            else
            {
                mapSold = false;
            }
        }

        
    }
}
