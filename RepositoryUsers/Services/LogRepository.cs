using CommonCloud.Repository.Interface;
using CommonCloud.Repository.Models;
using Microsoft.EntityFrameworkCore;
using RepositoryUsers.Interface;
using RepositoryUsers.Models;

namespace RepositoryUsers.Services
{
    public class LogRepository : ILogRepository
    {
        private ApiDbContext _apiDbContext;

        public LogRepository(ApiDbContext apiDbContext)
        {
            _apiDbContext = apiDbContext;
        }

        public async Task<bool> WriteLog(LogModel log)
        {
            _apiDbContext.Log.Add(log);
            return Save();
        }

        private bool Save()
        {
            var saved = _apiDbContext.SaveChanges();
            return saved >= 0 ? true : false;

        }
    }
}
