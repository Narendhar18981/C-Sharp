namespace BusinessModels
{
    /// <summary>
    /// Stores the current entered values
    /// </summary>
    public class User
    {
        private string userName;
        private string password;
        private string mobileNo;
        private string email;

        public string UserName { get => userName; set => userName = value; }
        public string Password { get => password; set => password = value; }
        public string MobileNo { get => mobileNo; set => mobileNo = value; }
        public string Email { get => email; set => email = value; }
    }
}
