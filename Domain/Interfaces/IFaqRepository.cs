using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models.FAQ;

namespace Domain.Interfaces
{
    public interface IFaqRepository
    {


        #region Site

        Task<List<FAQ>> GetAllFAQsAsync();

        #endregion
    }
}
