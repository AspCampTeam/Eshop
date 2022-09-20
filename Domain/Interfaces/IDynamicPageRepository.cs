using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models.Common;

namespace Domain.Interfaces
{
    public interface IDynamicPageRepository
    {
        Task<int> AddDynamicPage(DynamicPage model);

        Task<bool> DeleteDynamicPage(int id);
    }
}
