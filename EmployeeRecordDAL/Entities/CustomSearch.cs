using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeRecordDAL.Entities
{
    public class CustomSearch
    {
        public string Option { get; set; }

        public string Value { get; set; }
        public Validate Validate { get; set; }
        public List<Employee> EmployeeList { get; set; }
    }
}
