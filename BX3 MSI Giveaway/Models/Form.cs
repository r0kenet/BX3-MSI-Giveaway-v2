using System;
using System.ComponentModel.DataAnnotations;

namespace BX3_MSI_Giveaway.Models
{
    public class Form
    {
        [Required]
        public string FullName { get; set; }
        [Required]
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public string FromCountry { get; set; }
    }
}