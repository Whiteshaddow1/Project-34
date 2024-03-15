using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Project_34
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //test github upload

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists($"{Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory)}/data.dat"))
                database.ReadXml($"{Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory)}/data.dat");
            //This will put the file on the desktop regardless of several factors

        }

        private void dataTable1DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }


        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                dataTable1BindingSource.Filter = $"ClientName like '*{txtSearch.Text}*' ";

        }

        private void dataTable1BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            dataTable1BindingSource.EndEdit();
            database.WriteXml($"{Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory)}/data.dat");
            MessageBox.Show("data.dat was saved at: " + Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory),  "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void label1_Click(object sender, EventArgs e)
        {
        }


        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Yup, This works!";
 
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void solFusionLabel_Click(object sender, EventArgs e)
        {

        }

        private void solFusionTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void sPDETextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void sPDELabel_Click(object sender, EventArgs e)
        {

        }

        private void sQLLabel_Click(object sender, EventArgs e)
        {

        }

        private void sQLTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void fileShareTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void fileShareLabel_Click(object sender, EventArgs e)
        {

        }

        private void clientNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_DisplayMemberChanged(object sender, EventArgs e)
        {
 
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            textBox1.Text = comboBox1.Text;
        }

        private void comboBox2_MouseDown(object sender, MouseEventArgs e)
        {
            textBox1.Text = "debug.MouseDown";
            // comboBox2.SelectedValue = 3;
           // richTextBox1.Visible = true;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_MouseHover(object sender, EventArgs e)
        {
            richTextBox1.Visible = true;
        }

        private void comboBox2_MouseLeave(object sender, EventArgs e)
        {
            richTextBox1.Visible = false;
        }
    }
}
