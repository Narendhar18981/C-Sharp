namespace DataLayer
{
    /// <summary>
    /// class to access the constructor of the datalayers
    /// </summary>
    public class DALFactory
    {
        DALAuthentication DALAuthObj;

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
