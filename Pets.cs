using System.Data.SqlClient;
using System.Data;
namespace PetClinic
{
    public partial class Form_shop : Form
    {

        int price_royal = 500;
        int price_rachael = 600;
        int total_price = 0;

        public string result_price;
        int price = 0;
        


        public Form_shop()
        {
            InitializeComponent();

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Application.Exit();
        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           


        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
      
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Doctors Obj = new Doctors();
            Obj.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Dashboard Obj = new Dashboard();
            Obj.Show();
            this.Hide();
        }





        private void button1_Click(object sender, EventArgs e)
        {
            if(txt_name.Text == "" || txt_lastname.Text == "" || txt_add.Text == "" || txt_phone.Text == "")
            {
                MessageBox.Show("Please fill all the text boxess", "Wrong!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            txt_price.Clear();
            txt_price.ForeColor = Color.Red;
            txt_price.Text =
                "Total price:  " + price.ToString() + "$";
                          
            price_btn.Visible = false;
            order_btn.Visible = true;

        }





        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox2.SelectedItem == comboBox2.Items[1] || comboBox2.SelectedItem == comboBox2.Items[2])
            {
                total_price = 0;
                total_price = price_royal;
            }
            else
            {
                total_price = 0;
                total_price = price_rachael;
            }
        }


        private void numeric_ValueChanged(object sender, EventArgs e)
        {
            int num_food = Convert.ToInt32(numeric.Value);
            price = 0;
            price = total_price * num_food;
        }

        private void txt_price_Click(object sender, EventArgs e)
        {
            
        }

        private void order_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thanks for your order, we will sent your order in 8 hours", "Done",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            txt_name.Clear();
            txt_lastname.Clear();
            txt_add.Clear();
            txt_phone.Clear();
            
        }
    }
    
}