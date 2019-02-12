using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using EMS.Model;
using EMS.service.Business.Interface;
using System.Text;

namespace EMS.service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "EmsService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select EmsService.svc or EmsService.svc.cs at the Solution Explorer and start debugging.
    public class EmsService : IEmsService
    {
        private IEmployee _iemployee { get; set; }
        private IRate _irate;
        private IRole _irole;

        public void DoWork() 
        {
        }

        public string CreateRate(RateModel model)
        {
           // _irate.AddUpdateEmployee()

            return string.Empty;
        }
        public string CreateEmployee(EmployeeModel model)
        {
            string result = _iemployee.AddUpdateEmployee(model);

            return result;
        }
        public string CreateRole(RoleModel model)
        {

            return string.Empty;
        }
    }


}
