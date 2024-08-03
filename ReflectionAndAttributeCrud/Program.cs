using ReflectionAndAttributeCrud.Data;
using ReflectionAndAttributeCrud.Helper;
using ReflectionAndAttributeCrud.Models;

class Program
{
    static void Main()
    {
        // Create an employee and map to EmployeeDetails
        Employee employee = new Employee { EmployeeId = 1, FullName = "John Doe", Secret = "secret123" };
        EmployeeDetails details = ObjectMapper.Map<Employee, EmployeeDetails>(employee);

        // Perform CRUD operations
        EmployeeRepository repository = new EmployeeRepository();
        repository.Add(employee);
        Employee fetchedEmployee = repository.Get(1);
        Console.WriteLine($"Fetched Employee: {fetchedEmployee.FullName}");

        // Update the employee
        fetchedEmployee.FullName = "Jane Doe";
        repository.Update(fetchedEmployee);

        // Serialize and deserialize to JSON
        string json = CustomSerializer.SerializeToJson(fetchedEmployee);
        Console.WriteLine($"Serialized to JSON: {json}");
        Employee deserializedEmployee = CustomSerializer.DeserializeFromJson<Employee>(json);
        Console.WriteLine($"Deserialized from JSON: {deserializedEmployee.FullName}");

        // Serialize and deserialize to XML
        string xml = CustomSerializer.SerializeToXml(fetchedEmployee);
        Console.WriteLine($"Serialized to XML: {xml}");
        Employee deserializedEmployeeFromXml = CustomSerializer.DeserializeFromXml<Employee>(xml);
        Console.WriteLine($"Deserialized from XML: {deserializedEmployeeFromXml.FullName}");

        // Delete the employee
        repository.Delete(1);
    }
}
