using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Agricultural_seedlingsProject.Models
{
    public class User
    {
        [Key]
        public int id { get; set; }
        [Required]
        [StringLength(30, MinimumLength = 3)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(30, MinimumLength = 3)]
        public string LastName { get; set; }
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }
        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required]
        [NotMapped]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        [Display(Name = "Confirm Password ")]
        public string ConfirmPassword { get; set; }
        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "BirthDay")]
        [Range(typeof(DateTime), "1/1/1960", "1/1/2002",
       ErrorMessage = "Your age must be larger than 18 to be able to use this web site")]
        public DateTime BirthDate { get; set; }

        [NotMapped]
        public string LoginErrorMsg { get; set; }
    }
}