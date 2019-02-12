using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EMS.Model;

namespace EMS.service.Business.Interface
{
    public interface IRole
    {
        List<RoleModel> GetAllRoles();
        string AddUpdateRole(RoleModel roleModel);
    }
}
