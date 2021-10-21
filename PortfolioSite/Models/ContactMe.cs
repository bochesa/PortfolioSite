using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PortfolioSite.Models
{
    public class ContactMe
    {
        [Required]
        [StringLength(20, MinimumLength = 5,ErrorMessage ="Name has to be between 5-20 characters")]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Subject { get; set; }

        [Required]
        public string Message { get; set; }

        [TempData]
        public string Feedback { get; set; }
    }
}
