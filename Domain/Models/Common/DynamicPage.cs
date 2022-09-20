using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.Common
{
    public class DynamicPage:BaseEntity<int>
    {
        [Display(Name = "عنوان")][Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public string Title { get; set; }
        [MaxLength()]
        public string Content { get; set; }
    }
}
