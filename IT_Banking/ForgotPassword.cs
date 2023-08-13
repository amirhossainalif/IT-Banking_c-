using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace IT_Banking
{

    public partial class ForgotPassword : Form
    {
        string randcode;
        public static string to;

        public ForgotPassword()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-QJVRKS6\SQLEXPRESS;Initial Catalog=IT_Banking;Integrated Security=True");

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Home_button_Click(object sender, EventArgs e)
        {
            HomePage hp = new HomePage();
            hp.Show();
            this.Hide();
        }

        private void OTP_button_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select * from login where email='"+textBox_email.Text+"'", con);

            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();

            if (sdr.HasRows == true)
            {
                sdr.Read();
                Random rand = new Random();
                randcode = (rand.Next(999999).ToString());
                MailMessage mm = new MailMessage();
                to = (textBox_email.Text).ToString();

                string from = "itcsbd2022@gmail.com";
                string pass = "bvtjhwnauhuwusjp";
                string messageBody = "Your OTP code is: " + randcode;

                mm.To.Add(to);
                mm.From = new MailAddress(from);
                mm.Body = messageBody;
                mm.Subject = "Your IT-Banking OTP code";

                SmtpClient sc = new SmtpClient("smtp.gmail.com");
                sc.EnableSsl = true;
                sc.Port = 587;
                sc.DeliveryMethod = SmtpDeliveryMethod.Network;
                sc.Credentials = new NetworkCredential(from, pass);

                try
                {
                    sc.Send(mm);
                    MessageBox.Show("OTP Send successfully");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Invalid Email id", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            con.Close();
        }

        private void ResetPass_Button_Click(object sender, EventArgs e)
        {
            if (randcode == (textBox_OTP.Text).ToString())
            {
                to = textBox_email.Text;
                SqlCommand cmd = new SqlCommand(@"UPDATE [dbo].[login]
   SET [pass] = '"+textBox_pass.Text+"' WHERE email= '"+textBox_email.Text+"'", con);
                SqlCommand cmd1 = new SqlCommand(@"UPDATE [dbo].[Registration]
   SET [pass] = '" + textBox_pass.Text + "' WHERE email= '" + textBox_email.Text + "'", con);

                con.Open();
                cmd.ExecuteNonQuery();
                cmd1.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Password reset successfully");
                this.Hide();
                Login ln = new Login();
                ln.Show();
            }
            else
            {
                MessageBox.Show("Wrong OTP code", "Error", MessageBoxButtons.OK);
            }
        }
    }
}
