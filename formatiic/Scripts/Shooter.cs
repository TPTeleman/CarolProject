using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace formatiic.Scripts
{
    internal class Shooter
    {
        private string fullname, warname, contact, bloodtype, email, address;
        private DateTime dateofbirth;
        private Image photo;

        public Shooter(string fullname, string warname, string bloodtype, string email, string contact, string address, DateTime dateofbirth, Image photo)
        {
            this.fullname = fullname;
            this.warname = warname;
            this.email = email;
            this.bloodtype = bloodtype;
            this.address = address;
            this.dateofbirth = dateofbirth;
            this.contact = contact;
            this.photo = photo;
        }

        public string Fullname { get { return fullname; } }
        public string Warname { get { return warname; } }
        public string Bloodtype { get { return bloodtype; } }
        public string Email { get { return email; } }
        public string Contact { get { return contact; } }
        public string Address { get { return address; } }
        public DateTime Dateofbirth { get { return dateofbirth; } }
        public Image Photo { get { return photo; } }
    }
}
