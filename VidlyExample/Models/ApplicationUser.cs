﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VidlyExample.Models;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;
using System.Security.Claims;
using Microsoft.AspNet.Identity;
using System.Threading.Tasks;

namespace VidlyExample.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        [StringLength(255)]
        public string DrivingLicense { get; set; }

        [Required]
        [StringLength(250)]
        public string Phone { get; set; }

        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }
}