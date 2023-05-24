using System;
using ClassLibrary1;
class Program
{
    class Def
    {
        public void Prints()
        {
            Console.WriteLine("in Def class");
        }
    }
    class Abc : Def
    {
        public void Print()
        {
            Console.Out.WriteLine("in Abc class");
        }
    }
    public static void Main(String[] args)
    {
        //Abc o = new Abc();
        Class1 ob = new Class1();
        ob.xy();
        //o.Print();
        //o.Prints();
    }
}
