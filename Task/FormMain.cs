using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Task.Model;

namespace Task
{
    public partial class FormMain : Form
    {
        BindingList<TaskItem> Items;

        public FormMain()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Items.Add(new TaskItem() { Id = 1, Name = "Test" });
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

            Items = new BindingList<TaskItem>();

            (checkedListTask as ListBox).DataSource = Items;
            (checkedListTask as ListBox).DisplayMember = "Name";
            (checkedListTask as ListBox).ValueMember = "Id";
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
