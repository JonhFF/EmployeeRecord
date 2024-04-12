using EmployeeRecordDAL.Data;
using EmployeeRecordDAL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeRecordDAL
{
    public class EmployeeDAL
    {
        //Create an instance of DAL
        CnnDB cnn = new CnnDB();

        //Get Employee Object
        public Employee Read(int id)
        {
            //Get Object
            var _employee = cnn.uspGetEmployee(id).FirstOrDefault();

            Employee employee = new Employee();
            employee.EmployeeLastName = _employee.EmployeeLastName;
            employee.EmployeeFirstName = _employee.EmployeeFirstName;
            employee.EmployeePhone = _employee.EmployeePhone;
            employee.EmployeePhoneCode = _employee.EmployeePhoneCode;
            employee.EmployeeId = _employee.EmployeeId;
            employee.EmployeeZip = _employee.EmployeeZip;
            employee.HireDate = _employee.HireDate;

            //Return Object
            return employee;
        }

        //Get list employee
        public List<Employee> List()
        {
            //Get List
            var _employee = cnn.uspGetEmployeeList();

            //Return List
            return _employee.Select(x => new Employee
            {
                EmployeeId = x.EmployeeId,
                EmployeeLastName = x.EmployeeLastName,
                EmployeeZip = x.EmployeeZip,
                EmployeeFirstName = x.EmployeeFirstName,
                EmployeePhone = x.EmployeePhone,
                HireDate = x.HireDate
            }).ToList();
        }

        //Get custom search by params 
        public List<Employee> CustomSearchEmployee(string employeeLastName, string employeePhone, bool option)
        {
            //Get List
            var _employee = cnn.uspGetEmployeeCustomSearch(employeeLastName, employeePhone, option);

            //Return List
            return _employee.Select(x => new Employee
            {
                EmployeeId = x.EmployeeId,
                EmployeeLastName = x.EmployeeLastName,
                EmployeeZip = x.EmployeeZip,
                EmployeeFirstName = x.EmployeeFirstName,
                EmployeePhone = x.EmployeePhone,
                HireDate = x.HireDate
            }).ToList();
        }

        //Create object employee
        public Employee Create(Employee employee)
        {
            //Handling statu of request 
            Validate validate = new Validate();
            try
            {
                //Creating object 
                var result = cnn.uspCreateEmployee(
                employee.EmployeeLastName,
                employee.EmployeeFirstName,
                employee.EmployeePhone,
                employee.EmployeePhoneCode,
                employee.EmployeeZip,
                employee.HireDate).FirstOrDefault();

                //Asign data validation
                validate.MethodMessage = result.MethodMessage;
                validate.MethodStatu = (bool)result.MethodStatu;
                employee.Validate = validate;
            }
            catch (Exception ex)
            {
                //Catching error
                validate.MethodMessage = ex.Message;
                validate.MethodStatu = false;
                employee.Validate = validate;
            }

            //Return object
            return employee;
        }

        //Update object employee
        public Employee Update(Employee employee)
        {
            Validate validate = new Validate();
            try
            {
                //Updating object 
                var result = cnn.uspUpdateEmployee(
                                employee.EmployeeId,
                                employee.EmployeeLastName,
                                employee.EmployeeFirstName,
                                employee.EmployeePhone,
                                employee.EmployeePhoneCode,
                                employee.EmployeeZip,
                                employee.HireDate).FirstOrDefault();

                //Asign data validation
                validate.MethodMessage = result.MethodMessage;
                validate.MethodStatu = (bool)result.MethodStatu;
                employee.Validate = validate;
            }
            catch (Exception ex)
            {
                //Catching error
                validate.MethodMessage = ex.Message;
                validate.MethodStatu = false;
                employee.Validate = validate;
            }

            //Return object
            return employee;
        }
    }
}
