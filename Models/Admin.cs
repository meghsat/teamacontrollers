using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TeamA.Models
{

 public  class Admin
    {
        [Key]
        public string Username { get; set; }
        public string Password { get; set; }
        //public string Email { get; set; }
    }
}
