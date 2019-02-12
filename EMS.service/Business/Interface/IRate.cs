using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EMS.Model;

namespace EMS.service.Business.Interface
{
    public interface IRate
    {
        List<RateModel> GetAllRates();
        string AddUpdateRate(RateModel empModel);
    }
}
