using DataLayer.DbContext;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models.Banner;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Repositories
{
    public class BannerRepository:IBannerRepository
    {
        #region Injections
        private ApplicationDbContext _context;

        public BannerRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        #endregion

        public async Task<List<Banner>> GetBannerListAsync()
        {
           return await _context.Banners.ToListAsync();
        }
    }
}
