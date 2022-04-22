using System;
using System.Collections.Generic;
using System.Text;

namespace Task26.Data.Entities
{
    internal class Users
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int StadiumID { get; set; }
        public string Email { get; set; }
        public Stadiums Stadium {get; set; }
    }
}
