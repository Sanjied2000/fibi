using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Fibi
{
    public partial class Form2 : Form 
    {
        private Form1 parentForm;

        public Form2(Form1 form1)
        {
            InitializeComponent();
            parentForm = form1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = richTextBox1.Text;
            int day = monthCalendar1.SelectionStart.Day;
            int month = monthCalendar1.SelectionStart.Month;
            int year = monthCalendar1.SelectionStart.Year;
            string gender = male.Checked ? "Male" : "Female";

            // Pass the entered data back to Form1
            parentForm.AddEntryToInfoFile(name, day, month, year, gender);

            DialogResult = DialogResult.OK;
            Close();


        }
    }
}
