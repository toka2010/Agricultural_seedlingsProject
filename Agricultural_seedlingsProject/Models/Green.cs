using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Agricultural_seedlingsProject.Models
{
    public class Green
    {
        [Key]
        public int Id { get; set; }
        public string GreenName { get; set; }
        public int Price { get; set; }
        public string Image { get; set; }
        public int Quantity { get; set; }

        [NotMapped]
        public string GreenErrorMsg { get; set; }
    }
}