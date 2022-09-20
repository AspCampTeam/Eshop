using Application.Interface;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models.Banner;

namespace Application.Services
{
    public class BannerService:IBannerService
    {
        #region Injections
        private IBannerRepository _bannerRepository;

        public BannerService(IBannerRepository bannerRepository)
        {
            _bannerRepository = bannerRepository;
        }
        #endregion

        public Task<List<Banner>> GetBannerListAsync()
        {
            return _bannerRepository.GetBannerListAsync();
        }
    }
}
