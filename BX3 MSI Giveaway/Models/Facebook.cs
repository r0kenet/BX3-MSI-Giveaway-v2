using System;
using System.ComponentModel.DataAnnotations;

namespace BX3_MSI_Giveaway.Models
{
    public class Facebook
    {
        [Required]
        public string FullName { get; set; }
        [Required]
        public string Email { get; set; }
        public string FacebookId { get; set; }
        public DateTime BirthDate { get; set; }
        public string FromCountry { get; set; }
    }
}