using FloatToBinaryAdd;
using System;
namespace AdditionOfFloatNumbers
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ReadInputs scan=new ReadInputs();
            Console.WriteLine("Enter a first float value:");
            string input1 = scan.Read();
            Console.WriteLine("Enter a second float value:");
            string input2 = scan.Read();

            FloatAddition obj = new FloatAddition();
            Console.WriteLine(Math.Round(obj.Addition(input1,input2,out int round),round+1));
        }
    }
}
