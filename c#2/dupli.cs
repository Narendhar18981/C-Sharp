using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using S1;
namespace S2
{
    public static class Abc
    {
        public static string name = "kdj";
        public static int age = 10;
        public static int ab = 20;

        public static void Print()
        {
            Console.WriteLine("hii");
        }
        public static string work()
        {
            return "Programming";
        }
        static Abc()
        {

        }
    }
    class MainClass
    {
        public static void Main(string[] args)
        {
            S2.Abc.work();
            S2.Abc.age = 21;
            S2.Abc.name = "SOMEONE NAME";
            Console.WriteLine(S2.Abc.name + " " + S2.Abc.age + " " + S2.Abc.work());
            Console.WriteLine(S2.Abc.work());
            S1.Program.Abc o = new S1.Program.Abc();
            o.Print();
            o.Prints();
        }
    }
}

