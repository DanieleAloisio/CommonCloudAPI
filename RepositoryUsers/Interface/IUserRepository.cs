using CommonCloud.Repository.Models;

namespace RepositoryUsers.Interface
{
    public interface IUserRepository
    {
        Task<List<AccountReteModel>> GetAllUsers();
        Task<List<AccountReteModel>> GetUsersByEmail(string email);
        Task<List<AccountReteModel>> GetUsersByMatricola(string registrationNumber);
        Task<List<AccountReteModel>> GetUsersByAccount(string account);
        Task<List<AccountReteModel>> GetUsersByFreeSearch(string text);
        Task<List<AccountReteModel>> VW_AccountRete(string text);
    }
}
