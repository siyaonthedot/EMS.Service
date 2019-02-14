using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace EMS.service.Models
{
    [DataContract]
    public class RateModel
    {
        [DataMember]
        public int ID { get; set; }
        [DataMember]
        public decimal Amount { get; set; }
        [DataMember]
        public string Description { get; set; }

    }
}

