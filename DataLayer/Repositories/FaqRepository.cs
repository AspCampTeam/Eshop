using DataLayer.DbContext;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models.FAQ;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Repositories
{
    public class FaqRepository:IFaqRepository
    {
        #region Injections

        private ApplicationDbContext _context;

        public FaqRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        #endregion

        public async Task<List<FAQ>> GetAllFAQsAsync()
        {
            return await _context.FAQs.ToListAsync();
        }
    }
}
