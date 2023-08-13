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
    public partial class CustomerHome : Form
    {
        string accountNumber = Login.L1;

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-QJVRKS6\SQLEXPRESS;Initial Catalog=IT_Banking;Integrated Security=True");

        public CustomerHome()
        {
            InitializeComponent();
            dis();
        }

        private void dis()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select name from Reg_Cust where id = '" + accountNumber + "'", con);

            SqlCommand cmd1 = new SqlCommand("select Total_Balance from Transaction_Table where id = '" + accountNumber + "'", con);

            SqlCommand cmd2 = new SqlCommand("select image from Reg_Cust where id = '" + accountNumber + "'", con);

            label_name.Text = cmd.ExecuteScalar().ToString();
            label_id.Text = "A/C NO: " + accountNumber;
            Balance_label.Text = cmd1.ExecuteScalar().ToString() + " Taka";
            pictureBox_cus.Image = Getphoto((byte[])cmd2.ExecuteScalar());

            SqlDataAdapter sda = new SqlDataAdapter("select * from Transaction_Table where Account_number='"+accountNumber+"' ", con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dataGridView_Money.DataSource = ds.Tables[0];

            con.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Home_button_Click(object sender, EventArgs e)
        {
            HomePage hp = new HomePage();
            this.Hide();
            hp.Show();
        }

        private void Profile_Button_Click(object sender, EventArgs e)
        {
            CustomerProfile cp = new CustomerProfile();
            this.Hide();    
            cp.Show();
        }

        private void Deposit_button_Click(object sender, EventArgs e)
        {
            CustomerDeposit cd = new CustomerDeposit(); 
            this.Hide();
            cd.Show();
        }

        private void Withdraw_button_Click(object sender, EventArgs e)
        {
            CustomerWithdrow cw = new CustomerWithdrow();   
            this.Hide();
            cw.Show();
        }

        private void Logout_Button_Click(object sender, EventArgs e)
        {
            Login ln = new Login();
            this.Hide();
            ln.Show();
        }


        private Image Getphoto(byte[] value)
        {
            MemoryStream ms = new MemoryStream(value);
            return Image.FromStream(ms);
        }

        private void MoneyTransfer_button_Click(object sender, EventArgs e)
        {
            CustomerMoneyTransfer cmf = new CustomerMoneyTransfer();    
            cmf.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter("select * from Transaction_Table where Date like '%" + Search_Box.Text + "%'", con);
            SqlDataAdapter sda1 = new SqlDataAdapter("select * from Transaction_Table where Amount like '%" + Search_Box.Text + "%'", con);
            SqlDataAdapter sda2 = new SqlDataAdapter("select * from Transaction_Table where Trans like '%" + Search_Box.Text + "%'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            sda1.Fill(dt);
            sda2.Fill(dt);
            dataGridView_Money.DataSource = dt;
        }

        private void Search_button_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from Transaction_Table where Date like '%" + Search_Box.Text + "%'", con);
                SqlCommand cmd1 = new SqlCommand("select * from Transaction_Table where Amount like '%" + Search_Box.Text + "%'", con);
                SqlCommand cmd2 = new SqlCommand("select * from Transaction_Table where Trans like '%" + Search_Box.Text + "%'", con);
                SqlDataReader sdr = cmd.ExecuteReader();
                SqlDataReader sdr1 = cmd1.ExecuteReader();
                SqlDataReader sdr2 = cmd2.ExecuteReader();

                dt.Load(sdr);
                dt.Load(sdr1);
                dt.Load(sdr2);
                con.Close();
                dataGridView_Money.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
