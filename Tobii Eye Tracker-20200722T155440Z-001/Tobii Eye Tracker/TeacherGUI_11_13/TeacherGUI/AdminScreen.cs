using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeacherGUI
{
    public partial class AdminScreen : Form
    {
        public AdminScreen()
        {
            InitializeComponent();
            listView1.View = View.Details;

            listView1.CheckBoxes = false;

            listView1.GridLines = true;

            ListViewItem item1 = new ListViewItem("Software Engineering", 0);
            item1.SubItems.Add("Professor Allan");
            item1.SubItems.Add("3:30pm");
            item1.SubItems.Add("3");
            ListViewItem item2 = new ListViewItem("Data Comm", 1);
            item2.SubItems.Add("Professor De");
            item2.SubItems.Add("8 fucking am");
            item2.SubItems.Add("6");
            ListViewItem item3 = new ListViewItem("Pussy hunting", 1);
            item3.SubItems.Add("Zhang");
            item3.SubItems.Add("All day");
            item3.SubItems.Add("9");

            // Create columns for the items and subitems.
            // Width of -2 indicates auto-size.
            listView1.Columns.Add("Class Name", -2, HorizontalAlignment.Left);
            listView1.Columns.Add("Professor Name", -2, HorizontalAlignment.Left);
            listView1.Columns.Add("Time Slot", -2, HorizontalAlignment.Left);
            listView1.Items.AddRange(new ListViewItem[] { item1, item2, item3 });
        }

        private void SubmitProfessor_Click(object sender, EventArgs e)
        {

        }

        private void SubmitClass_Click(object sender, EventArgs e)
        {
            
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void AdminScreen_Load(object sender, EventArgs e)
        {

        }
    }
}
