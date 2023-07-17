using BusinessModels;

namespace ConsoleApp
{
    public class ConsoleApp
    {
        public static void Main()
        {
            while (true)
            {
                Authentication authenticate = new();
                Console.WriteLine(StringLiterals.choice);
                int input = Convert.ToInt32(Console.ReadLine());

                switch (input)
                {
                    case (int)UserChoice.Login:
                        authenticate.Login();
                        break;
                    case (int)UserChoice.Signup:
                        authenticate.Register();
                        break;
                    case (int)UserChoice.exit:
                        return;
                    default:
                        Console.WriteLine(StringLiterals.invalidChoice);
                        break;
                }
            }
        }
    }
}