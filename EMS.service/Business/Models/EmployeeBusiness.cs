using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EMS.service.Models;
using GMS.Data.DBContext.Models;
using EMS.service.DBContex;
using EMS.service.Business.Interface;
using GMS.Data.DBContext.Interface;

namespace EMS.service.Business.Models
{
   public class EmployeeBusiness : IEmployee
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly EmployeeRepository empRepository;

        public EmployeeBusiness()
        {
            unitOfWork = new UnitOfWork();
            empRepository = new EmployeeRepository(unitOfWork);
        }

        public EmployeeBusiness(IUnitOfWork _unitOfWork)
        {

            unitOfWork = _unitOfWork;
            empRepository = new EmployeeRepository(unitOfWork);
        }

        #region

        public List<EmployeeModel> GetAllEmployee()
        {
            List<EmployeeModel> list = empRepository.GetAll().Select(m => new EmployeeModel { Name = m.Name, Surname = m.Surname, IDNumber = m.IDNumber.ToString(), ID = m.ID }).ToList();
            return list;
        }

        #endregion

        public string AddUpdateEmployee(EmployeeModel empModel)
        {
            string result = "";
            if (empModel.ID > 0)
            {
                Employee emp = empRepository.SingleOrDefault(x => x.ID == empModel.ID);

                if (emp != null)
                {
                    emp.Name = empModel.Name;
                    emp.Surname = empModel.Surname;
                    empRepository.Update(emp);
                    result = "updated";

                }
            }
            else
            {
                Employee emp = new Employee();

                emp.Name = empModel.Name;
                emp.Surname = empModel.Surname;
                emp.IDNumber = empModel.IDNumber;
                emp.RoleID =  Convert.ToInt32(empModel.SelectedRole);
                emp.DateHired = DateTime.Now; ;
                var record = empRepository.Insert(emp);

                result = "Inserted";
            }

            return result;
        }


    }

}

