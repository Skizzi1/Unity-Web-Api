using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using unity_webapi.Interfaces;
using unity_webapi.Models;

namespace unity_webapi.Controllers
{
    public class ValuesController : ApiController
    {

        ICrud<Employee, int> _employee;

        public ValuesController(ICrud<Employee, int> employee)
        {
            this._employee = employee;
        }


        [HttpGet]
        [AcceptVerbs("GET")]
        [Route("emp/Values/ReadEmployee")]
        public List<Employee> ReadEmployee()
        {
            return this._employee.Read();
        }


        [HttpGet]
        [AcceptVerbs("GET")]
        [Route("emp/Values/GetEmployeeById/{id}")]
        public Employee GetEmployeeById(int id)
        {
            return this._employee.GetById(id);
        }


        [HttpPost]
        [AcceptVerbs("POST")]
        [Route("emp/Values/CreateEmployee")]
        public IHttpActionResult CreateEmployee(Employee employee)
        {
            this._employee.Create(employee); 
            return Ok();
        } 


        [HttpPut]
        [AcceptVerbs("PUT")]
        [Route("emp/Values/UpdateEmployee")]
        public void UpdateEmployee(Employee employee)
        {
            this._employee.Update(employee);
           
        }

         
        [HttpDelete]
        [AcceptVerbs("DELETE")]
        [Route("emp/Values/DeleteEmployee/{id}")]
        public void DeleteEmployee(int id) 
        {
            this._employee.Delete(id); 
        }



    }
}
