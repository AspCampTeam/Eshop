using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models.FAQ;

namespace Application.Interface
{
    public interface IFaqService
    {
        #region Site

        Task<List<FAQ>> GetFaqListAsync();

        #endregion
    }
}
