using System;
using System.Collections.Generic;
/// <summary>
/// performs substrings and ListOfSubstringIndexes
/// </summary>
public class StringSearch
        {
        /// <summary>
        /// Returns substring of the given string from index point
        /// </summary>
        /// <param name="index"></param>
        /// <param name="str1"></param>
        /// <returns></returns>
        public string Substrings(int index,string input)
        {
            string subString = "";
            for(int i=index;i<=input.Length;i++)
            subString += input[i];
            return subString;
        }
        
        /// <summary>
        /// Returns the list of index positions of returns the list of indexes where secoudString is a Substring of firstString
        /// </summary>
        /// <param name="firstString"></param>
        /// <param name="secondString"></param>
        /// <returns></returns>
        public List<int> ListOfSubstringIndexes(string firstString,string secondString)
        {
            List<int> indexPositions = new List<int>();
            int len = secondString.Length;
            int index = 0;
        
            //loops to checkfor substring
            while ( firstString.Length>=len )
            {
                if (secondString == Substrings(0, firstString))
                {
                    indexPositions.Add(index);
                }
                firstString = Substrings(1, firstString);
                index++;
            }
            return indexPositions;
        }
    }
