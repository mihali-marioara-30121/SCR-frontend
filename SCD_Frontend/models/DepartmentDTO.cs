

using System.Text.Json;

namespace SCD_Frontend.models
{
    internal class DepartmentDTO
    {
        public string name { get; set; }
        public string description { get; set; }
        public long parentDepartmentId { get; set; }

        public override string ToString()
        {
            return JsonSerializer.Serialize(this);
        }
    }
}
