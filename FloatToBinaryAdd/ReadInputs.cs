using System;
using System.Xml.Schema;

namespace FloatToBinaryAdd
{
    public class ReadInputs
    {
        public string Read()
        {
            while (true)
            {
                
                string input = Console.ReadLine();
                Validation obj = new Validation();
                if (obj.Is_ValidateForNull(input))
                {
                    Console.WriteLine("Do Enter null Values");
                    continue;
                }
                if(obj.Is_ValidateForNegative(input))
                {
                    Console.WriteLine("Do Not Enter The Negative Values");
                    continue;
                }
                if (obj.Is_ValidateForNonNumeric(input))
                {
                    Console.WriteLine("Enter Only FLoat values (Example: 24.578)");
                    continue;
                }
                return input;
            }
            //return input;

        }
    }
}
