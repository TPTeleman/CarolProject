using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;

namespace formatiic.Scripts
{
    internal class User
    {
        private static User instance;
        public string ID {  get; set; }
        public bool IsCabo { get; set; }
        public bool IsAdmin { get; set; }

        public static User GetUser()
        {
            if (instance == null)
            {
                instance = new User();
            }

            return instance;
        }

    }
}
