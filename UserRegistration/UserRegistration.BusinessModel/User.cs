namespace UserRegistration.BusinessModel
{
    public class User
    {
        private string userName;
        private string password;
        private string name;
        private string emailID;
        private string confirmPassword;

        public string UserName { get => userName; set => userName = value; }
        public string Password { get => password; set => password = value; }
        public string Name { get => name; set => name = value; }
        public string EmailID { get => emailID; set => emailID = value; }
        public string ConfirmPassword { get => confirmPassword; set => confirmPassword = value; }
    }
}
