using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Agricultural_seedlingsProject.Models
{
    public class Sales
    {
        [Key]
        public int Id { get; set; }
        public int User_Id { get; set; }
        public string nursaryName { get; set; }
        public string ProductName { get; set; }

        [DataType(DataType.Date)]
        [Required]
        public DateTime Reservation_Date { get; set; }
        public int Price { get; set; }
        [NotMapped]
        public string ReservationrMsg { get; set; }
    }
}