using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_Practice.Models
{
    public class StudentModel
    {
        [Key]
        public int Id { get; set; }

        //[Required(ErrorMessage ="name required")]
        public string name { get; set; }
        
        //[Required(ErrorMessage ="email required")]
        public string email { get; set; }
        
        //[Required(ErrorMessage ="password required")]
        public string password { get; set; }

    }
}