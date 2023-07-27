namespace UserRegistration.DataAccessLayer
{
    public class DALFactory
    {
        readonly DALAuthentication DALAuthObj;

        public DALFactory()
        {
            DALAuthObj = new DALAuthentication();
        }
        // constructor

        /// <summary>
        /// Method used to create an object for DALAuthentication
        /// </summary>
        /// <returns></returns>
        public IData GetDALAuthObject()
        {
            return DALAuthObj;
        }
    }
}
