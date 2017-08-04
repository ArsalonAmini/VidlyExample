using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VidlyExample.Models;
using System.ComponentModel.DataAnnotations;

namespace VidlyExample.ViewModels
{
    public class ExternalLoginConfirmationViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Driving License")]
        public string DrivingLicense { get; set; }

        [Required]
        [StringLength(250, ErrorMessage = "The {0} must be at least {2} digits long.", MinimumLength = 8)]
        [Display(Name = "Phone")]
        public string Phone { get; set; }
    }
}