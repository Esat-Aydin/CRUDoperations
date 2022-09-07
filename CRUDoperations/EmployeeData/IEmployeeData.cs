using System.Collections.Generic;

namespace CRUDoperations.EmployeeData
{
    public interface IEmployeeData
    {
        List<Employee> GetEmployees();
    }
}
