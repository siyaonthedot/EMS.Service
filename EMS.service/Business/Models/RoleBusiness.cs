using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EMS.Model;
using GMS.Data.DBContext.Models;
using EMS.service.DBContex;
using EMS.service.Business.Interface;
using GMS.Data.DBContext.Interface;

namespace EMS.service.Business.Models
{
    public class RoleBusiness : IRole
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly RoleRepository roleRepository;

        public RoleBusiness(IUnitOfWork _unitOfWork)
        {

            unitOfWork = _unitOfWork;
            roleRepository = new RoleRepository(unitOfWork);
        }

        #region

        public List<RoleModel> GetAllRoles()
        {
            List<RoleModel> list = roleRepository.GetAll().Select(m => new RoleModel { Description = m.Description }).ToList();
            return list;
        }

        #endregion

        public string AddUpdateRole(RoleModel roleModel)
        {
            string result = "";
            if (roleModel.ID > 0)
            {
                Role role = roleRepository.SingleOrDefault(x => x.ID == roleModel.ID);

                if (role != null)
                {
                    role.Description = roleModel.Description;
                    role.Description = roleModel.Description;

                    //emp.Surname = empModel.Surname;
                    roleRepository.Update(role);
                    result = "updated";

                }
            }
            else
            {
                Role role = new Role();

                role.Description = roleModel.Description;
                role.Description = roleModel.Description;
                // emp.IDNumber = empModel.IDNumber;
                //emp.IsDeleted = false;

                var record = roleRepository.Insert(role);

                result = "Inserted";
            }

            return result;
        }


    }
}

