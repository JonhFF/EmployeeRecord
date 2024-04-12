using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeRecordDAL.Entities
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string EmployeeLastName { get; set; }
        public string EmployeeFirstName { get; set; }
        public string EmployeePhone { get; set; }
        public string EmployeePhoneCode { get; set; }
        public int EmployeeZip { get; set; }
        public string HireDate { get; set; }
        public Validate Validate { get; set; }
    }
}
