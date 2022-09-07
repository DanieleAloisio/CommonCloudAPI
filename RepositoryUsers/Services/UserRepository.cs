using Microsoft.EntityFrameworkCore;
using RepositoryUsers.Interface;
using RepositoryUsers.Models;

namespace RepositoryUsers.Services
{
    public class UserRepository : IUserRepository
    {
        private ApiDbContext _apiDbContext;

        public UserRepository(ApiDbContext apiDbContext)
        {
            _apiDbContext = apiDbContext;
        }

        public async Task<List<UserModel>> GetAllUsers()
        {
            return await _apiDbContext.Users.ToListAsync();
        }

        public Task<UserModel> GetUserByAccount(string account)
        {
            throw new NotImplementedException();
        }

        public async Task<List<UserModel>> GetUserByEmail(string email)
        {
            return await _apiDbContext.Users.Where(x => x.Email == email).ToListAsync();
        }

        public Task<IEnumerable<UserModel>> GetUserByFreeSearch(string text)
        {
            throw new NotImplementedException();
        }

        public Task<UserModel> GetUserByRegistrationNumber(string registrationNumber)
        {
            throw new NotImplementedException();
        }

        Task<List<UserModel>> IUserRepository.GetUserByFreeSearch(string text)
        {
            throw new NotImplementedException();
        }
    }
}
