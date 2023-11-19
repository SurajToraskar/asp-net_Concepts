﻿using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ValidationInMVCInLooselyBinding.Models
{
    public class Employee
    {
        [Required(ErrorMessage ="Please Enter Your First Name")]
        public string FirstName { get; set; }
        [Required(ErrorMessage ="Please Enter Your Last Name")]
        public string LastName { get; set; }
        [Required(ErrorMessage ="Please Enter A Valid Email")]
        [EmailAddress]
        public string Email { get; set; }
        [Required(ErrorMessage ="Please Enter A Valid Age")]
        [Range(18,100)]
        public int Age { get; set; }

    }
}