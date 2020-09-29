using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace xmlUppgift
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlSerializer doggoSerializer = new XmlSerializer(typeof(doggo));

            doggo myDoggo = new doggo();

            using (FileStream file = File.Open(@"doggo.xml", FileMode.OpenOrCreate))
            {
                doggoSerializer.Serialize(file, myDoggo);
            }

            using (FileStream file = File.Open(@"doggo.xml", FileMode.OpenOrCreate))
            {
                myDoggo = (doggo) doggoSerializer.Deserialize(file);
            }
            
        }
    }
}
