using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;

namespace IT_Banking
{
    public partial class UpdateCustomerProfile : Form
    {
        string accountNumber = Login.L1;
        string usertype = Login.L2;
        string imgloc = "";

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-QJVRKS6\SQLEXPRESS;Initial Catalog=IT_Banking;Integrated Security=True");


        public UpdateCustomerProfile()
        {
            InitializeComponent();
            dis();
        }

        private void dis()
        {
            if (label_UserType.Text == "Customer")
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from Reg_Cust where id = '" + accountNumber + "'", con);

                //SqlCommand cmd1 = new SqlCommand("select Balance from Reg_Cust where id = '" + accountNumber + "'", con);

                SqlCommand cmd2 = new SqlCommand("select image from Reg_Cust where id = '" + accountNumber + "'", con);

                textBox_name.Text = cmd.ExecuteScalar().ToString();
                textBox_gender.Text = cmd.ExecuteScalar().ToString();
                textBox_Dob.Text = cmd.ExecuteScalar().ToString();
                textBox_Email.Text = cmd.ExecuteScalar().ToString();
                textBox_Nid.Text = cmd.ExecuteScalar().ToString();
                textBox_Mob.Text = cmd.ExecuteScalar().ToString();
                label_id.Text = "A/C NO: " + accountNumber;
                label_UserType.Text = usertype;
                pictureBox.Image = Getphoto((byte[])cmd2.ExecuteScalar());

                con.Close();
            }
            else if (label_UserType.Text == "Employee")
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from Reg_Emp where id = '" + accountNumber + "'", con);

                SqlCommand cmd2 = new SqlCommand("select image from Reg_Emp where id = '" + accountNumber + "'", con);

                textBox_name.Text = cmd.ExecuteScalar().ToString();
                textBox_gender.Text = cmd.ExecuteScalar().ToString();
                textBox_Dob.Text = cmd.ExecuteScalar().ToString();
                textBox_Email.Text = cmd.ExecuteScalar().ToString();
                textBox_Nid.Text = cmd.ExecuteScalar().ToString();
                textBox_Mob.Text = cmd.ExecuteScalar().ToString();
                label_id.Text = "A/C NO: " + accountNumber;
                label_UserType.Text = usertype;
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

        private void Update_button_Click(object sender, EventArgs e)
        {
            if (textBox_name.Text != null && textBox_Mob.Text != null && textBox_Email.Text != null && textBox_pass.Text != null && pictureBox.Image != null)
            {
                byte[] images = null;
                FileStream fs = new FileStream(imgloc, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                images = br.ReadBytes((int)fs.Length);

                if(label_UserType.Text=="Customer")
                {
                    SqlCommand cmd = new SqlCommand(@"UPDATE [dbo].[login]
   SET [pass] = '" + textBox_pass.Text + "' WHERE id= '" + label_id.Text + "'", con);
                    SqlCommand cmd1 = new SqlCommand(@"UPDATE [dbo].[Reg_Cust]
   SET [name] = '" + textBox_name.Text + "' ,[mobile] = '" + textBox_Mob.Text + "',[email] = '" + textBox_Email.Text + "' ,[image] =@image WHERE id= '" + label_id.Text + "'", con);

                    con.Open();
                    cmd.Parameters.Add(new SqlParameter("@image", images));
                    cmd.ExecuteNonQuery();
                    cmd1.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Update successfully");
                    this.Hide();
                    CustomerHome ch = new CustomerHome();
                    ch.Show();
                }
                if(label_UserType.Text=="Employee")
                {
                    SqlCommand cmd = new SqlCommand(@"UPDATE [dbo].[login]
   SET [pass] = '" + textBox_pass.Text + "' WHERE id= '" + label_id.Text + "'", con);
                    SqlCommand cmd1 = new SqlCommand(@"UPDATE [dbo].[Reg_Emp]
   SET [name] = '" + textBox_name.Text + "' ,[mobile] = '" + textBox_Mob.Text + "',[email] = '" + textBox_Email.Text + "' ,[image] =@image WHERE id= '" + label_id.Text + "'", con);

                    con.Open();
                    cmd.Parameters.Add(new SqlParameter("@image", images));
                    cmd.ExecuteNonQuery();
                    cmd1.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Update successfully");
                    this.Hide();
                    EmployeeHome eh = new EmployeeHome();
                    eh.Show();
                }
                
            }
            else
            {
                MessageBox.Show("Please complete all the fildes", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Select image";
            ofd.Filter = "Image file(All files) *.*|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                imgloc = ofd.FileName.ToString();
                pictureBox.ImageLocation = imgloc;
            }
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
    }
}
