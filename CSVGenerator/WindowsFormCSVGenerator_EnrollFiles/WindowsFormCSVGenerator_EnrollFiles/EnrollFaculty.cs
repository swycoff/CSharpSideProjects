using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormCSVGenerator_EnrollFiles {
    class EnrollFaculty {
        private string school_id = "";
        private string school_name = "";
        private string sis_id = "";
        private string last_name = "";
        private string first_name = "";
        private string username = "";
        private string password = "";
        private string email = "";

        public string School_Id { get { return school_id; } set { school_id = value; } }
        public string School_Name { get { return school_name; } set { school_name = value; } }
        public string Sis_Id { get { return sis_id; } set { sis_id = value; } }
        public string Last_Name { get { return last_name; } set { last_name = value; } }
        public string First_Name { get { return first_name; } set { first_name = value; } }
        public string Username { get { return username; } set { username = value; } }
        public string Password { get { return password; } set { password = value; } }
        public string Email { get { return email; } set { email = value; } }


    }
}
