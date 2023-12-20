using CloudCustomers.Lib.Models;

namespace CloudCustomers.Lib.Services
{
    public interface IUserService
    {
        public Task<List<User>> GetAllUsers();
    }

    public class UsersService: IUserService
    {
        public UsersService()
        {
            
        }

        public Task<List<User>> GetAllUsers()
        {
            throw new NotImplementedException();
        }
    }
}
