using System;
namespace AdditionOfFloatNumbers
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string input1 = Console.ReadLine();
            string input2 = Console.ReadLine();

            FloatAddition obj = new FloatAddition();
            Console.WriteLine(Math.Round(obj.Addition(input1,input2,out int round),round+1));
        }
    }
}
