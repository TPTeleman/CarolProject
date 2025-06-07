﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace formatiic.Scripts
{
    internal class Shooter
    {
        private string fullname, warname, contact, bloodtype, email, address, password;
        private string dateofbirth;

        public Shooter(string fullname, string warname, string bloodtype, string email, string contact, string address, string dateofbirth)
        {
            this.fullname = fullname;
            this.warname = warname;
            this.email = email;
            this.bloodtype = bloodtype;
            this.address = address;
            this.dateofbirth = dateofbirth;
            this.contact = contact;
        }

        public string Fullname { get { return fullname; } }
        public string Warname { get { return warname; } }
        public string Bloodtype { get { return bloodtype; } }
        public string Email { get { return email; } }
        public string Contact { get { return contact; } }
        public string Address { get { return address; } }
        public string Dateofbirth { get { return dateofbirth; } }
        public string Password { get { return password; } }
    }
}
