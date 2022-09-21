using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.ViewModels.Log;

namespace Application.Interface
{
    public interface ILoggerService
    {
        Task<bool> AddLog(int userId,string message);

        Task<FilterUserLogViewModel> GetLog(FilterUserLogViewModel filter);
    }
}
