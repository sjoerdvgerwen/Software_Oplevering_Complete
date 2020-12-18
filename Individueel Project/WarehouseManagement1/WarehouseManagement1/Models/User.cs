using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WarehouseManagement1.Models
{
    public class User
    {
        public string Username { get; set; }

        public int UserID { get; set; }

        public string Password { get; set; }

        public void login(string username, string password)
        {
            Username = username;
            Password = password;
        }


    }
}
