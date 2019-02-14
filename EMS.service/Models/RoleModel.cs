using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace EMS.service.Models
{
    public class RoleModel
    {
        [DataMember]
        public int ID { get; set; }
        [DataMember]
        public string Description { get; set; }
        [DataMember]
        public Nullable<int> RateID { get; set; }
        [DataMember]
        public string SelectedRate { get; set; }
        [DataMember]
        public RateModel Rate { get; set; }
    }
}
