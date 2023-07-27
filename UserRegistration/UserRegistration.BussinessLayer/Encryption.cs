
namespace UserRegistration.BusinessLayer
{
    internal class Encryption
    {
        public  string Encrypt(string input)
        {
            char key = 'a';
            string temp = "";
            foreach(char c in input)
            {
                temp += (c ^ key);
            }
            input = "";
            foreach(char c in temp)
            {
                input+= (c ^ key);
            }
            return input;
        }
    }
}