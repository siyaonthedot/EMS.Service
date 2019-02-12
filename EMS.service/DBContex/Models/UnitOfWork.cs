using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Threading.Tasks;
using EMS.service.DBContex;
using GMS.Data.DBContext.Interface;

namespace GMS.Data.DBContext.Models
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly EMSDBEntities _dbContext;

        public UnitOfWork()
        {
            _dbContext = new EMSDBEntities();
        }

        public DbContext Db
        {
            get { return _dbContext; }
        }

        public void Dispose()
        {
        }
    }
}
