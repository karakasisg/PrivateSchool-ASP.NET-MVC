using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcPrivateSchool.Models
{
    public class Trainer
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "FirstName is required.")]
        [Display(Name = "First Name")]
        [StringLength(60, MinimumLength = 3)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "LastName is required.")]
        [Display(Name = "Last Name")]
        [StringLength(60, MinimumLength = 3)]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Subject is required.")]
        [StringLength(60, MinimumLength = 3)]
        public string Subject { get; set; }
    }
}