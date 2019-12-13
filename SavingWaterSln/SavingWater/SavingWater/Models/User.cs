using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace SavingWater.Models
{
    public class User
    {
        [PrimaryKey, AutoIncrement]
        public int id{ get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string confirmpassword { get; set; }

    }
}
