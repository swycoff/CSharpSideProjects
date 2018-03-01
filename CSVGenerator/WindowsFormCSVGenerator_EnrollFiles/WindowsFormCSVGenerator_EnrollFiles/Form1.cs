using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormCSVGenerator_EnrollFiles {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void label4_Click(object sender, EventArgs e) {

        }

        private void label5_Click(object sender, EventArgs e) {

        }

        private void generateCSVButton_Click(object sender, EventArgs e) {
            StringBuilder csvcontent = new StringBuilder();
            //Builds Header Information Based on File Header Text Feild
            csvcontent.AppendLine(file_header_text.Text);

            //Creates the file based on the file path and file name
            File.AppendAllText(filePathText.Text + fileName_text.Text, csvcontent.ToString());
        }

        private void label10_Click(object sender, EventArgs e) {

        }

        private void label12_Click(object sender, EventArgs e) {

        }

        private void filePathText_TextChanged(object sender, EventArgs e) {

        }
    }
}
