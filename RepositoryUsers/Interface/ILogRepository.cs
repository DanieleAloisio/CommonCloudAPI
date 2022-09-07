using CommonCloud.Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonCloud.Repository.Interface
{
    public interface ILogRepository
    {
        Task<bool> WriteLog(LogModel log);

    }
}
