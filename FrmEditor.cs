using System;
using System.Windows.Forms;

namespace WindowsFormsDiary
{
    public partial class FrmEditor : Form
    {
        public string DiaryName { get; set; }

        public FrmEditor()
        {
            InitializeComponent();
        }

        private void FrmEditor_Load(object sender, EventArgs e)
        {
            txtName.Text = this.DiaryName;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.DiaryName = txtName.Text;
            this.DialogResult = DialogResult.OK;
        }
    }
}
