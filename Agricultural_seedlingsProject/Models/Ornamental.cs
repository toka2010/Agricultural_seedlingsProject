using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Agricultural_seedlingsProject.Models
{
    public class Ornamental
    {
        [Key]
        public int Id { get; set; }
        public string OrnamentalName { get; set; }
        public int Price { get; set; }
        public string Image { get; set; }
        public int Quantity { get; set; }

        [NotMapped]
        public string OrnamentalErrorMsg { get; set; }
    }
}