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
    public class AdminController : ControllerBase
    {
        BenefitsContext db;
        public AdminController(BenefitsContext db1)
        {
            db=db1;
        }

        [HttpGet]
        public IActionResult Getall()

        {

            return Ok(db.admin);            

        }

       /* 
        [HttpPost]
        public IActionResult Register(Admin admin)
        {
           if(db.admin.Where(x=>x.Username==admin.Username).FirstOrDefault()==null)
           {
               db.admin.Add(admin);
               db.SaveChanges();
               return Ok("Registered successfully");
           } 
           else{
           return BadRequest("sername exists");
           }          
            
        } */

        [HttpPost]
        //[Route("Login")]
        public IActionResult Login(Admin admins)
        {
            var v=db.admin.Where(x=>x.Username==admins.Username && x.Password==admins.Password).FirstOrDefault();
            if(v==null)
            return Ok("Incorrect credentials");
            else
            return Ok("Successful");
        }
    }
}