// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="GuestResponse.cs" company="Homewood Human Solutions">
// // This file is subject to the terms and conditions defined in file 'LICENSE.txt', 
// // which is part of this source code package.
// // </copyright>
// // <author>Fraser Addison</author>
// // <created>19-11-2014</created>
// //
// // <summary>
// // The GuestResponse.cs
// // </summary>
// // --------------------------------------------------------------------------------------------------------------------
namespace PartyInvites.Models
{
    using System.ComponentModel.DataAnnotations;

    public class GuestResponse
    {
        [Required(ErrorMessage = "Please enter your name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter your email address")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Please enter a valid email address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter your phone number")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Please specify whether you'll be attending")]
        public bool? WillAttend { get; set; }
    }
}