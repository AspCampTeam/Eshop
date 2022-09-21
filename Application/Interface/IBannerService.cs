using Domain.ViewModels.Banner;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models.Banner;

namespace Application.Interface
{
    public interface IBannerService
    {

        #region Site

        Task<List<Banner>> GetBannerListAsync();
        #endregion

        #region Admin
        Task<FilterBannerViewModel> GetAllBannersForAdmin(FilterBannerViewModel filter);
        Task<bool> AddBannerFromAdmin(AddOrEditBannerViewModel model);
        Task<bool> EditBannerFromAdmin(AddOrEditBannerViewModel banner);
        Task<bool> DeleteBannerFromAdmin(int id);

        #endregion
    }
}
