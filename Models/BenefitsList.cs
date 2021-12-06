using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace TeamA.Models{
public class BenefitsList

    {

        [Key]
        public int BenefitId { get; set; }
        public string Benefit { get; set; }
        public string PolicyName{get;set;}
    }
}