﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using EMS.service.Models;
using System.Text;

namespace EMS.service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IEmsService" in both code and config file together.
    [ServiceContract]
    public interface IEmsService
    {
        [OperationContract]
        void DoWork();

        [OperationContract]
        string CreateRate(RateModel model);
        [OperationContract]
        string  CreateEmployee(EmployeeModel model);
        [OperationContract]
        string  CreateRole(RoleModel model);
        [OperationContract]
        List<RateModel> GetAllRates();
        [OperationContract]
        List<EmployeeModel> GetAllEmployees();
        [OperationContract]
        List<RoleModel> GetAllRoles();
        [OperationContract]
        RateModel GetRateByID(int id);
        [OperationContract]
        RoleModel GetRoleByID(int id);
        [OperationContract]
        EmployeeModel GetEmployeeByID(int id);
    }



}

