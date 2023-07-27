using UserRegistration.BusinessModel;

namespace UserRegistration.BusinessLayer
{
    public interface IBAL
    {
        string Login(User user);
        string Register(User user);
        string UpdatePassword(User user);
    }
}
