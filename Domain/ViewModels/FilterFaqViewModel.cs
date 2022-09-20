using Domain.Models.FAQ;
using Domain.ViewModels.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.ViewModels
{
    public class FilterFaqViewModel : BasePaging<FAQ>
    {
        public string Question { get; set; }
        public string Answer { get; set; }
    }
}
