using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Agricultural_seedlingsProject.Models
{
    public class Offer
    {    [Key]
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string NurseryName { get; set; }
        public int OldPrice { get; set; }
        public int NewPrice { get; set; }
        public string Image { get; set; }
        public int Quantity { get; set; }
        [NotMapped]
        public string volunteerErrorMsg { get; set; }


    }
}