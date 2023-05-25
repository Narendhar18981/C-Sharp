using System;
/// <summary>
/// Validates the given inputs
/// </summary>
public class Validation
{
    /// <summary>
    /// checks for wheather the inputs are null and secoundstring is larger than firststring or not
    /// </summary>
    /// <param name="firstString"></param>
    /// <param name="secondString"></param>
    /// <returns></returns>
    /// <exception cref="Exception"></exception>
    public bool CheckInputs(string firstString,string secondString)
    {
        //check if any of the variable is null
        if (firstString.Length==0 || secondString.Length==0)
            throw new Exception("Do not enter null values as inputs");

        //check if firststring length is Less than that of secound string
        if (firstString.Length < secondString.Length)
            throw new Exception("Length of the first String should be greater than the secound string");

        return true;
    }
}
