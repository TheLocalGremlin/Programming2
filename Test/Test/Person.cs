using System;

namespace Test
{
    public class Person: People
    {
        public int age;

        public void Spawn()
        {
            age = 15;
            System.Console.WriteLine(age);
        }
    }
}
