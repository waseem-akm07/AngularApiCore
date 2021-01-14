using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AngularApiCore.Models;
using AngularApiCore.ViewModel;

namespace AngularApiCore.Controllers
{
    [Produces("application/json")]
   
    public class EmployeeController : Controller
    {
        private MasterTabelsContext _context = new MasterTabelsContext();

        // GET: api/Employee
        [HttpGet]
        [Route("api/employee/getemployees")]
        public IEnumerable<EmployeeModel> GetEmployee()
        {
            IEnumerable<EmployeeModel> data = new List<EmployeeModel>();

            data = from d in _context.Employee
                   select new EmployeeModel
                   {
                       EmployeeId = d.EmployeeId,
                       FirstName = d.FirstName,
                       LastName = d.LastName,
                       Email = d.Email
                   };

            return data;
        }

        // GET: api/Employee/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }
        
        // POST: api/Employee
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }
        
        // PUT: api/Employee/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }
        
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
