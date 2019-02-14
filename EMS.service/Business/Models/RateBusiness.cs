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
   public class RateBusiness : IRate
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly RateRepository rateRepository;

        public RateBusiness()
        {
            unitOfWork = new UnitOfWork();
            rateRepository = new RateRepository(unitOfWork);
        }

        public RateBusiness(IUnitOfWork _unitOfWork)
        {

            unitOfWork = _unitOfWork;
            rateRepository = new RateRepository(unitOfWork);
        }

        #region

        public List<RateModel> GetAllRates()
        {
            List<RateModel> list = rateRepository.GetAll().Select(m => new RateModel { Description = m.Description, ID = m.ID }).ToList();
            return list;
        }

        #endregion

        public string AddUpdateRate(RateModel rateModel)
        {
            string result = "";
            if (rateModel.ID > 0)
            {
                Rate rate = rateRepository.SingleOrDefault(x => x.ID == rateModel.ID);

                if (rate != null)
                {
                    rate.Amount = rateModel.Amount;
                    rate.Description = rateModel.Description;
                    rateRepository.Update(rate);
                    result = "updated";

                }
            }
            else
            {
                Rate rate = new Rate();

                rate.Amount = rateModel.Amount;
                rate.Description = rateModel.Description;
                var record = rateRepository.Insert(rate);
                result = "Inserted";
            }

            return result;
        }


    }
}

