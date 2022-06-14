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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            
               

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = "User";
            string password = "1234";
            if(txt_username.Text == username & txt_password.Text == password)
            {
                this.Hide();
                new Dashboard().ShowDialog();
            }
            else
            {
                MessageBox.Show("Wrong user name or password please try again.", "Wrong!"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_password.Clear();
                txt_username.Clear();
            }
            

        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SignUp Obj = new SignUp();
            Obj.Show();
            this.Hide();
        }
    }
}
