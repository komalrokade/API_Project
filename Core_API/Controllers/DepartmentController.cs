using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core_API.Models;
using Core_API.Models.Sevices;

namespace Core_API.Controllers
{
   
    /// <summary>
    /// Attributes:
    /// 1. Route: Thiswill be used to register the controller with its action method in RouteTable.
    /// e.g. api/Department, HttpGet with map with Get() method, HttpPost will map with Post() method, HttpPut () method mapped
    /// with put and HttpDelete will map with Delete() method.
    /// Note: Default is always HttpGet.
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        private IDBService<Department, int> deptServ;
        /// <summary>
        ///Inject the Idvservice in the constructor , this wiill extract and instace of the
        ///class which impliments idbservice<department, int>
        /// </summary>
        /// <param name="serv"></param>
        
        public DepartmentController(IDBService<Department,int> serv)
        {
            deptServ = serv;
        }
        [HttpGet]
        public IActionResult Get()
        {
            var response = deptServ.Get();
            return Ok(response);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var response = deptServ.Get(id);
            return Ok(response);
        }

        [HttpPost]
        public IActionResult Post(Department data)
        {
            var response = deptServ.Create(data);
            return Ok(response);
        }

        [HttpPut]
        public IActionResult Put(int id, Department data)
        {
            var response = deptServ.Update(id, data);
            return Ok(response);
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var response = deptServ.Delete(id);
            return Ok(response);
        }
    }
}
