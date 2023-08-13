using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IT_Banking
{
    public partial class CustomerProfile : Form
    {

        string accountNumber = Login.L1;
        string userType = Login.L2;
        string imgloc = "";
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-QJVRKS6\SQLEXPRESS;Initial Catalog=IT_Banking;Integrated Security=True");

        public CustomerProfile()
        {
            InitializeComponent();
            dis();
        }

        private void Home_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePage hp = new HomePage();
            hp.Show();
        }

        private void Update_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            UpdateCustomerProfile ucp   = new UpdateCustomerProfile();  
            ucp.Show();
        }

        private void Back_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerHome ch = new CustomerHome();
            ch.Show();
        }

        private void Logout_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login ln = new Login();
            ln.Show();
        }

        private void Exit_Button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dis()
        {
            if(label_UserType.Text=="Customer")
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from Reg_Cust where id = '" + accountNumber + "'", con);

                SqlCommand cmd2 = new SqlCommand("select image from Reg_Cust where id = '" + accountNumber + "'", con);

                textBox_Name.Text = cmd.ExecuteScalar().ToString();
                textBox_Gender.Text = cmd.ExecuteScalar().ToString();
                textBox_Dob.Text = cmd.ExecuteScalar().ToString();
                textBox_Email.Text = cmd.ExecuteScalar().ToString();
                textBox_Nid.Text = cmd.ExecuteScalar().ToString();
                textBox_Mob.Text = cmd.ExecuteScalar().ToString();
                label_id.Text = "A/C NO: " + accountNumber;
                label_UserType.Text = userType;
                pictureBox.Image = Getphoto((byte[])cmd2.ExecuteScalar());

                con.Close();
            }
            else if(label_UserType.Text=="Employee")
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from Reg_Emp where id = '" + accountNumber + "'", con);

                SqlCommand cmd2 = new SqlCommand("select image from Reg_Emp where id = '" + accountNumber + "'", con);

                textBox_Name.Text = cmd.ExecuteScalar().ToString();
                textBox_Gender.Text = cmd.ExecuteScalar().ToString();
                textBox_Dob.Text = cmd.ExecuteScalar().ToString();
                textBox_Email.Text = cmd.ExecuteScalar().ToString();
                textBox_Nid.Text = cmd.ExecuteScalar().ToString();
                textBox_Mob.Text = cmd.ExecuteScalar().ToString();
                label_id.Text = "A/C NO: " + accountNumber;
                label_UserType.Text = userType;
                pictureBox.Image = Getphoto((byte[])cmd2.ExecuteScalar());

                con.Close();
            }
            else
            {
                MessageBox.Show("Error");
            }
            
        }
        private Image Getphoto(byte[] value)
        {
            MemoryStream ms = new MemoryStream(value);
            return Image.FromStream(ms);
        }
    }
}
