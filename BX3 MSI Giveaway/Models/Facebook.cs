using System;
using System.ComponentModel.DataAnnotations;

namespace BX3_MSI_Giveaway.Models
{
    public class Facebook
    {
        public int Id { get; set; }
        [Required]
        public string FullName { get; set; }
        [Required]
        public string Email { get; set; }
        public string FacebookId { get; set; }
        public DateTime BirthDate { get; set; }
        public string FromCountry { get; set; }
    }
}