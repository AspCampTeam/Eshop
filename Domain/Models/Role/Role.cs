using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.Role
{
    public class Role:BaseEntity<int>   
    {
        public string RoleTitle { get; set; }

    }
}
