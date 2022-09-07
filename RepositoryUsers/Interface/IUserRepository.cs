using RepositoryUsers.Models;

namespace RepositoryUsers.Interface
{
    public interface IUserRepository
    {
        Task<List<UserModel>> GetAllUsers();
        Task<List<UserModel>> GetUserByEmail(string email);
        Task<UserModel> GetUserByRegistrationNumber(string registrationNumber);
        Task<UserModel> GetUserByAccount(string account);
        Task<List<UserModel>> GetUserByFreeSearch(string text);

    }
}
