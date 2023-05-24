using System;
public class FourGreatestProduct
{
    //the method below finds the four digits 
    //which produces the max product value
    public String Solution(string Input)
    {
        string fourDigitGreatestProduct = "";        //output parameter
        int MaxProduct = 0;     //varaible to store the greatest product value

        //the below loop is use for interating throughtout the input and find the result
        for (int index = 0; index + 3 < Input.Length; index++)
        {
            int Digit1, Digit2, Digit3, Digit4;

            Digit1 = Input[index] - '0';
            Digit2 = Input[index + 1] - '0';
            Digit3 = Input[index + 2] - '0';
            Digit4 = Input[index + 3] - '0';

            //it is use to check wheather the current product is greater than the previos maxproduct
            // if yes the current product value will be assigned to the maxproduct
            if (MaxProduct < Digit1 * Digit2 * Digit3 * Digit4)
            {
                MaxProduct = Digit1 * Digit2 * Digit3 * Digit4;
                fourDigitGreatestProduct = Digit1 + "*" + Digit2 + "*" + Digit3 + "*" + Digit4 + "=" + MaxProduct;
            }

        }
        return fourDigitGreatestProduct;
    }
}
