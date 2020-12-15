using System;
using System.Collections.Generic;

namespace Test
{
    public class People
    {
        List<string> names = new List<string>{
            "Irene", "Seulgi", "Wendy", "Joy", "Yeri"
        };

        Random generator = new Random();

        string name;

        public voiid Spawn()
        {
            int n = generator.Next(names.Count);

            if (n < 0)
            {
                name = "RV";
            }

            else
            {
            name = names[n];

            names.RemoveAt(n);
            }

        }
    }
}
