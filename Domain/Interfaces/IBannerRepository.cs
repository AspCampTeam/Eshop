﻿using Domain.Models.Banner;
using Domain.ViewModels.Banner;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IBannerRepository
    {
        #region Admin
        
        Task<bool> AddBanner(Banner banner);
        Task<bool> RemoveBanner(int bannerId);
        Task<Banner> GetBannerById(int id);
        Task<FilterBannerViewModel> GetAllBanners(FilterBannerViewModel filter);
        Task<Banner> UpdateBanner(Banner banner);

        #endregion
        Task<bool> Save();
    }
}