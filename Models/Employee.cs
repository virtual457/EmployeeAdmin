﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EmployeeAdmin.Models
{
    public class Employee
    {
        public long ID { get; set; }
        [Required]
        public string Salutation { get; set; }
        [Required]
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,100}$",
         ErrorMessage = "Special Characters are not allowed.")]
        public string FirstName { get; set; }
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,100}$",
         ErrorMessage = "Special Characters are not allowed.")]
        public string MiddleName { get; set; }

        [RegularExpression(@"^[a-zA-Z''-'\s]{0,100}$",
         ErrorMessage = "Special Characters are not allowed.")]
        public string LastName { get; set; }
        [Required]
        public string Gender { get; set; }

        public string MarialStatus { get; set; }

        public DateTime? DateOfBirth { get; set; }
        [Required]
        [Range(0, 200, ErrorMessage = "Enter a valid age")]
        public decimal Age { get; set; }
        public string CareofGuardian { get; set; }
        public string GuardianName { get; set; }
        //[Required(ErrorMessage ="Email address is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string EmailID { get; set; }
        [Required]
        [StringLength(10, MinimumLength = 10, ErrorMessage = "Enter 10 digit PhoneNumber")]
        [RegularExpression(@"^(\d{10})$",
         ErrorMessage = "Enter a valid PhoneNumber")]
        public string CallingNumber { get; set; }
        [Required]
        [StringLength(10, MinimumLength = 10, ErrorMessage = "Enter 10 digit Number")]
        [RegularExpression(@"^(\d{10})$",
         ErrorMessage = "Enter a valid Number")]
        public string WhatsappNumber { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        [StringLength(6, MinimumLength = 6, ErrorMessage = "Enter 6 digit Number")]
        [RegularExpression(@"^(\d{6})$",
         ErrorMessage = "Enter a valid PinCode")]
        public string PinCode { get; set; }
        [StringLength(13, MinimumLength = 10, ErrorMessage = "Enter 12 digit AdharID")]
        [RegularExpression(@"^(\d{12})$",
         ErrorMessage = "Enter a valid adhar number")]

        public string AadhaarID { get; set; }

        [RegularExpression(@"^[a-zA-Z''-'\s]{0,100}$",
         ErrorMessage = "Special Characters are not allowed.")]
        public string Occupation { get; set; }
        public string Status { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime LastModified { get; set; }
    }

  
    public class EmployeeListModel
    {
        public long ID { get; set; }
        public decimal Age { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }

        public string LastName { get; set; }
        public string Address { get; set; }
        public string CallingNumber { get; set; }
        public DateTime RegisteredOn { get; set; }

    }

    public class EmployeeSearchVm
    {
        public string EmployeePhone { get; set; }
        public string EmployeeEmail { get; set; }
    }
}