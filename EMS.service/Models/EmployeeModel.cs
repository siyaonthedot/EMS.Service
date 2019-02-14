using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Web;
using System.Runtime.Serialization;
//using System.Runtime.Serialization.DataMemberAttribute;
using System.ComponentModel.DataAnnotations.Schema;

using System.Web.Mvc;

namespace EMS.service.Models
{
    [DataContract]
    public class EmployeeModel
    {
        [DataMember]
        public int ID { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Surname { get; set; }
        [DataMember]
        public DateTime DOB { get; set; }
        [DataMember]
        public string IDNumber { get; set; }
        [DataMember]
        public DateTime DateHired { get; set; }
        [DataMember]
        public string SelectedRole { get; set; }

    }
}