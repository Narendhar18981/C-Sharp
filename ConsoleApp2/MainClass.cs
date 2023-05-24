using System;

namespace ConsoleApp2
{   
    public class MainClass
    {
        public static void Main()
        {
            Console.Write("Enter Only Digits As input : ");
            string input = Console.ReadLine();
            Validate valid = new Validate(); 
            valid.Is_CheckForCharAndLength(input);
            FourGreatestProduct Obj=new FourGreatestProduct();
            Console.WriteLine(Obj.Solution(input));
        }
    }
}
