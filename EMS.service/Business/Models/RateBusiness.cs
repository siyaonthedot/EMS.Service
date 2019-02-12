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
   public class RateBusiness
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly RateRepository rateRepository;

        public RateBusiness(IUnitOfWork _unitOfWork)
        {

            unitOfWork = _unitOfWork;
            rateRepository = new RateRepository(unitOfWork);
        }

        #region

        public List<RateModel> GetAllRates()
        {
            List<RateModel> list = rateRepository.GetAll().Select(m => new RateModel { Description = m.Description }).ToList();
            return list;
        }

        #endregion

        public string AddUpdateEmployee(RateModel rateModel)
        {
            string result = "";
            if (rateModel.ID > 0)
            {
                Rate rate = rateRepository.SingleOrDefault(x => x.ID == rateModel.ID);

                if (rate != null)
                {
                    rate.Description = rateModel.Description;
                    rate.Description = rateModel.Description;

                    //emp.Surname = empModel.Surname;
                    rateRepository.Update(rate);
                    result = "updated";

                }
            }
            else
            {
                Rate rate = new Rate();

                rate.Description = rateModel.Description;
                rate.Description = rateModel.Description;
                // emp.IDNumber = empModel.IDNumber;
                //emp.IsDeleted = false;

                var record = rateRepository.Insert(rate);

                result = "Inserted";
            }

            return result;
        }


    }
}

