﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace uniManageSys.Models
{
    [Table("Student")]
    public class Student
    {
        public int Id { get; set; }
        public string fullName { get; set; }
        public string userName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string confirmPassword { get; set; }

    }
}