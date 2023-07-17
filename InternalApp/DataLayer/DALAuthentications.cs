using BusinessModels;
namespace DataLayer
{
    /// <summary>
    /// Validates the data by using the database
    /// </summary>
    internal class DALAuthentication : IData
    {
        /// <summary>
        /// Validates the user
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public bool Login(User user)
        {
            User usb = DataSource.Users.Find(DataBase => DataBase.UserName == user.UserName);
            if (usb != null)
            {
                if (usb.Password == user.Password)
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Check wheather the username present in the database ,if not present it insert into the database
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public bool Register(User user)
        {
            User details = DataSource.Users.Find(Users => Users.UserName == user.UserName);
            if (details != null)
            {
                return false;
            }
            AddUser(user);
            return true;
        }
        /// <summary>
        /// Method used to add data to the list
        /// </summary>
        /// <param name="user"></param>
        public void AddUser(User user)
        {
            DataSource.Users.Add(user);
        }
    }
}