using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EMS.service.Models;

namespace EMS.service.Business.Interface
{
    public interface IRate
    {
        List<RateModel> GetAllRates();
        string AddUpdateRate(RateModel empModel);
        RateModel GetRateByID(int id);
        void DeleteRate(int id);
    }
}
