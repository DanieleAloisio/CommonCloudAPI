using CommonCloud.Repository.Models;
using Microsoft.EntityFrameworkCore;
using RepositoryUsers.Interface;

namespace RepositoryUsers.Services
{
    /// <summary>
    /// Repository User
    /// </summary>

    public class UserRepository : IUserRepository
    {
        private ApiDbContext _apiDbContext;

        public UserRepository(ApiDbContext apiDbContext)
        {
            _apiDbContext = apiDbContext;
        }

        public async Task<List<AccountReteModel>> GetAllUsers()
        {
            return await _apiDbContext.VW_AccountRete.ToListAsync();
        }

        public async Task<List<AccountReteModel>> GetUsersByAccount(string account)
        {
            return await _apiDbContext.VW_AccountRete.Where(x => x.Account.Contains(account)).ToListAsync();
        }

        public async Task<List<AccountReteModel>> GetUsersByEmail(string email)
        {
            return await _apiDbContext.VW_AccountRete.Where(x => x.Email.Contains(email)).ToListAsync();
        }

        public async Task<List<AccountReteModel>> GetUsersByFreeSearch(string text)
        {
            return await _apiDbContext.VW_AccountRete.Where(x => x.Email.Contains(text) ||
                                                         x.Matricola.Contains(text) ||
                                                         x.Nome.Contains(text) ||
                                                         x.Cognome.Contains(text) ||
                                                         x.Account.Contains(text)
                                                         ).ToListAsync();
        }

        public async Task<List<AccountReteModel>> VW_AccountRete(string text)
        {
            return await _apiDbContext.VW_AccountRete.Where(x => x.Email.Contains(text) ||
                                                         x.Matricola.Contains(text) ||
                                                         x.Nome.Contains(text) ||
                                                         x.Cognome.Contains(text) ||
                                                         x.Account.Contains(text)
                                                         ).ToListAsync();
        }

        public async Task<List<AccountReteModel>> GetUsersByMatricola(string matricola)
        {
            return await _apiDbContext.VW_AccountRete.Where(x => x.Matricola.Contains(matricola)).ToListAsync();
        }
    }
}
