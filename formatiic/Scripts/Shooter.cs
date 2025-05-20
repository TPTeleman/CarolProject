using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace formatiic.Scripts
{
    internal class Shooter
    {
        private string name, email, cellphone, password;

        public Shooter(string name, string email, string cellphone, string password)
        {
            this.name = name;
            this.email = email;
            this.cellphone = cellphone;
            this.password = password;
        }

        public string Name { get { return name; } }
        public string Email { get { return email; } }
        public string Cellphone { get { return cellphone; } }
        public string Password { get { return password; } }
    }
}
