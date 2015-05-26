using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Ticket.Models
{
    public class User
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter a name")]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter your address")]
        [Range(0, 500)]
        public string Address { get; set; }

        [Required(ErrorMessage = "Please enter a valid phone number")]
        [RegularExpression(@"^(\+?0?88)?01[0-9]\d{8}$", ErrorMessage = "Please enter a valid mobile number")]
        public string PhoneNumber { get; set; }



    }
}