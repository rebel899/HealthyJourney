using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthyJourney.Domain.Entities
{
    public class User
    {
        public int Id { get; set; }

        [Display(Name = "username")]
        [Required(ErrorMessage = "this field is required")]
        public string UserName { get; set; }

        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "this field is required")]
        public string Email { get; set; }

        [DataType(DataType.Password)]
        [MinLength(8)]
        [Required(ErrorMessage = "this field is required")]
        public string Password { get; set; }

        [Compare("Password")]
        [DataType(DataType.Password)]
        [MinLength(8)]
        [Required(ErrorMessage = "the 2 passwords must be equal")]
        [NotMapped]
        public string ConfirmPAssword { get; set; }

        public bool IsApproved { get; set; }
        public string Thumbnail { get; set; }
    }
}
