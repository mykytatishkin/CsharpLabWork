using Newtonsoft.Json;
using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;
using WindowsFormsDiary.Model;

namespace WindowsFormsDiary
{
    public partial class FrmMain : Form
    {
        BindingList<DiaryItem> Items = new BindingList<DiaryItem>();

        public FrmMain()
        {            
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            /*ДЗ: К существующей форме редактора задач, добавить поле напоминания типа дата и время
             * запускать оповещение в момент наступления события
             */

            lstDiary.DataSource = Items;
            lstDiary.DisplayMember = "FullName";
            lstDiary.ValueMember = "Id";

            if (File.Exists("./file.json")) 
            {
                var json = File.ReadAllText("./file.json");

                if (!string.IsNullOrEmpty(json))
                {
                    foreach (var item in JsonConvert.DeserializeObject<BindingList<DiaryItem>>(json))
                    {
                        Items.Add(item);
                    }
                }
            }
        }

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                var json = JsonConvert.SerializeObject(Items);

                File.WriteAllText("./file.json", json);
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message, "Diary", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (FrmEditor frm = new FrmEditor()) 
            {
                if (frm.ShowDialog(this) == DialogResult.OK) 
                {
                    using (FormTask ft = new FormTask())
                    {
                        Items.Add(new DiaryItem() { Id = Items.Count + 1, Name = frm.DiaryName, Created = DateTime.Now, ToDo = ft.dtCreated });
                    }
                }
            }                
        }


        private void btnEdit_Click(object sender, EventArgs e)
        {
            var item = lstDiary.SelectedItem as DiaryItem;

            using (FrmEditor frm = new FrmEditor())
            {
                frm.DiaryName = item.Name;

                if (frm.ShowDialog(this) == DialogResult.OK)
                {
                    item.Name = frm.DiaryName;
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var item = lstDiary.SelectedItem as DiaryItem;

            if (item != null)
                Items.Remove(item);
        }
    }
}
