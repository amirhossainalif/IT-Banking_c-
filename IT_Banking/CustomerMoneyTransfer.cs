using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IT_Banking
{
    public partial class CustomerMoneyTransfer : Form
    {
        string accountNumber = Login.L1;
        string transfer = "Transfer";
        string add = "Add money";

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-QJVRKS6\SQLEXPRESS;Initial Catalog=IT_Banking;Integrated Security=True");

        public CustomerMoneyTransfer()
        {
            InitializeComponent();
            dis();
        }

        void dis()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select Total_Balance from Transaction_Table where id = '" + accountNumber + "'", con);

            label_AC.Text = "A/C NO: " + accountNumber;
            Balance_label.Text = cmd.ExecuteScalar().ToString() + " Taka";

            con.Close();
        }

        private void Exit_Button_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void DepositReq_button_Click(object sender, EventArgs e)
        {
            if(textBox_ACN.Text==null && textBox_TA.Text==null)
            {
                double old = Convert.ToDouble(Balance_label.Text);
                double tra = Convert.ToDouble(textBox_TA.Text);
                if(old > tra)
                {
                    try
                    {
                        con.Open();
                        string querry = "select * from Transaction_Table where id='" + textBox_ACN.Text + "'";

                        SqlDataAdapter sda = new SqlDataAdapter(querry, con);
                        DataTable dt = new DataTable();

                        sda.Fill(dt);

                        double balance = (old - tra);
                        if (dt.Rows.Count > 0)
                        {
                            SqlCommand cmd2 = new SqlCommand("select Total_Balance from Transaction_Table where id = '" + textBox_ACN.Text + "'", con);

                            //label_AC.Text = "A/C NO: " + accountNumber;
                            label_TAB.Text = cmd2.ExecuteScalar().ToString();

                            double old2 = Convert.ToDouble(label_TAB.Text);
                            double bal = old2 + tra;

                            SqlCommand cmd = new SqlCommand(@"INSERT INTO [dbo].[Transaction_Table]
           ([Account_number]
           ,[Date]
           ,[Trans]
           ,[Amount]
           ,[Total_Balance])
     VALUES('" + label_AC.Text + "','" + System.DateTime.Today + "','" + transfer + "','" + textBox_TA.Text + "','" + balance + "')", con);

                            SqlCommand cmd1 = new SqlCommand(@"INSERT INTO [dbo].[Transaction_Table]
           ([Account_number]
           ,[Date]
           ,[Trans]
           ,[Amount]
           ,[Total_Balance]
           ,[Transfered_ID])
     VALUES('" + textBox_ACN.Text + "','" + System.DateTime.Today + "','" + add + "','" + textBox_TA.Text + "','" + bal + "','" + label_AC.Text + "')", con);
                            cmd2.ExecuteNonQuery();
                            cmd.ExecuteNonQuery();
                            cmd1.ExecuteNonQuery();

                            MessageBox.Show("Transfer Successful", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            CustomerHome ch= new CustomerHome();
                            ch.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Invalid Account Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            textBox_ACN.Focus();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        con.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Insufficient balance", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                
            }
        }
    }
}
