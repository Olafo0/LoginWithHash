using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginWithHash
{
    public class Account
    {
        public string UserName { get; set; }
        public string HashedPassword { get; set; }

        public Account(string userName, string hashedPassword)
        {
            this.UserName = userName;
            this.HashedPassword = hashedPassword; 
        }
    }
}
