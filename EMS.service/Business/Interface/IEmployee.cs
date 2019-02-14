using System;
using System.Collections.Generic;
using System.Linq;
using EMS.service.Models;
using System.Web;

namespace EMS.service.Business.Interface
{
   public interface  IEmployee
    {
         List<EmployeeModel> GetAllEmployee();
        string AddUpdateEmployee(EmployeeModel empModel);
        EmployeeModel GetEmployeeByID(int id);
        void DeleteEmployee(int id);

    }
}