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
    public class PolicyController : ControllerBase
    {
        BenefitsContext db;
        public PolicyController(BenefitsContext db1)
        {       
            db=db1;
        }

        [HttpGet]
        public IActionResult Getall()
        {
            var data = (from p in db.policies

            join g in db.groups on p.GroupId equals g.GroupId

            select new{

                policyId = p.PolicyId,

                policyName = p.PolicyName,

                cost = p.Cost,

                startDate = p.StartDate,

                duration = p.Duration,
                groupType = g.GroupName

            });
Console.WriteLine(data);
            return Ok(data);

        }

        [HttpGet("{id}")]
        public IActionResult GetbyId(int id){
          
            return Ok(db.policies.Where(x=>x.PolicyId==id).FirstOrDefault());
        }
[HttpGet("{type}")]
        public IActionResult GetbyType(string type){
              var data = (from p in db.policies

            join g in db.groups on p.GroupId equals g.GroupId where g.GroupName==type
select new{ policyId = p.PolicyId,

                policyName = p.PolicyName,

                cost = p.Cost,

                startDate = p.StartDate,

                duration = p.Duration,
                groupType = g.GroupName}
              );
            return Ok(data);
        }
        [HttpPost]
        public IActionResult AddGroup(Policy policy){
            db.policies.Add(policy);
            db.SaveChanges();

            return Ok("Addition Successful");
        }

        [HttpPut("{id}")]
        public IActionResult update(int id, Policy p){
            //var g = db.products.Where(x=>x.id==id).FirstOrDefault();
            if (id != null){

                db.policies.Update(p);
                db.SaveChanges();
            }else{
                return Unauthorized("Id not given");
            }

            return Ok("Success");
        }

        [HttpDelete]
        public IActionResult DeleteAllData(){
            var rows = from r in db.policies select r;
            foreach (var row in rows){
                db.policies.Remove(row);
            }
            db.SaveChanges();
            return Ok();
        }


        [HttpDelete("{id}")]
        public IActionResult DeletebyId(int id){
            var p = db.policies.Where(x=>x.PolicyId==id).FirstOrDefault();
            db.policies.Remove(p);
            db.SaveChanges();
            return Ok();
        }
      
    }
}