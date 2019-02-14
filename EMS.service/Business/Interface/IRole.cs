using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EMS.service.Models;

namespace EMS.service.Business.Interface
{
    public interface IRole
    {
        List<RoleModel> GetAllRoles();
        string AddUpdateRole(RoleModel roleModel);
        RoleModel GetRoleByID(int id);
        void DeleteRole(int id);

    }
}
