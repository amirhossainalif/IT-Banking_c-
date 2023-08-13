namespace IT_Banking
{
    partial class CustomerHome
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerHome));
            this.panel1 = new System.Windows.Forms.Panel();
            this.MoneyTransfer_button = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView_Money = new System.Windows.Forms.DataGridView();
            this.Search_button = new System.Windows.Forms.Button();
            this.Search_Box = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Balance_label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label_id = new System.Windows.Forms.Label();
            this.Deposit_button = new System.Windows.Forms.Button();
            this.label_name = new System.Windows.Forms.Label();
            this.Logout_Button = new System.Windows.Forms.Button();
            this.pictureBox_cus = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Withdraw_button = new System.Windows.Forms.Button();
            this.Home_button = new System.Windows.Forms.Button();
            this.Profile_Button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Money)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_cus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SkyBlue;
            this.panel1.Controls.Add(this.MoneyTransfer_button);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.dataGridView_Money);
            this.panel1.Controls.Add(this.Search_button);
            this.panel1.Controls.Add(this.Search_Box);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.Balance_label);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1124, 602);
            this.panel1.TabIndex = 3;
            // 
            // MoneyTransfer_button
            // 
            this.MoneyTransfer_button.BackColor = System.Drawing.Color.LightBlue;
            this.MoneyTransfer_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MoneyTransfer_button.Location = new System.Drawing.Point(813, 188);
            this.MoneyTransfer_button.Name = "MoneyTransfer_button";
            this.MoneyTransfer_button.Size = new System.Drawing.Size(190, 40);
            this.MoneyTransfer_button.TabIndex = 29;
            this.MoneyTransfer_button.Text = "Money Transfer";
            this.MoneyTransfer_button.UseVisualStyleBackColor = false;
            this.MoneyTransfer_button.Click += new System.EventHandler(this.MoneyTransfer_button_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(515, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(221, 46);
            this.label5.TabIndex = 28;
            this.label5.Text = "IT-Banking";
            // 
            // dataGridView_Money
            // 
            this.dataGridView_Money.BackgroundColor = System.Drawing.Color.SkyBlue;
            this.dataGridView_Money.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Money.GridColor = System.Drawing.Color.CornflowerBlue;
            this.dataGridView_Money.Location = new System.Drawing.Point(219, 247);
            this.dataGridView_Money.Name = "dataGridView_Money";
            this.dataGridView_Money.RowHeadersWidth = 51;
            this.dataGridView_Money.RowTemplate.Height = 24;
            this.dataGridView_Money.Size = new System.Drawing.Size(892, 338);
            this.dataGridView_Money.TabIndex = 20;
            // 
            // Search_button
            // 
            this.Search_button.BackColor = System.Drawing.Color.LightBlue;
            this.Search_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search_button.Location = new System.Drawing.Point(631, 188);
            this.Search_button.Name = "Search_button";
            this.Search_button.Size = new System.Drawing.Size(146, 40);
            this.Search_button.TabIndex = 19;
            this.Search_button.Text = "Search";
            this.Search_button.UseVisualStyleBackColor = false;
            this.Search_button.Click += new System.EventHandler(this.Search_button_Click);
            // 
            // Search_Box
            // 
            this.Search_Box.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Search_Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search_Box.Location = new System.Drawing.Point(289, 188);
            this.Search_Box.Multiline = true;
            this.Search_Box.Name = "Search_Box";
            this.Search_Box.Size = new System.Drawing.Size(302, 38);
            this.Search_Box.TabIndex = 11;
            this.Search_Box.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(275, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(286, 29);
            this.label4.TabIndex = 10;
            this.label4.Text = "Your transaction history";
            // 
            // Balance_label
            // 
            this.Balance_label.AutoSize = true;
            this.Balance_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Balance_label.Location = new System.Drawing.Point(520, 93);
            this.Balance_label.Name = "Balance_label";
            this.Balance_label.Size = new System.Drawing.Size(71, 29);
            this.Balance_label.TabIndex = 9;
            this.Balance_label.Text = "Taka";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(275, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(237, 29);
            this.label3.TabIndex = 8;
            this.label3.Text = "Your main balance ";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel2.Controls.Add(this.label_id);
            this.panel2.Controls.Add(this.Deposit_button);
            this.panel2.Controls.Add(this.label_name);
            this.panel2.Controls.Add(this.Logout_Button);
            this.panel2.Controls.Add(this.pictureBox_cus);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.Withdraw_button);
            this.panel2.Controls.Add(this.Home_button);
            this.panel2.Controls.Add(this.Profile_Button);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(210, 596);
            this.panel2.TabIndex = 7;
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_id.Location = new System.Drawing.Point(18, 255);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(58, 22);
            this.label_id.TabIndex = 25;
            this.label_id.Text = "label6";
            // 
            // Deposit_button
            // 
            this.Deposit_button.BackColor = System.Drawing.Color.LightBlue;
            this.Deposit_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deposit_button.Location = new System.Drawing.Point(39, 422);
            this.Deposit_button.Name = "Deposit_button";
            this.Deposit_button.Size = new System.Drawing.Size(146, 40);
            this.Deposit_button.TabIndex = 24;
            this.Deposit_button.Text = "Deposit";
            this.Deposit_button.UseVisualStyleBackColor = false;
            this.Deposit_button.Click += new System.EventHandler(this.Deposit_button_Click);
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_name.Location = new System.Drawing.Point(19, 219);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(58, 22);
            this.label_name.TabIndex = 23;
            this.label_name.Text = "label2";
            // 
            // Logout_Button
            // 
            this.Logout_Button.BackColor = System.Drawing.Color.LightBlue;
            this.Logout_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logout_Button.Location = new System.Drawing.Point(39, 519);
            this.Logout_Button.Name = "Logout_Button";
            this.Logout_Button.Size = new System.Drawing.Size(146, 45);
            this.Logout_Button.TabIndex = 21;
            this.Logout_Button.Text = "Log Out";
            this.Logout_Button.UseVisualStyleBackColor = false;
            this.Logout_Button.Click += new System.EventHandler(this.Logout_Button_Click);
            // 
            // pictureBox_cus
            // 
            this.pictureBox_cus.BackColor = System.Drawing.Color.PowderBlue;
            this.pictureBox_cus.Location = new System.Drawing.Point(22, 14);
            this.pictureBox_cus.Name = "pictureBox_cus";
            this.pictureBox_cus.Size = new System.Drawing.Size(163, 161);
            this.pictureBox_cus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_cus.TabIndex = 22;
            this.pictureBox_cus.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome ";
            // 
            // Withdraw_button
            // 
            this.Withdraw_button.BackColor = System.Drawing.Color.LightBlue;
            this.Withdraw_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Withdraw_button.Location = new System.Drawing.Point(39, 468);
            this.Withdraw_button.Name = "Withdraw_button";
            this.Withdraw_button.Size = new System.Drawing.Size(146, 45);
            this.Withdraw_button.TabIndex = 20;
            this.Withdraw_button.Text = "Withdraw";
            this.Withdraw_button.UseVisualStyleBackColor = false;
            this.Withdraw_button.Click += new System.EventHandler(this.Withdraw_button_Click);
            // 
            // Home_button
            // 
            this.Home_button.BackColor = System.Drawing.Color.LightBlue;
            this.Home_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Home_button.Location = new System.Drawing.Point(39, 330);
            this.Home_button.Name = "Home_button";
            this.Home_button.Size = new System.Drawing.Size(146, 40);
            this.Home_button.TabIndex = 18;
            this.Home_button.Text = "Home";
            this.Home_button.UseVisualStyleBackColor = false;
            this.Home_button.Click += new System.EventHandler(this.Home_button_Click);
            // 
            // Profile_Button
            // 
            this.Profile_Button.BackColor = System.Drawing.Color.LightBlue;
            this.Profile_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Profile_Button.Location = new System.Drawing.Point(39, 376);
            this.Profile_Button.Name = "Profile_Button";
            this.Profile_Button.Size = new System.Drawing.Size(146, 40);
            this.Profile_Button.TabIndex = 19;
            this.Profile_Button.Text = "Profile";
            this.Profile_Button.UseVisualStyleBackColor = false;
            this.Profile_Button.Click += new System.EventHandler(this.Profile_Button_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1078, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // CustomerHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 626);
            this.Controls.Add(this.panel1);
            this.Name = "CustomerHome";
            this.Text = "CustomerHome";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Money)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_cus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Home_button;
        private System.Windows.Forms.Button Profile_Button;
        private System.Windows.Forms.Button Logout_Button;
        private System.Windows.Forms.Button Withdraw_button;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.PictureBox pictureBox_cus;
        private System.Windows.Forms.Button Deposit_button;
        private System.Windows.Forms.Label Balance_label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Search_Box;
        private System.Windows.Forms.DataGridView dataGridView_Money;
        private System.Windows.Forms.Button Search_button;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button MoneyTransfer_button;
        private System.Windows.Forms.Label label_id;
    }
}