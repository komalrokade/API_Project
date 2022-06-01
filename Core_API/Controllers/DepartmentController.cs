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
   
    
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        private IDBService<Department, int> deptServ;
        
        
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
            //try
            //{
                //Check for the model validations
                //if yes accept
                if(ModelState.IsValid)
                {
                    //throw exception based on condition
                    if (data.Capacity < 0) throw new Exception("Capacity cannot be negative");
                    var response = deptServ.Create(data);
                    return Ok(response);
                }
            else
            {
                //else genrate validation error response
                return BadRequest(ModelState);
            }
            
        }
        //}
        //catch(Exception ex)
        //{
            //catch the exception and return badrequest response
            //return BadRequest(ex.Message);
        //}

        [HttpPut]
        public IActionResult Put(int id, Department data)
        {
            if(ModelState.IsValid)
            {
                var response = deptServ.Update(id, data);
                return Ok(response);
            }
            else
            {
                //ele generate validation error response
                return BadRequest(ModelState);
            }
            
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var response = deptServ.Delete(id);
            return Ok(response);
        }
    }
}
