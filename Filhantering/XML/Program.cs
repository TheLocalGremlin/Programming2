using System;
using System.IO;
using System.Xml.Serialization;

namespace XML
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlSerializer serializer = new XmlSerializer (typeof(PowerUp);
            FileStream myFile = File.Open("PowerUp.xml", FileMode.OpenOrCreate);

            PowerUp p = (PowerUp) serializer.Deserialize(myFile);
        }
    }
}
