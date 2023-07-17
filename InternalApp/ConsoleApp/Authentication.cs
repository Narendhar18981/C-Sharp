using BusinessLayer;
using BusinessModels;
namespace ConsoleApp
{
    /// <summary>
    /// Consist of login and register methods
    /// </summary>
    public class Authentication
    {

        /// <summary>
        /// reads two inputs username and password for login
        /// </summary>
        /// <returns></returns>
        public void Login()
        {
            BALFactory factObj = new BALFactory();
            IBAL Ibal = factObj.GetBALAuthObject();

            Console.WriteLine(StringLiterals.userName);
            User user = new User();
            user.UserName = Console.ReadLine();

            Console.WriteLine(StringLiterals.password);
            user.Password = Console.ReadLine();

            if (Ibal.Login(user))
            {
                Console.WriteLine(StringLiterals.welcome);
                Console.WriteLine(StringLiterals.logout);

                Console.ReadKey();
                Console.WriteLine(StringLiterals.loggedOut);
            }
            else
            {
                Console.WriteLine(StringLiterals.invalidLogin);
            }
        }
        /// <summary>
        /// Reads data from the user and validates them;
        /// </summary>
        /// <returns></returns>
        public void Register()
        {
            BALValidations validate = new BALValidations();
            User user = new User();
            BALFactory factObject = new BALFactory();
            IBAL Ibal = factObject.GetBALAuthObject();

            while (true)
            {
                Console.WriteLine(StringLiterals.emailId);
                user.Email = Console.ReadLine();
                if (validate.IsEmailId(user.Email))
                {
                    break;
                }
                Console.WriteLine(StringLiterals.invalidEmailId);
            }

            while (true)
            {
                Console.WriteLine(StringLiterals.mobileNumber);
                user.MobileNo = Console.ReadLine();
                if (validate.IsMobileNo(user.MobileNo))
                {
                    break;
                }
                Console.WriteLine(StringLiterals.invalidMobile);
            }

            while (true)
            {
                Console.WriteLine(StringLiterals.userName);
                user.UserName = Console.ReadLine();
                if (validate.IsUserName(user.UserName))
                {
                    break;
                }
                Console.WriteLine(StringLiterals.invalidUserName);
            }

            while (true)
            {
                Console.WriteLine(StringLiterals.password);
                user.Password = Console.ReadLine();
                if (validate.IsPassword(user.Password))
                {
                    Console.WriteLine(StringLiterals.rePassword);
                    string confirmPassword = Console.ReadLine();
                    if (confirmPassword == user.Password)
                    {
                        break;
                    }
                    Console.WriteLine(StringLiterals.passwordMismatch);
                }
                else
                {
                    Console.WriteLine(StringLiterals.invalidPassword);
                }
            }

            if (!Ibal.Register(user))
            {
                Console.WriteLine(StringLiterals.userIdExists);
            }
            else
            {
                Console.WriteLine(StringLiterals.success);
            }
        }
    }
}
