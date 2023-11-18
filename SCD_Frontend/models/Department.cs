using System;
using System.Collections.Generic;
using System.Text.Json;

namespace SCD_Frontend.models
{
    internal class Department
    {
        public long id { get; set; }
        public string name { get; set; }

        public string description { get; set; }
        public Department parentDepartment { get; set; }
        public List<Employee> employees { get; set; }

        public override string ToString()
        {
            return JsonSerializer.Serialize(this);
        }
    }
}
