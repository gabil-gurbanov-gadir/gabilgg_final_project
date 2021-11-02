﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace hmart.ViewModels
{
    public class UserVM
    {
        public string FirstName { get; set; }

        [StringLength(maximumLength: 25)]
        public string LastName { get; set; }

        [StringLength(maximumLength: 25)]
        public string UserName { get; set; }

        [StringLength(maximumLength: 125)]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [StringLength(maximumLength: 25)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [StringLength(maximumLength: 25)]
        [DataType(DataType.Password)]
        [Compare(nameof(Password))]
        public string ConfirmPassword { get; set; }

        [StringLength(maximumLength: 100)]
        public string Image { get; set; }

        public IFormFile ImageFile { get; set; }

        [BindProperty]
        public string Gender { get; set; }
        public string[] Genders = new[] { "Mr.", "Mrs." };

        [StringLength(maximumLength: 25)]
        public DateTime? BirthDay { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string StateOrRegion { get; set; }
        public string ZipOrPostalCode { get; set; }
        public string Country { get; set; }

        public string DataTab { get; set; }
    }
}
