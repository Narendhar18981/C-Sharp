using UserRegistration.BusinessModel;

namespace UserRegistration.DataAccessLayer
{
    public interface IData
    {
        string Login(User user);
        string Register(User user);
        string UpdatePassword(User user);
    }
}
