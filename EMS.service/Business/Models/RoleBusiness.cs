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
    public class RoleBusiness : IRole
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly RoleRepository roleRepository;

        public RoleBusiness()
        {
            unitOfWork = new UnitOfWork();
            roleRepository = new RoleRepository(unitOfWork);
        }
        public RoleBusiness(IUnitOfWork _unitOfWork)
        {

            unitOfWork = _unitOfWork;
            roleRepository = new RoleRepository(unitOfWork);
        }

        #region

        public List<RoleModel> GetAllRoles()
        {
            List<RoleModel> list = roleRepository.GetAll().Select(m => new RoleModel { Description = m.Description , ID = m.ID}).ToList();
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
                    role.ID = roleModel.ID;
                    role.RateID = roleModel.RateID;
                    roleRepository.Update(role);
                    result = "updated";

                }
            }
            else
            {
                Role role = new Role();

                role.Description = roleModel.Description;
                role.ID = roleModel.ID;
                role.RateID = roleModel.RateID;
                var record = roleRepository.Insert(role);

                result = "Inserted";
            }

            return result;
        }


    }
}

