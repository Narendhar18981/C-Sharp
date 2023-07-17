
namespace BusinessLayer
{
    /// <summary>
    /// class to access the constructor of the datalayers
    /// </summary>
    public class BALFactory
    {
        BALAuthentication BALAuthObj;
        public BALFactory()
        {
            BALAuthObj = new BALAuthentication();
        }
        /// <summary>
        /// Method used to create an object for DALAuthentication
        /// </summary>
        /// <returns></returns>
        public IBAL GetBALAuthObject()
        {
            return BALAuthObj;
        }
    }
}
