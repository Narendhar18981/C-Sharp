namespace UserRegistration.BusinessLayer
{
    public class BALFactory
    {
        readonly BALAuthentication BALAuthObj;

        public BALFactory()
        {
            BALAuthObj = new BALAuthentication();
        }
        // constructor

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
