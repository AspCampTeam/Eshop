using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Interface;
using Domain.Interfaces;

namespace Application.Services
{
    public class DynamicPageService:IDynamicPageService
    {
        private IDynamicPageRepository _dynamicPageRepository;

        public DynamicPageService(IDynamicPageRepository dynamicPageRepository)
        {
            _dynamicPageRepository = dynamicPageRepository;
        }
    }
}
