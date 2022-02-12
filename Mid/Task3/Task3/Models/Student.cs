using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Task3.Models
{
    public class Student
    {
         [Required]
         [StringLength(50, ErrorMessage ="Name length must not exceed 50")]
        public  string Name { get; set; }

        [Required]
        [Range(0,100)]
        public string Id { get; set; }

        [Required]
        public string Dob { get; set; }

        [Required]
        public string Email { get; set; }
    }
}