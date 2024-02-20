//using SampleCurdOperations.CustomValidation;
using System.ComponentModel.DataAnnotations;

namespace SampleCurdOperations.Models
{
    public class MUser
    {
        
        public int? Id { get; set; }

        [Required]
        public string? FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string Email { get; set; }


        [Required]
        public string MobileNumber { get; set; }

        
        [Required]
        public String Address { get; set; }

        [Required]
        public DateTime? DOB { get; set; }
    }
}
