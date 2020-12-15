using System;
using System.Collections.Generic;


namespace Pirate_Sim
{
    public class Port
    {
        public string name;

        List<string> possibleNames = new List<string>()
        {"Grand Island Port", "Stormfury Landing", "Saltlake Harbor"};

        int cargoValue;

        bool finished = false;

        Random generator = new Random();

         public void Spawn()
        {
            int n = generator.Next(possibleNames.Count);
            name = possibleNames[n];

            cargoValue = generator.Next(5, 25);

            possibleNames.RemoveAt(n);
        }

        public void Store()
        {
            while (finished == false)
            {
                
            }
        }
    }
}
