using Domain.ViewModels.Banner;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interface
{
    public interface IBannerService
    {
        #region Admin
        Task<FilterBannerViewModel> GetAllBannersForAdmin(FilterBannerViewModel filter);
        Task<bool> AddBannerFromAdmin(AddOrEditBannerViewModel model);
        Task<bool> EditBannerFromAdmin(AddOrEditBannerViewModel banner);
        Task<bool> DeleteBannerFromAdmin(int id);
        Task<AddOrEditBannerViewModel> GetBannerById(int id);
        #endregion
    }
}
