using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitReportConversionTool {
    public class Properties_Entity {
        private string propName;
        private string propValue;

        public string PropName { get { return propName; } set { propName = value; } }
        public string PropValue { get { return propValue; } set { propValue = value; } }
    }
}
