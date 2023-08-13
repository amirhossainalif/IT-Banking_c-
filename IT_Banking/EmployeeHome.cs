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
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace IT_Banking
{
    public partial class EmployeeHome : Form
    {
        string id = Login.L1;
        string key = "";
        string usertype = "Customer";
        string imgloc = "";

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-QJVRKS6\SQLEXPRESS;Initial Catalog=IT_Banking;Integrated Security=True");

        public EmployeeHome()
        {
            InitializeComponent();
            dis();
            
        }

        private void dis()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select name from Reg_Emp where id = '" + id + "'", con);
            SqlCommand cmd1 = new SqlCommand("Select image from Reg_Emp where id= '" + id + "'", con);

            label_name.Text = cmd.ExecuteScalar().ToString();
            label_id.Text = id;
            pictureBox_emp.Image = GetPhoto((Byte[])cmd1.ExecuteScalar());



            /*string query9 = "Select image from Reg_Emp where id=@id";

            SqlCommand cmd9 = new SqlCommand(query9, con);
            cmd9.Parameters.AddWithValue("@id", id);
            SqlDataReader sdr = cmd9.ExecuteReader();
            sdr.Read();

            byte[] img = (byte[])(sdr[0]);

            if (img == null)
            {
                pictureBox_emp.Image = null;
            }
            else
            {
                MemoryStream ms = new MemoryStream(img);
                pictureBox_emp.Image = Image.FromStream(ms);
            }
            sdr.Close();*/

            SqlDataAdapter sda = new SqlDataAdapter("select * from Reg_cust ", con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dataGridView_Cus.DataSource = ds.Tables[0];

            con.Close();
        }

        private void clear()
        {
            textBox2_AC.Text = "";
            textBox_name.Text = "";
            Gender_comboBox1.Text = "";
            DOB.Text = "";
            textBox_nid.Text = "";
            textBox_mob.Text = "";
            textBox_email.Text = "";
            textBox_bal.Text = "";
            Pass.Text = "";
            key = "";
            pictureBox_cus.Image = null;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void Logout_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login ln = new Login();
            ln.Show();
        }

        private void Home_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePage hp = new HomePage();   
            hp.Show();
        }

        private void Profile_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerProfile ep = new CustomerProfile();
            ep.Show();
        }

        private void DepositApprove_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            DepositApprove da = new DepositApprove();
            da.Show();
        }

        private System.Drawing.Image GetPhoto(byte[] value)
        {
            MemoryStream ms = new MemoryStream(value);
            System.Drawing.Image rm = System.Drawing.Image.FromStream(ms);
            return rm;
        }

        private void dataGridView_Cus_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox2_AC.Text = dataGridView_Cus.SelectedRows[0].Cells[0].Value.ToString();
            textBox_name.Text = dataGridView_Cus.SelectedRows[0].Cells[1].Value.ToString();
            Gender_comboBox1.Text = dataGridView_Cus.SelectedRows[0].Cells[2].Value.ToString();
            DOB.Text = dataGridView_Cus.SelectedRows[0].Cells[3].Value.ToString();
            textBox_nid.Text = dataGridView_Cus.SelectedRows[0].Cells[4].Value.ToString();
            textBox_mob.Text = dataGridView_Cus.SelectedRows[0].Cells[5].Value.ToString();
            textBox_email.Text = dataGridView_Cus.SelectedRows[0].Cells[6].Value.ToString();
            pictureBox_cus.Image = GetPhoto((Byte[])dataGridView_Cus.SelectedRows[0].Cells[7].Value);
            dataGridView_Cus.SelectedRows[0].Cells[8].Value.ToString();
            textBox_bal.Text = dataGridView_Cus.SelectedRows[0].Cells[9].Value.ToString();

            if (textBox2_AC.Text == "")
            {
                key = "";
            }
            else
            {
                key = dataGridView_Cus.SelectedRows[0].Cells[0].Value.ToString();
            }
        }

        private void pictureBox_cus_Click(object sender, EventArgs e)
        {
            /*OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Select photo";
            ofd.Filter = "Image file(*.png;*jpeg;*jpg;*bmp) | *.png;*jpeg;*jpg;*bmp";
            //ofd.ShowDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox_cus.Image = new Bitmap(ofd.FileName);
            }*/

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Select image";
            ofd.Filter = "Image file(All files) *.*|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                imgloc = ofd.FileName.ToString();
                pictureBox_cus.ImageLocation = imgloc;
            }
        }

        /*private object Sphoto()
        {
            MemoryStream ms = new MemoryStream();
            pictureBox_cus.Image.Save(ms, pictureBox_cus.Image.RawFormat);
            return ms.GetBuffer();
        }*/

        private void UpdateCustomerProfile_button_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand sqlCommand = new SqlCommand(@"UPDATE [dbo].[Reg_Cust]
   SET [name] = '" + textBox_name.Text + "',[gender] = '" + Gender_comboBox1.Text + "',[dob] = '" + DOB.Text + "',[nid] = '" + textBox_nid.Text + "',[mobile] = '" + textBox_mob.Text + "',[email] = '" + textBox_email.Text + "',[image] = '" + pictureBox_cus.Image + "' ,[usertype] = '" + usertype + "' ,[Balance] = '" + textBox_bal.Text + "' WHERE id= '"+textBox2_AC.Text+"'", con);

                SqlCommand cmd = new SqlCommand(@"UPDATE [dbo].[login]
   SET [email] = '" + textBox_email.Text + "' WHERE id= '" + textBox2_AC.Text + "'", con);


                sqlCommand.ExecuteNonQuery();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Customer id:" + textBox2_AC.Text + " Updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();
                dis();
                clear();

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void AddCustomerProfile_Button_Click(object sender, EventArgs e)
        {
            if (textBox_name.Text != null && Gender_comboBox1.Items != null && DOB.Value != null && textBox_nid.Text != null && textBox_mob.Text != null && textBox_email.Text != null && Pass.Text != null && pictureBox_cus.Image != null )
            {
                byte[] images = null;
                FileStream fs = new FileStream(imgloc, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                images = br.ReadBytes((int)fs.Length);

                try
                {
                    Random rnd = new Random();
                    int rndnum = rnd.Next(99999999);

                    SqlCommand cmd = new SqlCommand(@"INSERT INTO [dbo].[Reg_Cust]
           ([id]
           ,[name]
           ,[gender]
           ,[dob]
           ,[nid]
           ,[mobile]
           ,[email]
           ,[image]
           ,[usertype]
           ,[Balance])
     VALUES('" + rndnum + "','" + textBox_name.Text + "','" + Gender_comboBox1.Text + "','" + DOB.Value + "','" + textBox_nid.Text + "','" + textBox_mob.Text + "','" + textBox_email.Text + "',@image,'" + usertype + "','" + textBox_bal.Text + "')", con);
                    SqlCommand cmd1 = new SqlCommand(@"INSERT INTO [dbo].[login]
           ([email]
           ,[pass]
           ,[id]
           ,[usertype])
     VALUES('" + textBox_email.Text + "','" + Pass.Text + "','" + rndnum + "','" + usertype + "')", con);
                    con.Open();
                    cmd.Parameters.Add(new SqlParameter("@image", images));
                    cmd.ExecuteNonQuery();
                    cmd1.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Registration Successfull and your id:" + rndnum, "Registration", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    Login ln = new Login();
                    ln.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please complete all the fildes", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteCustomerProfile_button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Are you sure", "Warrning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            if (true)
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(@"DELETE FROM [dbo].[Reg_Cust]
      WHERE id= '" + textBox2_AC.Text + "'", con);
                SqlCommand cmd1 = new SqlCommand(@"DELETE FROM [dbo].[login]
      WHERE id = '" + textBox2_AC.Text + "'", con);

                cmd.ExecuteNonQuery();
                cmd1.ExecuteNonQuery();
                MessageBox.Show("Account delete successful", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();
                dis();
                clear();
            } 
        }

        private void Search_button_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from Reg_Cust where name like '%" + SearchBox.Text + "%'", con);
                SqlCommand cmd1 = new SqlCommand("select * from Reg_Cust where id like '%" + SearchBox.Text + "%'", con);
                SqlDataReader sdr = cmd.ExecuteReader();
                SqlDataReader sdr1 = cmd1.ExecuteReader();
                dt.Load(sdr);
                dt.Load(sdr1);
                con.Close();
                dataGridView_Cus.DataSource = dt;

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter("select * from Reg_Cust where name like '%" + SearchBox.Text + "%'", con);
            SqlDataAdapter sda1 = new SqlDataAdapter("select * from Reg_Cust where id like '%" + SearchBox.Text + "%'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            sda1.Fill(dt);
            dataGridView_Cus.DataSource= dt;
        }
    }
    
}
