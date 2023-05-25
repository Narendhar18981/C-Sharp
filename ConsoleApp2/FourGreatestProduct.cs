using System;
public class FourGreatestProduct
{
    /// <summary>
    /// Gets four digits which have max product value
    /// </summary>
    /// <param name="Input"></param>
    /// <returns></returns>
    public String GetFourGreatestSolution(string Input)
    {
        string fourDigitGreatestProduct = string.Empty;
        int MaxProduct = 0;     

        for (int index = 0; index + 3 < Input.Length; index++)
        {
            int Digit1, Digit2, Digit3, Digit4;

            Digit1 = Input[index] - '0';
            Digit2 = Input[index + 1] - '0';
            Digit3 = Input[index + 2] - '0';
            Digit4 = Input[index + 3] - '0';

            
            if (MaxProduct < Digit1 * Digit2 * Digit3 * Digit4)
            {
                MaxProduct = Digit1 * Digit2 * Digit3 * Digit4;
                fourDigitGreatestProduct = Digit1 + "*" + Digit2 + "*" + Digit3 + "*" + Digit4 + "=" + MaxProduct;
            }
        }
        return fourDigitGreatestProduct;
    }
}
