using System;
using System.Security.Cryptography.X509Certificates;

namespace FourDigitsGreatestProduct
{
    public class MainClass
    {
        public static void Main()
        {
            Console.Write("Enter Only Digits As input : ");
            string input = Console.ReadLine();

            Validation valid = new Validation();
            valid.Is_CheckForCharAndLength(input);

            FourGreatestProduct Obj = new FourGreatestProduct();

            Console.WriteLine(Obj.GetFourGreatestSolution(input));
        }
    }
}
