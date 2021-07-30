using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIM_Toko_Bangunan.Class
{
    class ClassLogin
    {
        private String password;
        private String username;
        public ClassLogin() { }
        public ClassLogin(String _us,String _pw)
        {
            this.Password = _pw;
            this.Username = _us;
        }

        public string Password { get => password; set => password = value; }
        public string Username { get => username; set => username = value; }
    }
}
