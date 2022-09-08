using CRUDoperations.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CRUDoperations.EmployeeData
{
    public class SqlEmployeeData : IEmployeeData
    {
        private EmployeeContext _employeeContext;
        public SqlEmployeeData(EmployeeContext employeeContext)
        {
            _employeeContext = employeeContext;
        }
        public Employee AddEmployee(Employee employee)
        {
            throw new NotImplementedException();
        }

        public void DeleteEmployee(Employee employee)
        {
            throw new NotImplementedException();
        }

        public Employee EditEmployee(Employee employee)
        {
            throw new NotImplementedException();
        }

        public Employee GetEmployee(Guid id)
        {
            return _employeeContext.Employees.SingleOrDefault(x => x.Id == id);
        }

        public List<Employee> GetEmployees()
        {
            return _employeeContext.Employees.ToList();
        }
    }
}
