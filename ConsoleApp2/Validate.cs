using System;

public class Validate
{
	//the method is used to validate the given input
	public bool Is_CheckForCharAndLength(string input)
	{	
		//the below if condition check for where the input length is less than 4
		//if the length is less than four then it returns an excetion
		//saying (" Enter more than 3 digits as an input")
		if (input.Length < 4)
			throw new Exception("Enter more than 3 digits as an input");

		//the below loop is to check wheathe the given input contains anything other than digits
		// if anything other than digits are found then it returns an exception
		//saying("Enter only numeric values as an input")
		for(int index = 0; index <input.Length; index++)
		{
			if (!(input[index] >= 48 && input[index] <= 57))
			{
				throw new Exception("Enter only numeric values as an input");
			}
		}

		//if everything works fine then return to main code
        return true;
    }
}
