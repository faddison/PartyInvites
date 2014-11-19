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
    public class GuestResponse
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public bool? WillAttend { get; set; }
    }
}