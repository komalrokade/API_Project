using Core_API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core_API.Models.Sevices;

namespace Core_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private IDBService<Employee, int> empServ;
        /// <summary>
        ///Inject the Idvservice in the constructor , this wiill extract and instace of the
        ///class which impliments idbservice<department, int>
        /// </summary>
        /// <param name="serv"></param>

        public EmployeeController(IDBService<Employee, int> serv)
        {
            empServ = serv;
        }
        [HttpGet]
        public IActionResult Get()
        {
            var response = empServ.Get();
            return Ok(response);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var response = empServ.Get(id);
            return Ok(response);
        }

        [HttpPost]
        public IActionResult Post(Employee data)
        {
            var response = empServ.Create(data);
            return Ok(response);
        }

        [HttpPut]
        public IActionResult Put(int id, Employee data)
        {
            var response = empServ.Update(id, data);
            return Ok(response);
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var response = empServ.Delete(id);
            return Ok(response);
        }

    }
}
