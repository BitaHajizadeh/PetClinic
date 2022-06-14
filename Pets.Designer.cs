namespace PetClinic
{
    partial class Form_shop
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_shop));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.order_btn = new System.Windows.Forms.Button();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.numeric = new System.Windows.Forms.NumericUpDown();
            this.number_shop = new System.Windows.Forms.Label();
            this.txt_lastname = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.price_btn = new System.Windows.Forms.Button();
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_add = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 82);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.order_btn);
            this.panel2.Controls.Add(this.txt_price);
            this.panel2.Controls.Add(this.numeric);
            this.panel2.Controls.Add(this.number_shop);
            this.panel2.Controls.Add(this.txt_lastname);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txt_name);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.comboBox2);
            this.panel2.Controls.Add(this.DeleteButton);
            this.panel2.Controls.Add(this.price_btn);
            this.panel2.Controls.Add(this.txt_phone);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.txt_add);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1370, 654);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // order_btn
            // 
            this.order_btn.BackColor = System.Drawing.Color.Green;
            this.order_btn.Font = new System.Drawing.Font("Azita", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.order_btn.ForeColor = System.Drawing.Color.Black;
            this.order_btn.Location = new System.Drawing.Point(862, 490);
            this.order_btn.Name = "order_btn";
            this.order_btn.Size = new System.Drawing.Size(176, 39);
            this.order_btn.TabIndex = 33;
            this.order_btn.Text = "Order";
            this.order_btn.UseVisualStyleBackColor = false;
            this.order_btn.Visible = false;
            this.order_btn.Click += new System.EventHandler(this.order_btn_Click);
            // 
            // txt_price
            // 
            this.txt_price.Location = new System.Drawing.Point(71, 445);
            this.txt_price.Multiline = true;
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(363, 137);
            this.txt_price.TabIndex = 32;
            this.txt_price.Text = "Press Price button to final your order";
            // 
            // numeric
            // 
            this.numeric.Location = new System.Drawing.Point(364, 297);
            this.numeric.Name = "numeric";
            this.numeric.Size = new System.Drawing.Size(44, 33);
            this.numeric.TabIndex = 31;
            this.numeric.ValueChanged += new System.EventHandler(this.numeric_ValueChanged);
            // 
            // number_shop
            // 
            this.number_shop.AutoSize = true;
            this.number_shop.Font = new System.Drawing.Font("Azita", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.number_shop.Location = new System.Drawing.Point(71, 299);
            this.number_shop.Name = "number_shop";
            this.number_shop.Size = new System.Drawing.Size(283, 33);
            this.number_shop.TabIndex = 30;
            this.number_shop.Text = "Select the amount of food you want";
            // 
            // txt_lastname
            // 
            this.txt_lastname.Location = new System.Drawing.Point(337, 230);
            this.txt_lastname.Name = "txt_lastname";
            this.txt_lastname.Size = new System.Drawing.Size(165, 33);
            this.txt_lastname.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Azita", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(339, 194);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 33);
            this.label7.TabIndex = 28;
            this.label7.Text = "Last Name";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(99, 227);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(165, 33);
            this.txt_name.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Azita", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(99, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 33);
            this.label4.TabIndex = 26;
            this.label4.Text = "Name";
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Azita", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Royal",
            "Purnia",
            "Sheba",
            "Rachael"});
            this.comboBox2.Location = new System.Drawing.Point(591, 224);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(186, 41);
            this.comboBox2.TabIndex = 25;
            this.comboBox2.Text = "Brand";
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.Color.Red;
            this.DeleteButton.Font = new System.Drawing.Font("Azita", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DeleteButton.ForeColor = System.Drawing.Color.Black;
            this.DeleteButton.Location = new System.Drawing.Point(1111, 490);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(176, 39);
            this.DeleteButton.TabIndex = 23;
            this.DeleteButton.Text = "Clear";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // price_btn
            // 
            this.price_btn.BackColor = System.Drawing.Color.Yellow;
            this.price_btn.Font = new System.Drawing.Font("Azita", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.price_btn.ForeColor = System.Drawing.Color.Black;
            this.price_btn.Location = new System.Drawing.Point(1111, 423);
            this.price_btn.Name = "price_btn";
            this.price_btn.Size = new System.Drawing.Size(176, 39);
            this.price_btn.TabIndex = 21;
            this.price_btn.Text = "Show Price";
            this.price_btn.UseVisualStyleBackColor = false;
            this.price_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_phone
            // 
            this.txt_phone.Location = new System.Drawing.Point(860, 227);
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(165, 33);
            this.txt_phone.TabIndex = 18;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Azita", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(862, 191);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(129, 33);
            this.label13.TabIndex = 17;
            this.label13.Text = "Phone Number";
            // 
            // txt_add
            // 
            this.txt_add.Location = new System.Drawing.Point(1104, 219);
            this.txt_add.Multiline = true;
            this.txt_add.Name = "txt_add";
            this.txt_add.Size = new System.Drawing.Size(183, 70);
            this.txt_add.TabIndex = 16;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Azita", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(1104, 183);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 33);
            this.label12.TabIndex = 15;
            this.label12.Text = "Address";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Azita", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.DarkBlue;
            this.label9.Location = new System.Drawing.Point(637, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 42);
            this.label9.TabIndex = 9;
            this.label9.Text = "Shop";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Azita", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.DarkBlue;
            this.label8.Location = new System.Drawing.Point(125, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(181, 37);
            this.label8.TabIndex = 8;
            this.label8.Text = "Pet Clinic and Shop";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 87);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(534, 660);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(47, 43);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Azita", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Cornsilk;
            this.label1.Location = new System.Drawing.Point(507, 693);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 37);
            this.label1.TabIndex = 5;
            this.label1.Text = "Dashboard";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Azita", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Cornsilk;
            this.label2.Location = new System.Drawing.Point(661, 706);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 33);
            this.label2.TabIndex = 7;
            this.label2.Text = "Shop";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(637, 660);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(89, 56);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 6;
            this.pictureBox4.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Azita", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Cornsilk;
            this.label3.Location = new System.Drawing.Point(778, 706);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 33);
            this.label3.TabIndex = 9;
            this.label3.Text = "Doctors";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(775, 660);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(79, 56);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 8;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Azita", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Cornsilk;
            this.label5.Location = new System.Drawing.Point(922, 710);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 33);
            this.label5.TabIndex = 13;
            this.label5.Text = "Log out";
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(915, 660);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(79, 56);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 12;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Click += new System.EventHandler(this.pictureBox7_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Form_shop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial Unicode MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form_shop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox3;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox4;
        private Label label3;
        private PictureBox pictureBox5;
        private Label label5;
        private PictureBox pictureBox7;
        private Label label8;
        private PictureBox pictureBox1;
        private Label label9;
        private Button DeleteButton;
        private Button price_btn;
        private TextBox txt_phone;
        private Label label13;
        private TextBox txt_add;
        private Label label12;
        private TextBox txt_lastname;
        private Label label7;
        private TextBox txt_name;
        private Label label4;
        private ComboBox comboBox2;
        private Label number_shop;
        private ContextMenuStrip contextMenuStrip1;
        private NumericUpDown numeric;
        private TextBox txt_price;
        private Button order_btn;
    }
}