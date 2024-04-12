﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EmployeeRecordDAL.Data
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class CnnDB : DbContext
    {
        public CnnDB()
            : base("name=CnnDB")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
    
        public virtual ObjectResult<uspCreateEmployee_Result> uspCreateEmployee(string employeeLastName, string employeeFirstName, string employeePhone, string employeePhoneCode, Nullable<int> employeeZip, string hireDate)
        {
            var employeeLastNameParameter = employeeLastName != null ?
                new ObjectParameter("EmployeeLastName", employeeLastName) :
                new ObjectParameter("EmployeeLastName", typeof(string));
    
            var employeeFirstNameParameter = employeeFirstName != null ?
                new ObjectParameter("EmployeeFirstName", employeeFirstName) :
                new ObjectParameter("EmployeeFirstName", typeof(string));
    
            var employeePhoneParameter = employeePhone != null ?
                new ObjectParameter("EmployeePhone", employeePhone) :
                new ObjectParameter("EmployeePhone", typeof(string));
    
            var employeePhoneCodeParameter = employeePhoneCode != null ?
                new ObjectParameter("EmployeePhoneCode", employeePhoneCode) :
                new ObjectParameter("EmployeePhoneCode", typeof(string));
    
            var employeeZipParameter = employeeZip.HasValue ?
                new ObjectParameter("EmployeeZip", employeeZip) :
                new ObjectParameter("EmployeeZip", typeof(int));
    
            var hireDateParameter = hireDate != null ?
                new ObjectParameter("HireDate", hireDate) :
                new ObjectParameter("HireDate", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<uspCreateEmployee_Result>("uspCreateEmployee", employeeLastNameParameter, employeeFirstNameParameter, employeePhoneParameter, employeePhoneCodeParameter, employeeZipParameter, hireDateParameter);
        }
    
        public virtual ObjectResult<uspGetEmployee_Result> uspGetEmployee(Nullable<int> employeeId)
        {
            var employeeIdParameter = employeeId.HasValue ?
                new ObjectParameter("EmployeeId", employeeId) :
                new ObjectParameter("EmployeeId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<uspGetEmployee_Result>("uspGetEmployee", employeeIdParameter);
        }
    
        public virtual ObjectResult<uspGetEmployeeCustomSearch_Result> uspGetEmployeeCustomSearch(string employeeLastName, string employeePhone, Nullable<bool> option)
        {
            var employeeLastNameParameter = employeeLastName != null ?
                new ObjectParameter("EmployeeLastName", employeeLastName) :
                new ObjectParameter("EmployeeLastName", typeof(string));
    
            var employeePhoneParameter = employeePhone != null ?
                new ObjectParameter("EmployeePhone", employeePhone) :
                new ObjectParameter("EmployeePhone", typeof(string));
    
            var optionParameter = option.HasValue ?
                new ObjectParameter("Option", option) :
                new ObjectParameter("Option", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<uspGetEmployeeCustomSearch_Result>("uspGetEmployeeCustomSearch", employeeLastNameParameter, employeePhoneParameter, optionParameter);
        }
    
        public virtual ObjectResult<uspGetEmployeeList_Result> uspGetEmployeeList()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<uspGetEmployeeList_Result>("uspGetEmployeeList");
        }
    
        public virtual ObjectResult<uspUpdateEmployee_Result> uspUpdateEmployee(Nullable<int> employeeId, string employeeLastName, string employeeFirstName, string employeePhone, string employeePhoneCode, Nullable<int> employeeZip, string hireDate)
        {
            var employeeIdParameter = employeeId.HasValue ?
                new ObjectParameter("EmployeeId", employeeId) :
                new ObjectParameter("EmployeeId", typeof(int));
    
            var employeeLastNameParameter = employeeLastName != null ?
                new ObjectParameter("EmployeeLastName", employeeLastName) :
                new ObjectParameter("EmployeeLastName", typeof(string));
    
            var employeeFirstNameParameter = employeeFirstName != null ?
                new ObjectParameter("EmployeeFirstName", employeeFirstName) :
                new ObjectParameter("EmployeeFirstName", typeof(string));
    
            var employeePhoneParameter = employeePhone != null ?
                new ObjectParameter("EmployeePhone", employeePhone) :
                new ObjectParameter("EmployeePhone", typeof(string));
    
            var employeePhoneCodeParameter = employeePhoneCode != null ?
                new ObjectParameter("EmployeePhoneCode", employeePhoneCode) :
                new ObjectParameter("EmployeePhoneCode", typeof(string));
    
            var employeeZipParameter = employeeZip.HasValue ?
                new ObjectParameter("EmployeeZip", employeeZip) :
                new ObjectParameter("EmployeeZip", typeof(int));
    
            var hireDateParameter = hireDate != null ?
                new ObjectParameter("HireDate", hireDate) :
                new ObjectParameter("HireDate", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<uspUpdateEmployee_Result>("uspUpdateEmployee", employeeIdParameter, employeeLastNameParameter, employeeFirstNameParameter, employeePhoneParameter, employeePhoneCodeParameter, employeeZipParameter, hireDateParameter);
        }
    }
}