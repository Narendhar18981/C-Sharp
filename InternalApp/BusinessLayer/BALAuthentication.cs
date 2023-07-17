using BusinessModels;
using DataLayer;
namespace BusinessLayer
{
    /// <summary>
    /// Businesslayer authentication class
    /// </summary>
    internal class BALAuthentication : IBAL
    {
        /// <summary>
        /// get values from ui and send it into dataacceesslayer for login
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public bool Login(User user)
        {
            DALFactory fact = new DALFactory();
            IData Idata = fact.GetDALAuthObject();

            //DALAuthentication validate = new();
            return Idata.Login(user);
        }
        /// <summary>
        /// get values from ui and send it into dataAccessLayer for Registering
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public bool Register(User user)
        {
            DALFactory fact = new();
            IData Idata = fact.GetDALAuthObject();
            //DALAuthentication validate = new();
            return Idata.Register(user);
        }
    }
}
