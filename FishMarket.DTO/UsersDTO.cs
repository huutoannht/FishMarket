//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FishMarket.DTO
{
    using System;
    using System.Collections.Generic;
    
    public partial class Users
    {
        public int id { get; set; }
        public string name { get; set; }
        public string username { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string usertype { get; set; }
        public Nullable<byte> block { get; set; }
        public Nullable<byte> sendEmail { get; set; }
        public string registerDate { get; set; }
        public string lastvisitDate { get; set; }
        public string activation { get; set; }
        public string @params { get; set; }
        public string lastResetTime { get; set; }
        public Nullable<int> resetCount { get; set; }
    }
}