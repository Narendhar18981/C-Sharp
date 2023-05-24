using System;
using System.Security.Cryptography;

namespace a11
{
    public class StringSearch
    {
        string s2;
        string s1;
        public StringSearch(string str1,string str2)
        {
            s1 = str1;
            s2 = str2;
        }
        string indexPositions = "";
        int count = 0;
        public void solution()
        {
            int len = s2.Length;
            int k = 0;
            while ( s1.Length>=len )
            {
                if (s2 == s1.Substring(0, s2.Length))
                {
                    indexPositions +=" "+k;
                    count++;
                }
                s1 = s1.Substring(1);
                k++;
            }
            Console.WriteLine("No.of times occurred = " + count + "\nIndex positions = " + indexPositions);
        }
    }
    public class MainClass
    {
        public static void Main()
        {
            string s1=Console.ReadLine();
            string s2=Console.ReadLine();
            StringSearch Obj=new StringSearch(s1,s2);
            Obj.solution();
        }
    }
}