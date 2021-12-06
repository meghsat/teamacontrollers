using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace TeamA.Models{
public class Policy

    {

        [Key]
        public int PolicyId { get; set; }
        public string PolicyName { get; set; }
        public int Cost {get; set;}
        public DateTime StartDate{get; set;}
        public int Duration{get; set;}
    
        [ForeignKey("Group")]
        public int? GroupId { get; set; }
        public virtual Groups Group { get; set; }

        [ForeignKey("BenefitsList")]
        public int? BenefitId { get; set; }


    }
}