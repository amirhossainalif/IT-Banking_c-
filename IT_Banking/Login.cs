using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace IT_Banking
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        public static string L1;
        public static string L2;

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-QJVRKS6\SQLEXPRESS;Initial Catalog=IT_Banking;Integrated Security=True");

        private void label6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registration r = new Registration();
            r.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LogIN_button_Click(object sender, EventArgs e)
        {
            if(id_textBox1.Text !=null && Pass_textBox.Text != null)
            {
                L1= id_textBox1.Text;
                L2=Catagory_comboBox.Text;
                try
                {
                    

                    /*SqlDataAdapter sda = new SqlDataAdapter("select * from login where id ='" + L1 + "' and pass = '" + Pass_textBox.Text + "'and usertype = '"+Catagory_comboBox.Items+"'", con);
                    DataTable dt = new DataTable();*/
                    //sda.Fill(dt);
                    /*if (dt.Rows.Count > 0)
                    {
                        if (Catagory_comboBox.SelectedItem.ToString() == "Customer")
                        {
                            CustomerHome ch = new CustomerHome();
                            ch.Show();
                            this.Hide();
                        }
                        else if (Catagory_comboBox.SelectedItem.ToString() == "Employee")
                        {
                            EmployeeHome eh = new EmployeeHome();
                            eh.Show();
                            this.Hide();
                        }
                        else
                        {
                            Admin admin = new Admin();
                            admin.Show();
                            this.Hide();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid user id or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        *//*id_textBox1.Clear();
                        Pass_textBox.Clear();
                        id_textBox1.Focus();*//*
                    }*/


                    SqlCommand cmd = new SqlCommand("select * from login where id='"+L1+"'and pass='"+Pass_textBox.Text+"'and usertype='"+Catagory_comboBox.Text+"'", con);

                   // SqlCommand cmd = new SqlCommand(@"select * from login where id = '"+id_textBox1.Text+"' and pass = '" +Pass_textBox.Text+ "'and usertype = '"+Catagory_comboBox.Text+"'", con);
                    con.Open();
                    /*SqlCommand cmd = new SqlCommand("select * from login where id=@id and pass=@pass", con);
                    cmd.Parameters.AddWithValue("@id", L1);
                    cmd.Parameters.AddWithValue("@pass", Pass_textBox.Text);*/

                    SqlDataReader Type = cmd.ExecuteReader();

                    if(Type.HasRows == true)
                    {
                        Type.Read();
                        if (Type[3].ToString()== "Customer")
                        {
                            CustomerHome customerHome = new CustomerHome(); 
                            customerHome.Show();
                            this.Hide();
                        }
                        if (Type[3].ToString()== "Employee")
                        {
                            EmployeeHome empHome = new EmployeeHome();  
                            empHome.Show();
                            this.Hide();
                        }
                        if (Type[3].ToString()=="Admin")
                        {
                            Admin ad = new Admin();
                            ad.Show();
                            this.Hide();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid Password or User Name. \n Try Again!! ", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                        Pass_textBox.Focus();
                        return;
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
        }

        private void Catagory_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Catagory_comboBox.SelectedItem.ToString() == "Customer")
            {
                Catagory_label.Visible = false;
                panel2.Visible = true;

                string a = "Account Number";
                label2.Text = a;
            }
            else if (Catagory_comboBox.SelectedItem.ToString() == "Employee")
            {
                Catagory_label.Visible = false;
                panel2.Visible = true;

                string b = "Id";
                label2.Text = b;
            }
            else
            {
                Catagory_label.Visible = false;
                panel2.Visible = true;
                
                //label2.Visible = true;
                //id_textBox1.Visible= false;

                string c = "Admin";
                label2.Text = c;
                id_textBox1.Text = "admin";
                id_textBox1.ReadOnly = true;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                Pass_textBox.UseSystemPasswordChar = false;
            }

            else
            {
                Pass_textBox.UseSystemPasswordChar = true;
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            ForgotPassword forgotPassword = new ForgotPassword();
            forgotPassword.Show();
            this.Hide();
        }
    }
}
