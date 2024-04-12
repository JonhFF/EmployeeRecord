using EmployeeRecordDAL;
using EmployeeRecordDAL.Entities;
using System;
using System.Collections.Generic;

namespace EmployeeRecordBLL
{
    public class EmployeeBLL
    {
        // Handle to the Employee DBAccess class
        EmployeeDAL DBEmployeeAccess = new EmployeeDAL();

        // Returns the list of employees
        public List<Employee> GetEmployeeList()
        {
            return DBEmployeeAccess.List();
        }
        
        //Creating or uptading Employee
        public Employee EmployeeOption(Employee employee)
        {
            var validatingEmployee = ValidateObject(employee);
            if (!validatingEmployee.Validate.MethodStatu)
                return validatingEmployee;
            else if (employee.EmployeeId > 0)
                return DBEmployeeAccess.Update(employee);
            else
                return DBEmployeeAccess.Create(employee);
        }

        // Return employee object 
        public Employee GetEmploye(int employeeId)
        {   
            Employee employee = new Employee();

            if (employeeId > 0)
            {
                //Get object 
                employee = DBEmployeeAccess.Read(employeeId);
                //set error if the object is empty 
                if(employee == null)
                {
                    employee.Validate.MethodStatu = false;
                    employee.Validate.MethodMessage = "Object not found";
                }
            }
            else
            {
                //Clean object 
                employee.EmployeeId = 0;
                employee.EmployeeLastName = "";
                employee.EmployeeFirstName = "";
                employee.EmployeePhone = "";
                employee.EmployeePhoneCode = "";
                employee.EmployeeZip = 0;
                employee.HireDate = "";
            }
            return employee;
        }
        
        //Method for validating employee data
        public Employee ValidateObject(Employee employee)
        {
            Validate validate = new Validate();
            validate.MethodStatu = true;

            if (employee.EmployeeLastName == null || employee.EmployeeLastName == "") 
            {
                validate.MethodMessage = "Last name field is requied.";
                validate.MethodStatu = false;
            }
            else if (employee.EmployeeLastName.Length > 150) 
            {
                validate.MethodMessage = "The Maximum length allowed for the Last name field is 150 characters.";
                validate.MethodStatu = false;
            }
            else if (employee.EmployeeFirstName == null || employee.EmployeeFirstName == "")
            {
                validate.MethodMessage = "First name field is requied.";
                validate.MethodStatu = false;
            }
            else if (employee.EmployeeFirstName.Length > 150)
            {
                validate.MethodMessage = "The Maximum length allowed for the first name field is 150 characters.";
                validate.MethodStatu = false;
            }
            else if (employee.EmployeePhone == null || employee.EmployeePhone == "")
            {
                validate.MethodMessage = "Phone field is requied.";
                validate.MethodStatu = false;
            }
            else if (employee.EmployeePhone.Length > 7)
            {
                validate.MethodMessage = "The Maximum length allowed for the phone field is 7 characters.";
                validate.MethodStatu = false;
            }
            else if (employee.EmployeePhoneCode == null || employee.EmployeePhoneCode == "")
            {
                validate.MethodMessage = "Phone code field is requied.";
                validate.MethodStatu = false;
            }
            else if (employee.EmployeePhoneCode.Length > 3)
            {
                validate.MethodMessage = "The Maximum length allowed for the phone code field is 3 characters.";
                validate.MethodStatu = false;
            }
            else if (employee.EmployeeZip == 0)
            {
                validate.MethodMessage = "Zip field is requied.";
                validate.MethodStatu = false;
            }
            else if (employee.HireDate == null || employee.HireDate == "")
            {
                validate.MethodMessage = "Hire date field is requied.";
                validate.MethodStatu = false;
            }
            employee.Validate = validate;
            return employee;
        }

        //Getting custom search by params 
        public CustomSearch CustomSearch(CustomSearch customSearch)
        {
            CustomSearch _customSearch = new CustomSearch();

            _customSearch = ValidateCustomSearch(customSearch);
            if (!_customSearch.Validate.MethodStatu)
                return _customSearch;
            else if (customSearch.Option == "LastName")
                _customSearch.EmployeeList = DBEmployeeAccess.CustomSearchEmployee(customSearch.Value, "", true);
            else
                _customSearch.EmployeeList = DBEmployeeAccess.CustomSearchEmployee("", customSearch.Value, false);
            return _customSearch;
        }

        //Method for validating custom search
        public CustomSearch ValidateCustomSearch(CustomSearch customSearch)
        {
            Validate validate = new Validate();
            validate.MethodStatu = true;

            if (customSearch.Option == null || customSearch.Option == "")
            {
                validate.MethodMessage = "Please, choose an option between Last Name or Phone.";
                validate.MethodStatu = false;
            }
            else if (customSearch.Value == null || customSearch.Value == "")
            {
                validate.MethodMessage = "Search field is requied.";
                validate.MethodStatu = false;
            }

            customSearch.Validate = validate;
            return customSearch;
        }
    }
}
