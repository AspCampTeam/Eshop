using Domain.Models.FAQ;
using Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IFaqRepository
    {
        #region Admin

        Task<bool> AddQuestion(FAQ faq);
        Task<bool> DeleteQuestion(int faqId);
        Task<FAQ> GetFaqById(int faqId);
        Task<FilterFaqViewModel> GetAllFaqForAdmin(FilterFaqViewModel filter);
        Task<bool> UpdateFaq(FAQ faq);
        Task<bool> Save();


        #endregion
    }
}
