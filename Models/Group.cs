using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TeamA.Models{
public class Groups

    {

        [Key]
        public int GroupId { get; set; }
        public string GroupName { get; set; }

         public virtual ICollection<Policy> Policy { get; set; }
        
    }
}