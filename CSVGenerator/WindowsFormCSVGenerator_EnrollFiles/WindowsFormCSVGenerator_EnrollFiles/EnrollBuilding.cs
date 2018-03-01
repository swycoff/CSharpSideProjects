using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormCSVGenerator_EnrollFiles {
    class EnrollBuilding {
        private string size = "";
        private string school_id = "";
        private string school_name = "";

        public string Size { get { return size; } set { size = value; } }
        public string School_Id { get { return school_id; } set { school_id = value; } }
        public string School_Name { get { return school_name; } set { school_name = value; } }
    }
}
