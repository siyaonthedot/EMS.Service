using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EMS.service.DBContex.Models;
using EMS.service.DBContex;
using GMS.Data.DBContext.Interface;


namespace GMS.Data.DBContext.Models
{
    public class RoleRepository : BaseRepository<Role>
    {
        public RoleRepository(IUnitOfWork unitOfWork) : base(unitOfWork) { }
    }
}
