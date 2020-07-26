using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Address
    {
        [Required]
        public int studentId { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int addressId { get; set; }
        [Required]
        public string streetNumber { get; set; }
        [Required]
        public string street { get; set; }

        public string suburb { get; set; }
        public string city { get; set; }
        public int postCode { get; set; }
        public string country { get; set; }
    }
}
