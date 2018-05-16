using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using unity_webapi.Interfaces;
using unity_webapi.Models;
using unity_webapi.Context;

namespace unity_webapi.Repository
{
    public class EmployeeRepository : ICrud<Employee, int>
    {

        EmployeeContext _employeeContext;
      
        
        public EmployeeRepository(EmployeeContext employeeContext )
        {
            this._employeeContext = employeeContext; 
        }

        public void Create(Employee create)
        { 
            this._employeeContext.Employees.Add(create);
            _employeeContext.SaveChanges();
        }


        public void Delete(int id)
        { 
            Employee employee = this._employeeContext.Employees.Single(x => x.id == id);
            this._employeeContext.Employees.Remove(employee);
            this._employeeContext.SaveChanges();
        }

        public Employee GetById(int id)
        {
            Employee employee = this._employeeContext.Employees.Single(x => x.id == id);
            return employee;
        }

        public List<Employee> Read()
        {
            return _employeeContext.Employees.ToList();
        }

        public void Update(Employee update)
        {
            Employee employee = this._employeeContext.Employees.Single(x => x.id == update.id);
            employee.Name = update.Name;
            employee.Address = update.Address;
            employee.IdNo = update.IdNo;
            employee.Phone = update.Phone;

            this._employeeContext.SaveChanges();
        }


    }
}