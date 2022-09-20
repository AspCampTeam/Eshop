﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models.Common;
using Domain.ViewModels.DynamicPage;

namespace Domain.Interfaces
{
    public interface IDynamicPageRepository
    {
        Task<int> AddDynamicPage(DynamicPage model);

        Task<FilterDynamicPageViewModel> GetAllPagesForAdmin(FilterDynamicPageViewModel filter);

        Task<int> AddDynamicLink(DynamicLink link);

        Task<DynamicPage> GetPageByTitle(string title);
        Task<bool> DeleteDynamicPage(int id);
    }
}
