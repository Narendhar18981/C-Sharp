using UserRegistration.DataAccessLayer;
using UserRegistration.BusinessModel;

namespace UserRegistration.BusinessLayer
{
    internal class BALAuthentication : IBAL
    {
        /// <summary>
        /// get values from ui and send it into dataacceesslayer for login
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public string Login(User user)
        {
            if (user.UserName.Length == 0 || user.Password.Length == 0)
            {
                return StringLiterals.fieldsEmpty;
            }
            Encryption encrytpt = new Encryption();
            user.Password= encrytpt.Encrypt(user.Password);
            DALFactory fact = new DALFactory();
            IData Idata = fact.GetDALAuthObject();
            return Idata.Login(user);
        }

        /// <summary>
        /// get values from ui and send it into dataAccessLayer for Registering
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public string Register(User user)
        {
            if (user.Name.Length == 0 || user.UserName.Length == 0 || user.Password.Length == 0 || user.EmailID.Length == 0)
            {
                return StringLiterals.fieldsEmpty;
            }
            if (!(user.Password == user.ConfirmPassword))
            {
                return StringLiterals.misMatch;
            }
            Encryption encrytpt = new Encryption();
            user.Password = encrytpt.Encrypt(user.Password);

            DALFactory fact = new DALFactory();
            IData Idata = fact.GetDALAuthObject();

            return Idata.Register(user);
        }

        /// <summary>
        /// get values from ui and send it into dataAccessLayer for checking and Updating Password
        /// </summary>
        /// <param name="user"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public string UpdatePassword(User user)
        {
            if (user.UserName.Length == 0 || user.Password.Length == 0 || user.EmailID.Length == 0)
            {
                return StringLiterals.fieldsEmpty;
            }
            if (!(user.Password == user.ConfirmPassword))
            {
                return StringLiterals.misMatch;
            }

            Encryption encrytpt = new Encryption();
            user.Password = encrytpt.Encrypt(user.Password);

            DALFactory fact = new DALFactory();
            IData Idata = fact.GetDALAuthObject();

            return Idata.UpdatePassword(user);
        }
    }
}
