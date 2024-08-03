using ReflectionAndAttributeCrud.Models;

namespace ReflectionAndAttributeCrud.Data
{
    public class EmployeeRepository
    {
        private List<Employee> _employees = new List<Employee>();

        public void Add(Employee employee)
        {
            _employees.Add(employee);
        }

        public Employee Get(int id)
        {
            return _employees.FirstOrDefault(e => e.EmployeeId == id);
        }

        public void Update(Employee employee)
        {
            var existingEmployee = Get(employee.EmployeeId);
            if (existingEmployee != null)
            {
                existingEmployee.FullName = employee.FullName;
                existingEmployee.Secret = employee.Secret;
            }
        }

        public void Delete(int id)
        {
            var employee = Get(id);
            if (employee != null)
            {
                _employees.Remove(employee);
            }
        }
    }

}
