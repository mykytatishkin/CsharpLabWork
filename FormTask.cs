using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using WindowsFormsDiary.Model;

namespace WindowsFormsDiary
{
    public partial class FormTask : Form
    {
        public DateTime dtCreated { get; set; }
        public FormTask()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        public void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            /*DateTimePicker now = new DateTimePicker();
            now.Value = DateTime.Now;
            
            
            DateTimePicker dt = new DateTimePicker();
            dt.Value = DateTime.Today;

            dtCreated = dateTimePicker1.Value;

            while (now.Value.ToString("yyyy-MM-dd") != theDate)
            {
                now.Value = DateTime.Now;
                if (now.Value.ToString("yyyy-MM-dd") == theDate)
                {

                }
            }*/

        }

        public void SaveDateToDo_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.dtCreated = dateTimePicker1.Value;
        }
    }
}
