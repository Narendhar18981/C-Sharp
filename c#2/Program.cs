using System;
namespace S1
{
    public class Program
    {
        public class Def
        {
            public void Prints()
            {
                Console.WriteLine("in Def class");
            }
        }
        public class Abc : Def
        {
            public void Print()
            {
                Console.Out.WriteLine("in Abc class");
            }
        }
    }
}
