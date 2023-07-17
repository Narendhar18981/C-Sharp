using BusinessModels;

namespace BusinessLayer
{
    public interface IBAL
    {
        bool Login(User user);
        bool Register(User user);
    }
}
