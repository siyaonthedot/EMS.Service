using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using EMS.service.Models;
using EMS.service.Business.Interface;
using EMS.service.Business.Models;
using GMS.Data.DBContext.Models;
using GMS.Data.DBContext.Interface;
using System.Text;

namespace EMS.service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "EmsService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select EmsService.svc or EmsService.svc.cs at the Solution Explorer and start debugging.
    public class EmsService : IEmsService
    {
        //private UnitOfWork unitOfWork; //= new UnitOfWork();
        private IEmployee _iemployee = new EmployeeBusiness();
        private IRate _irate = new RateBusiness();
        private IRole _irole = new RoleBusiness();

        public void DoWork() { } 
        
        
        public string CreateRate(RateModel model)
        {
            string result = _irate.AddUpdateRate(model);

            return result;
        }
        public string CreateEmployee(EmployeeModel model)
        {
            string result = _iemployee.AddUpdateEmployee(model);

            return result;
        }

        public string CreateRole(RoleModel model)
        {
            string result = _irole.AddUpdateRole(model);

            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<RateModel> GetAllRates()
        {
            var list = _irate.GetAllRates();

            return list;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<RoleModel> GetAllRoles()
        {
            var list = _irole.GetAllRoles();

            return list;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<EmployeeModel> GetAllEmployees()

        {
            var list = _iemployee.GetAllEmployee();

            return list;
        }

    }


}
