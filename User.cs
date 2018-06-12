using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContactsApp.Models
{
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Name_ID { get; set; }
        public int Phone_ID { get; set; }
        public string Emial_ID { get; set; }
        public int Address_ID { get; set; }
        public int City_ID { get; set; }
        public int County_ID { get; set; }
        public int SocialM_ID { get; set; }
        public bool admin { get; set; }

    }
}
