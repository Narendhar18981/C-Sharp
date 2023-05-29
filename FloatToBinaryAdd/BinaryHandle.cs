using System;
using System.Collections.Generic;


namespace AdditionOfFloatNumbers
{
    /// <summary>
    /// performs Actions On binary
    /// </summary>
    public class BinaryHandle
    {
        /// <summary>
        /// convert integer to binary
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public string IntToBinary(int input)
        {
            string binary = "";
            while (input != 0)
            {
                binary = input % 2 + binary;
                input /= 2;
            }
            return binary;
        }

        /// <summary>
        /// Converts float part to binary
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public string DeciamlPartToBinary(float input)
        {

            string tempnum = Convert.ToString(input);
            string binary = "";

            HashSet<string> hashSet= new HashSet<string>();
            hashSet.Add(tempnum.Substring(tempnum.IndexOf('.')));
            int w = 1;
            string i;
            while (w != 0)
            {
                float f = float.Parse(tempnum);
                tempnum = Convert.ToString(f * 2);

                //Console.WriteLine(tempnum);
                i = tempnum.Substring(tempnum.IndexOf('.') + 1);
                if (hashSet.Contains(i) == true)
                {
                    break;
                }

                hashSet.Add(i);
                if (tempnum[0] == '1')
                {
                    tempnum = tempnum.Substring(1);
                    tempnum = '0' + tempnum;
                    binary += '1';
                }
                else
                {
                    binary +='0';

                }

            }

            return binary;
        }

        /// <summary>
        /// Performs Addition on Binary  Of fractional part returns resultant as string
        /// </summary>
        /// <param name="fractional1"></param>
        /// <param name="fractional2"></param>
        /// <param name="carry"></param>
        /// <returns></returns>
        public string AddingDecimal(string fractional1, string fractional2, out int carry)
        {
            carry = 0;
            string binarySum = "";
            int i = 0;
            for (i = fractional1.Length - 1; i >= 0; i--)
            {
                if (carry == 0 && (fractional1[i] == '0' && fractional2[i] == '0'))
                {
                    binarySum = "0" + binarySum;
                }
                else if (carry == 1 && (fractional1[i] == '0' && fractional2[i] == '0'))
                {
                    binarySum = "1" + binarySum;
                    carry = 0;
                }
                else if (carry == 1 && ((fractional1[i] == '1' && fractional2[i] == '0') || (fractional1[i] == '0' &&   fractional2[i] == '1')))
                {
                    binarySum = "0" + binarySum;
                    carry = 1;

                }
                else if (carry == 0 && ((fractional1[i] == '1' && fractional2[i] == '0') || (fractional1[i] == '0' && fractional2[i] == '1')))
                {
                    binarySum = "1" + binarySum;
                    carry = 0;
                }

                else if (carry == 0 && ((fractional1[i] == '1' && fractional2[i] == '1')))
                {
                    binarySum = "0" + binarySum;
                    carry = 1;
                }
                else if (carry == 1 && ((fractional1[i] == '1' && fractional2[i] == '1')))
                {
                    binarySum = "1" + binarySum;
                    carry = 1;
                }

            }
            return binarySum;
        }

        /// <summary>
        /// Performs Addition on Binary  Of Integer part returns resultant as string
        /// </summary>
        /// <param name="integer1"></param>
        /// <param name="integer2"></param>
        /// <param name="carry"></param>
        /// <returns></returns>
        public string AddingIntegers(string integer1, string integer2, int carry)
        {
            string binarySumOfInteger = "";
            int length = integer1.Length;
            for (int index = length - 1; index >= 0; index--)
            {
                if (carry == 0 && (integer1[index] == '0' && integer2[index] == '0'))
                {
                    binarySumOfInteger = "0" + binarySumOfInteger;
                }
                else if (carry == 1 && (integer1[index] == '0' && integer2[index] == '0'))
                {
                    binarySumOfInteger = "1" + binarySumOfInteger;
                    carry = 0;
                }
                else if (carry == 1 && ((integer1[index] == '1' && integer2[index] == '0') || (integer1[index] == '0' && integer2[index] == '1')))
                {
                    binarySumOfInteger = "0" + binarySumOfInteger;
                    carry = 1;
                }
                else if (carry == 0 && ((integer1[index] == '1' && integer2[index] == '0') || (integer1[index] == '0' && integer2[index] == '1')))
                {
                    binarySumOfInteger = "1" + binarySumOfInteger;
                    carry = 0;
                }

                else if (carry == 0 && ((integer1[index] == '1' && integer2[index] == '1')))
                {
                    binarySumOfInteger = "0" + binarySumOfInteger;
                    carry = 1;
                }
                else if (carry == 1 && ((integer1[index] == '1' && integer2[index] == '1')))
                {
                    binarySumOfInteger = "1" + binarySumOfInteger;
                    carry = 1;
                }

            }
            return binarySumOfInteger;

        }

    }
}