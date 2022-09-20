using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.DbContext;
using Domain.Interfaces;

namespace DataLayer.Repositories
{
    public class DynamicPageRepository:IDynamicPageRepository
    {
        private ApplicationDbContext _context;

        public DynamicPageRepository(ApplicationDbContext context)
        {
            _context = context;
        }
    }
}
