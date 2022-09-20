using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Interface;
using Domain.Interfaces;
using Domain.Models.Common;
using Domain.Models.Enums;
using Domain.ViewModels.DynamicPage;

namespace Application.Services
{
    public class DynamicPageService:IDynamicPageService
    {
        private IDynamicPageRepository _dynamicPageRepository;

        public DynamicPageService(IDynamicPageRepository dynamicPageRepository)
        {
            _dynamicPageRepository = dynamicPageRepository;
        }

        public async Task<int> AddDynamicPage(DynamicPageViewModelAdmin model)
        {
            var addPage = new DynamicPage()
            {
                Content = model.Content,
                CreatDate = DateTime.Now,
                IsDelete = false,
                Title = model.Title,
                
            };
            var id= await _dynamicPageRepository.AddDynamicPage(addPage);

            var addLink = new DynamicLink()
            {
                IsDelete = false,
                Title = model.Title,
                CreatDate = DateTime.Now,
                ExpirationDate = null,
                LinkUrl = model.UrlLink,
                Position = PositionLinks.Footer,

            };

            var linkId = _dynamicPageRepository.AddDynamicLink(addLink);
            return id;
        }

        public Task<int> AddDynamicLink(DynamicPageViewModelAdmin link)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteDynamicPage(int id)
        {
            throw new NotImplementedException();
        }
    }
}
