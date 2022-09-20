using Application.Interface;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models.FAQ;

namespace Application.Services
{
    public class FaqService : IFaqService
    {
        #region Injections

        private IFaqRepository _faqRepository;

        public FaqService(IFaqRepository faqRepository)
        {
            _faqRepository = faqRepository;
        }

        #endregion

        public async Task<List<FAQ>> GetFaqListAsync()
        {
            return await _faqRepository.GetAllFAQsAsync();
        }
    }
}
