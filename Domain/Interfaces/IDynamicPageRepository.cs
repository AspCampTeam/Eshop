using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IDynamicPageRepository
    {

        Task<int> AddDynamicLink(DynamicLink link);

        Task<bool> DeleteDynamicPage(int id);
    }
}
