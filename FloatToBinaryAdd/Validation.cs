using System;
using System.Runtime.Remoting.Messaging;

namespace FloatToBinaryAdd
{
    public  class Validation
    {
        public bool Is_ValidateForNull(string input)
        {
            if(input==string.Empty)
                return true;
            return false;
        }
        public bool Is_ValidateForNegative(string input)
        {
            if (input[0]== '-') 
                return true;
            return false;
        }
        public bool Is_ValidateForNonNumeric(string input)
        {
            int index = 0;
            int count = 0;
            while (index < input.Length)
            {
                if ((input[index++] == '.')) count++;
                if (count > 1) return true;
            }
            index = 0;
            while(index< input.Length)
            {
                if (!((input[index] >= '0' && input[index] <= '9') || input[index] == '.'))
                    return true;
                index++;
                    
            }
            return false;
        }
    }
}
