using Application.Interface;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models.Common;
using Domain.ViewModels.Log;

namespace Application.Services
{
    public class LoggerService : ILoggerService
    {
        private ILoggerRepository _loggerRepository;

        public LoggerService(ILoggerRepository loggerRepository)
        {
            _loggerRepository = loggerRepository;
        }

        public async Task<bool> AddLog(int entityId,int userId, string message)
        {
            var addLog = new Log()
            {
                CreatDate = DateTime.Now,
                UserId = userId,
                Desctiption = message,
                IsDelete = false,
                EntityId = entityId
            };
            return await _loggerRepository.AddLogToUser(addLog);
        }

        public async Task<FilterUserLogViewModel> GetLog(FilterUserLogViewModel filter)
        {
            return await _loggerRepository.GetAllLogsOfAdmins(filter);
        }
    }
}
