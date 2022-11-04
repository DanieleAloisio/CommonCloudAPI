using CommonCloud.Repository.Models;

namespace RepositoryUsers.Interface
{
    public interface IUserRepository
    {
        Task<List<UserModel>> GetAllUsers();
        Task<List<UserModel>> GetUsersByEmail(string email);
        Task<List<UserModel>> GetUsersByMatricola(string registrationNumber);
        Task<List<UserModel>> GetUsersByAccount(string account);
        Task<List<UserModel>> GetUsersByFreeSearch(string text);
        Task<List<AccountReteModel>> VW_AccountRete(string text);
    }
}
