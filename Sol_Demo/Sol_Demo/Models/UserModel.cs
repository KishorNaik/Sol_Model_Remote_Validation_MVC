using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Sol_Demo.Models
{
    public class UserModel
    {
        // https://docs.microsoft.com/en-us/aspnet/core/mvc/models/validation?view=aspnetcore-3.1
        // Pre Defined Data Annotations
        [Required]
        [MaxLength(50, ErrorMessage = "First Name should be less than 50 character")]
        [DisplayName("First Name")]
        public String FirstName { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage = "First Name should be less than 50 character")]
        [DisplayName("First Name")]
        public String LastName { get; set; }

        [Required]
        [EmailAddress]
        [Remote("IsEmailExistRemoteValidation", "Users", ErrorMessage = "The given email id is already existed")]
        [DisplayName("Email Id")]
        public String EmailId { get; set; }
    }
}