using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Agricultural_seedlingsProject.Models
{
    public class Volunter
    {
        [Key]
        public int Id { get; set; }
      
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }
        public string nursaryName { get; set; }
        [Required]
        public string ProductName { get; set; }
        [Required]
        public string Adress{ get; set; }
        [NotMapped]
        public string volunteerErrorMsg { get; set; }

    }
}