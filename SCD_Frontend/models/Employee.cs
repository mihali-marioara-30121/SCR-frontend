using System;


namespace SCD_Frontend.models
{
    internal class Employee
    {
        public long id { get; set; }
        public String name { get; set; }
        public String email { get; set; }
        public Employee manager { get; set; }
        public Department department { get; set; }
    }
}
