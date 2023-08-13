namespace IT_Banking
{
    partial class CustomerMoneyTransfer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerMoneyTransfer));
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox_ACN = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DepositReq_button = new System.Windows.Forms.Button();
            this.Logout_Button = new System.Windows.Forms.Button();
            this.Back_button = new System.Windows.Forms.Button();
            this.textBox_TA = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Balance_label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Exit_Button = new System.Windows.Forms.PictureBox();
            this.label_AC = new System.Windows.Forms.Label();
            this.label_TAB = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Exit_Button)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SkyBlue;
            this.panel1.Controls.Add(this.label_TAB);
            this.panel1.Controls.Add(this.label_AC);
            this.panel1.Controls.Add(this.textBox_ACN);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.DepositReq_button);
            this.panel1.Controls.Add(this.Logout_Button);
            this.panel1.Controls.Add(this.Back_button);
            this.panel1.Controls.Add(this.textBox_TA);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Balance_label);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.Exit_Button);
            this.panel1.Location = new System.Drawing.Point(12, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(495, 582);
            this.panel1.TabIndex = 1;
            // 
            // textBox_ACN
            // 
            this.textBox_ACN.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox_ACN.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_ACN.Location = new System.Drawing.Point(297, 270);
            this.textBox_ACN.Name = "textBox_ACN";
            this.textBox_ACN.Size = new System.Drawing.Size(149, 34);
            this.textBox_ACN.TabIndex = 37;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(58, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(205, 29);
            this.label4.TabIndex = 36;
            this.label4.Text = "Account Number";
            // 
            // DepositReq_button
            // 
            this.DepositReq_button.BackColor = System.Drawing.Color.LightBlue;
            this.DepositReq_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DepositReq_button.Location = new System.Drawing.Point(139, 419);
            this.DepositReq_button.Name = "DepositReq_button";
            this.DepositReq_button.Size = new System.Drawing.Size(224, 40);
            this.DepositReq_button.TabIndex = 35;
            this.DepositReq_button.Text = "Transfer money";
            this.DepositReq_button.UseVisualStyleBackColor = false;
            this.DepositReq_button.Click += new System.EventHandler(this.DepositReq_button_Click);
            // 
            // Logout_Button
            // 
            this.Logout_Button.BackColor = System.Drawing.Color.LightBlue;
            this.Logout_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logout_Button.Location = new System.Drawing.Point(292, 517);
            this.Logout_Button.Name = "Logout_Button";
            this.Logout_Button.Size = new System.Drawing.Size(146, 45);
            this.Logout_Button.TabIndex = 34;
            this.Logout_Button.Text = "Log Out";
            this.Logout_Button.UseVisualStyleBackColor = false;
            this.Logout_Button.Click += new System.EventHandler(this.Logout_Button_Click);
            // 
            // Back_button
            // 
            this.Back_button.BackColor = System.Drawing.Color.LightBlue;
            this.Back_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back_button.Location = new System.Drawing.Point(58, 519);
            this.Back_button.Name = "Back_button";
            this.Back_button.Size = new System.Drawing.Size(146, 40);
            this.Back_button.TabIndex = 31;
            this.Back_button.Text = "Back";
            this.Back_button.UseVisualStyleBackColor = false;
            this.Back_button.Click += new System.EventHandler(this.Back_button_Click);
            // 
            // textBox_TA
            // 
            this.textBox_TA.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox_TA.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_TA.Location = new System.Drawing.Point(297, 329);
            this.textBox_TA.Name = "textBox_TA";
            this.textBox_TA.Size = new System.Drawing.Size(149, 34);
            this.textBox_TA.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(58, 330);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 29);
            this.label2.TabIndex = 29;
            this.label2.Text = "Transfer Amount";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(131, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 46);
            this.label1.TabIndex = 28;
            this.label1.Text = "IT-Banking";
            // 
            // Balance_label
            // 
            this.Balance_label.AutoSize = true;
            this.Balance_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Balance_label.Location = new System.Drawing.Point(292, 179);
            this.Balance_label.Name = "Balance_label";
            this.Balance_label.Size = new System.Drawing.Size(71, 29);
            this.Balance_label.TabIndex = 11;
            this.Balance_label.Text = "Taka";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(58, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(237, 29);
            this.label3.TabIndex = 10;
            this.label3.Text = "Your main balance ";
            // 
            // Exit_Button
            // 
            this.Exit_Button.Image = ((System.Drawing.Image)(resources.GetObject("Exit_Button.Image")));
            this.Exit_Button.Location = new System.Drawing.Point(458, 3);
            this.Exit_Button.Name = "Exit_Button";
            this.Exit_Button.Size = new System.Drawing.Size(34, 37);
            this.Exit_Button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Exit_Button.TabIndex = 7;
            this.Exit_Button.TabStop = false;
            this.Exit_Button.Click += new System.EventHandler(this.Exit_Button_Click);
            // 
            // label_AC
            // 
            this.label_AC.AutoSize = true;
            this.label_AC.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_AC.Location = new System.Drawing.Point(205, 115);
            this.label_AC.Name = "label_AC";
            this.label_AC.Size = new System.Drawing.Size(55, 29);
            this.label_AC.TabIndex = 38;
            this.label_AC.Text = "A/C";
            this.label_AC.Visible = false;
            // 
            // label_TAB
            // 
            this.label_TAB.AutoSize = true;
            this.label_TAB.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TAB.Location = new System.Drawing.Point(383, 115);
            this.label_TAB.Name = "label_TAB";
            this.label_TAB.Size = new System.Drawing.Size(63, 29);
            this.label_TAB.TabIndex = 39;
            this.label_TAB.Text = "TAB";
            this.label_TAB.Visible = false;
            // 
            // CustomerMoneyTransfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 602);
            this.Controls.Add(this.panel1);
            this.Name = "CustomerMoneyTransfer";
            this.Text = "CustomerMoneyTransfer";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Exit_Button)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button DepositReq_button;
        private System.Windows.Forms.Button Logout_Button;
        private System.Windows.Forms.Button Back_button;
        private System.Windows.Forms.TextBox textBox_TA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Balance_label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox Exit_Button;
        private System.Windows.Forms.TextBox textBox_ACN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_AC;
        private System.Windows.Forms.Label label_TAB;
    }
}