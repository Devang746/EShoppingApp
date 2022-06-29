using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EShoppingApp.Models
{
    public class Userdetails
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public int Mobileno { get; set; }
        public int Created { get; set; }
        public string Email { get; set; }
        public int Usertype { get; set; }

        public string Password { get; set; }
    }
}
