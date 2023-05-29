using System;

namespace AdditionOfFloatNumbers
{
    /// <summary>
    /// performs actions on float inputs
    /// </summary>
    public class FloatAddition
    {
        /// <summary>
        /// perfroms addition on given float values
        /// </summary>
        /// <param name="input1"></param>
        /// <param name="input2"></param>
        /// <returns></returns>
        public double Addition(string input1, string input2)
        {
            string[] input1Array = input1.Split('.');
            string[] input2Array = input2.Split('.');

            int input1Integer = Convert.ToInt32(input1Array[0]);
            int input2Integer = Convert.ToInt32(input2Array[0]);
            
            float input1Fractional = float.Parse("0." + input1Array[1]);
            float input2Fractional = float.Parse("0." + input2Array[1]);

            BinaryHandle binary = new BinaryHandle();
            string input1IntegerBinary =binary.IntToBinary(input1Integer);
            string input2IntegerBinary = binary.IntToBinary(input2Integer);
            string input1FractionalBinary = binary.DeciamlPartToBinary(input1Fractional);
            string input2FractionalBinary = binary.DeciamlPartToBinary(input2Fractional);


            int input1IntBinaryLength = input1IntegerBinary.Length;
            int input2IntBinaryLength = input2IntegerBinary.Length;
            int input1FractionalBinaryLength = input1FractionalBinary.Length;
            int input2FractionalBinaryLength = input2FractionalBinary.Length;

            //To make both with equal length On integerBinaryString
            if (input1IntBinaryLength >= input2IntBinaryLength)
            {
                int differnceOfLength = input1IntBinaryLength - input2IntBinaryLength;
                while (differnceOfLength != 0)
                {
                    input2IntegerBinary = 0 + input2IntegerBinary;
                    differnceOfLength--;
                }
                input1IntegerBinary = 0 + input1IntegerBinary;
                input2IntegerBinary = 0 + input2IntegerBinary;
            }
            else
            {
                int differnceOfLength = input2IntBinaryLength - input1IntBinaryLength;
                while (differnceOfLength != 0)
                {
                    input1IntegerBinary = 0 + input1IntegerBinary;
                    differnceOfLength--;
                }
                input1IntegerBinary = 0 + input1IntegerBinary;
                input2IntegerBinary = 0 + input2IntegerBinary;
            }

            //To make both with equal length On FractionalBinaryString
            if (input1FractionalBinaryLength >= input2FractionalBinaryLength)
            {
                int differnceOfLength = input1FractionalBinaryLength - input2FractionalBinaryLength;
                while (differnceOfLength != 0)
                {
                    input2FractionalBinary += 0;
                    differnceOfLength--;
                }
            }
            else
            {
                int differnceOfLength = input2FractionalBinaryLength - input1FractionalBinaryLength;
                while (differnceOfLength != 0)
                {
                    input1FractionalBinary += 0;
                    differnceOfLength--;
                }

            }

            string additionOfFractionalBinary = binary.AddingDecimal(input1FractionalBinary, input2FractionalBinary, out int carry);
            string additonOfIntegerBinary = binary.AddingIntegers(input1IntegerBinary, input2IntegerBinary, carry);
            double resultantIntegerPart = 0;
            int exponent = 0;

            for (int index = additonOfIntegerBinary.Length - 1; index >= 0; index--)
            {
                if (additonOfIntegerBinary[index] == '1')
                {
                    resultantIntegerPart += Math.Pow(2, exponent);
                }
                exponent++;
            }

            double resultantFractionalPart = 0;
            exponent = -1;
            int FractionalPartBinaryLength = additionOfFractionalBinary.Length - 1;
            int indx = 0;

            while (indx <= FractionalPartBinaryLength)
            {
                if (additionOfFractionalBinary[indx] == '1')
                {
                    resultantFractionalPart += Math.Pow(2, exponent);
                }
                indx++;
                exponent--;

            }
            return resultantIntegerPart + resultantFractionalPart;
        }
    }
}
