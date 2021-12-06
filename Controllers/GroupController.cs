using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TeamA.Models;

namespace TeamA.Controllers{

    [ApiController]
    [Route("[controller]")]
    public class GroupController : ControllerBase
    {
        BenefitsContext db;
        public GroupController(BenefitsContext db1)
        {
            db=db1;
        }

        [HttpGet]
        public IActionResult Getall()

        {

            return Ok(db.groups);            

        }

        [HttpPost]
        public IActionResult AddGroup(Groups group){
            db.groups.Add(group);
            db.SaveChanges();

            return Ok("Addition Successful");
        }

        [HttpDelete("{id}")]
        public IActionResult DeletebyId(int id){
            var g = db.groups.Where(x=>x.GroupId==id).FirstOrDefault();
            db.groups.Remove(g);
            db.SaveChanges();
            return Ok();
        }

      
    }
}