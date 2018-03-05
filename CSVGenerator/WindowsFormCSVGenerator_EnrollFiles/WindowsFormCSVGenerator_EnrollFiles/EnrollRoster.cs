using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormCSVGenerator_EnrollFiles {
    class EnrollRoster {
        private string student_SISID = "";
        private string faculty_SISID = "";

        public string Student_SISID { get { return student_SISID; } set { student_SISID = value; } }
        public string Faculty_SISID { get { return faculty_SISID; } set { faculty_SISID = value; } }

    }
}
