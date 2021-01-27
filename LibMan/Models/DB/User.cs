using System;
using System.Collections.Generic;

namespace LibMan.Models.DB
{
    public partial class User
    {
        public int Userid { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Birthdate { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Username { get; set; }
        public byte[] Photo { get; set; }
    }
}
