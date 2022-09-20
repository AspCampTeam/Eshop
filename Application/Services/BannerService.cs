using Application.Convertor;
using Application.Interface;
using DataLayer.Repositories;
using Domain.Interfaces;
using Domain.Models.Banner;
using Domain.Models.Product;
using Domain.ViewModels.Banner;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models.Banner;
using TopLearn.Core.Generator;

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

        public async Task<bool> AddBannerFromAdmin(AddOrEditBannerViewModel model)
        {
            var addImage = new Banner();
            if (model.Image != null)
            {
                string imagepath = "";
                addImage.ImageName = NameGenerator.GeneratorUniqCode() + Path.GetExtension(model.Image.FileName);
                imagepath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Images/banners", addImage.ImageName);

                await using (var stream = new FileStream(imagepath, FileMode.Create))
                {
                    model.Image.CopyTo(stream);
                }
                addImage.Link = model.Link;
                addImage.BannerCol = (Domain.Models.Enums.BannerCol)model.Size;
                addImage.Position = (Domain.Models.Enums.BannerPosition)model.Position;
                addImage.IsDelete = false;
                addImage.CreatDate = DateTime.Now;
                return await _bannerRepository.AddBanner(addImage);
            }
            else
            {
                return false;
            }
        }

        public async Task<bool> DeleteBannerFromAdmin(int id)
        {
            var model =await _bannerRepository.GetBannerById(id);
            if (model != null)
            {
                string deletPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Images/banners", model.ImageName);
                if (File.Exists(deletPath))
                {
                    File.Delete(deletPath);
                }



                return await _bannerRepository.RemoveBanner(id);
            }
            return false;
        }

        public async Task<bool> EditBannerFromAdmin(AddOrEditBannerViewModel banner)
        {
            var model = await _bannerRepository.GetBannerById(banner.Id);
            if (model != null)
            {
                string deletPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Images/banners", model.ImageName);
                if (File.Exists(deletPath))
                {
                    File.Delete(deletPath);
                }
                string imagepath = "";
                model.ImageName = NameGenerator.GeneratorUniqCode() + Path.GetExtension(banner.Image.FileName);
                imagepath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Images/banners", model.ImageName);

                await using (var stream = new FileStream(imagepath, FileMode.Create))
                {
                    banner.Image.CopyTo(stream);
                }
                model.Link = banner.Link;
                model.BannerCol = (Domain.Models.Enums.BannerCol)banner.Size;
                model.Position = (Domain.Models.Enums.BannerPosition)banner.Position;
                await _bannerRepository.UpdateBanner(model);
                return true;
               
            }
            return false;
        }

        public async Task<FilterBannerViewModel> GetAllBannersForAdmin(FilterBannerViewModel filter)
        {
            return await _bannerRepository.GetAllBanners(filter);

        }



    }
}
