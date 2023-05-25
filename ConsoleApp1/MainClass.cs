using System;
using System.Collections.Generic;

namespace SubStringCountAndIndex
{
    public class MainClass
    {
        public static void Main()
        {
            string firstString = Console.ReadLine();
            string secondString = Console.ReadLine();

            //Validating inputs
            Validation validate = new Validation();
            if (validate.CheckInputs(firstString, secondString))
                return;

            StringSearch Obj = new StringSearch();

            //invoking the method and storing the result in list
            List<int> indexPositions = Obj.ListOfSubstringIndexes(firstString, secondString);
            
            Console.WriteLine("No.of times occurred = "+indexPositions.Count);
            Console.Write("Index positions = ");
            foreach (int position in indexPositions)
                Console.Write(position + " ");
            Console.WriteLine();
        }
    }
}
