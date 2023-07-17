using BusinessModels;

namespace DataLayer
{
    /// <summary>
    /// interface to access the methods inside the DALAuthentication
    /// </summary>
    public interface IData
    {
        bool Login(User user);
        bool Register(User user);
    }
}
