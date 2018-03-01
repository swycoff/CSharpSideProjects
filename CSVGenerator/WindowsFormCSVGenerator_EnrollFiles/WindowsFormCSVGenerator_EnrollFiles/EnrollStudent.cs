using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormCSVGenerator_EnrollFiles {
    class EnrollStudent {
        private string school_id = "";
        private string school_name = "";
        private string sis_id = "";
        private string last_name = "";
        private string first_name = "";
        private string middle_name = "";
        private string grade = "";
        private string username = "";
        private string password = "";

        public string School_Id { get { return school_id; } set { school_id = value; } }
        public string School_Name { get { return school_name; } set { school_name = value; } }
        public string Sis_Id { get { return sis_id; } set { sis_id = value; } }
        public string Last_Name { get { return last_name; } set { last_name = value; } }
        public string First_Name { get { return first_name; } set { first_name = value; } }
        public string Middle_Name { get { return middle_name; } set { middle_name = value; } }
        public string Grade { get { return grade; } set { grade = value; } }
        public string Username { get { return username; } set { username = value; } }
        public string Password { get { return password; } set { password = value; } }

    }
}
