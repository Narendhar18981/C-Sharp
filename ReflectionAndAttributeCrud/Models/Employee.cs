using System.Text.Json.Serialization;

namespace ReflectionAndAttributeCrud.Models
{
    [Serializable]
    public class Employee
    {
        [MapTo("Id")]
        public int EmployeeId { get; set; }

        [MapTo("Name")]
        [JsonInclude]
        public string FullName { get; set; }

        [JsonIgnore]
        public string Secret { get; set; }
    }



}
