

using System.Text.Json;

namespace SCD_Frontend.models
{
    internal class EmployeeRequest
    {
        public string name { get; set; }
        public string email { get; set; }
        public long managerId { get; set; }
        public long departmentId { get; set; }

        public override string ToString()
        {
            return JsonSerializer.Serialize(this);
        }
    }
}
