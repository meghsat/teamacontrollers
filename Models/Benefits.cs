using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace TeamA.Models{
public class Benefits

    {
        [Key]
        public int Id {get; set;}
        
        [ForeignKey("Policy")]
        public int PolicyId { get; set; }

        [ForeignKey("Benefits")]
        public string BenefitId { get; set; }
        
    }
}