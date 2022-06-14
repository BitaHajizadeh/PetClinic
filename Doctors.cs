using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetClinic
{
    public partial class Doctors : Form
    {
     
        public Doctors()
        {
            InitializeComponent();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Dashboard Obj = new Dashboard();
            Obj.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Form_shop Obj = new Form_shop();
            Obj.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Doctors Obj = new Doctors();
            Obj.Show();
            this.Hide();
        }

     

        

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Application.Exit();
        }

        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboG_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Doctors_Load(object sender, EventArgs e)
        {
           

           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(cmb_doctor.SelectedItem == null || combo_animal.SelectedItem == null || combo_gender.SelectedItem == null) {
                MessageBox.Show("Please chose item from comboboxs", "Wrong",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("We will call you soon to finall your reservation", "Done",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


    }
}
