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
    public class BenefitsListController : ControllerBase
    {
        BenefitsContext db;
        public BenefitsListController(BenefitsContext db1)
        {
            db=db1;
        }

        [HttpGet]
        public IActionResult Getall()

        {
            return Ok(db.benefitsList);            
        }

        [HttpPost]
        public IActionResult AddBenefit(BenefitsList benefit){
            db.benefitsList.Add(benefit);
            db.SaveChanges();
            return Ok("Addition Successful");
        }

        [HttpDelete("{id}")]
        public IActionResult DeletebyId(int id){
            var b = db.benefitsList.Where(x=>x.BenefitId==id).FirstOrDefault();
            db.benefitsList.Remove(b);
            db.SaveChanges();
            return Ok();
        }

      
    }
}