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
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {   
            if(txt_username.Text == "" || txt_password.Text == "" || txt_confrimpass.Text == "")
            {
                MessageBox.Show("Please Fill all the text boxs!", "Wrong",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(txt_password.Text == txt_confrimpass.Text)
            {
                MessageBox.Show("Your account have successfully created", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                new Dashboard();
            }
            else
            {
                MessageBox.Show("Confrim Pass", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_password.Clear();
                txt_confrimpass.Clear();
            }
        }

        private void SignUp_Load(object sender, EventArgs e)
        {

        }
    }
}
