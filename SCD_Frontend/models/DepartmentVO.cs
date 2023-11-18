using System;
using System.Collections.Generic;

namespace SCD_Frontend.models
{
    internal class DepartmentVO
    {
        public long id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public List<Department> childDepartments { get; set; }
    }
}
