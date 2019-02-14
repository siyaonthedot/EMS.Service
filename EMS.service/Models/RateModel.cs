using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS.service.Models
{
    public class RateModel
    {
        public int ID { get; set; }
        public Nullable<decimal> Amount { get; set; }
        public string Description { get; set; }
        public RoleModel RoleModel { get; set; }
    }
}

