
using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;


namespace BethanyShop.Auth
{
    public class ApplicationUser : IdentityUser
    {
        [Display(Name ="Birth Date")]
        public DateTime Birthdate { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
    }
}
