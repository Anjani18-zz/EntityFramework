using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeEntity.Data;
using EmployeeEntity.Model;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeEntity.Controllers
{
    [Route("api/Employee")]
    public class EmployeeController : Controller
    {
        // GET api/values
        [HttpGet]
        public ActionResult Get()
        {
            using (var _context = new EmployeeContext())
            {
                var listofEmployees = new List<Employee>();
                listofEmployees = _context.tblEmployee.ToList();
                return Ok(listofEmployees);
            }
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        [HttpPost]
        public ActionResult Post([FromBody]Employee EmployeeObject)
        {
            using (var _Context = new EmployeeContext())
            {
                _Context.tblEmployee.Add(EmployeeObject);
                _Context.SaveChanges();
            }
            return Ok("EmployeeAdded");
        }

        [HttpPut]
        public ActionResult Put([FromBody]Employee EmployeeObject)
        {
            using (var _Context = new EmployeeContext())
            {
                _Context.tblEmployee.Update(EmployeeObject);
                _Context.SaveChanges();
            }
            return Ok("employee data has been updated");
        }

        [HttpDelete]
        public ActionResult Delete([FromBody]Employee EmployeeObject)
        {
            using (var _Context = new EmployeeContext())
            {
                _Context.tblEmployee.Remove(EmployeeObject);
                _Context.SaveChanges();
            }
            return Ok("employee data Deleted");
        }

    }
}
