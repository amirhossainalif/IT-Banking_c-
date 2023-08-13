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
    public partial class Registration : Form
    {
        string imgloc = "";
        string money = "Add Money";

        public Registration()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-QJVRKS6\SQLEXPRESS;Initial Catalog=IT_Banking;Integrated Security=True");

        private void ConfirmReg_Button_Click(object sender, EventArgs e)
        {
            if(name.Text != null && Gender_comboBox1.Items != null && DOB.Value != null && NIDN.Text != null && Mob.Text != null && Email.Text != null && Pass.Text != null && Pic_pictureBox2.Image != null && Catagory_comboBox.Items != null)
            {
                byte[] images = null;
                FileStream fs = new FileStream(imgloc, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                images = br.ReadBytes((int)fs.Length);

                try
                {
                    Random rnd = new Random();
                    int rndnum = rnd.Next(99999999);

                    if (Catagory_comboBox.SelectedItem.ToString() == "Customer")
                    {
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
     VALUES('" + rndnum + "','" + name.Text + "','" + Gender_comboBox1.Text + "','" + DOB.Value + "','" + NIDN.Text + "','" + Mob.Text + "','" + Email.Text + "',@image,'" + Catagory_comboBox.Text + "','"+textBox_bal.Text+"')", con);
                        SqlCommand cmd1 = new SqlCommand(@"INSERT INTO [dbo].[login]
           ([email]
           ,[pass]
           ,[id]
           ,[usertype])
     VALUES('" + Email.Text + "','" + Pass.Text + "','" + rndnum + "','" + Catagory_comboBox.Text + "')", con);

                        SqlCommand cmd2 = new SqlCommand(@"INSERT INTO [dbo].[Transaction_Table]
           ([Account_number]
           ,[Date]
           ,[Trans]
           ,[Amount]
           ,[Total_Balance])
     VALUES('"+rndnum+"','"+dateToday.Value+"','"+money+"','"+textBox_bal.Text+"','"+textBox_bal.Text+"')",con);
                        con.Open();
                        //cmd.Parameters.AddWithValue("@image", Sphoto());
                        cmd.Parameters.Add(new SqlParameter("@image", images));
                        cmd.ExecuteNonQuery();
                        cmd1.ExecuteNonQuery();
                        cmd2.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Registration Successfull and your id:" + rndnum, "Registration", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        Login ln = new Login();
                        ln.Show();
                    }
                    if(Catagory_comboBox.SelectedItem.ToString() == "Employee")
                    {
                        SqlCommand cmd = new SqlCommand(@"INSERT INTO [dbo].[Reg_Emp]
           ([id]
           ,[name]
           ,[gender]
           ,[dob]
           ,[nid]
           ,[mobile]
           ,[email]
           ,[image]
           ,[usertype])
     VALUES('" + rndnum + "','" + name.Text + "','" + Gender_comboBox1.Text + "','" + DOB.Value + "','" + NIDN.Text + "','" + Mob.Text + "','" + Email.Text + "',@image,'" + Catagory_comboBox.Text +"')", con);
                        SqlCommand cmd1 = new SqlCommand(@"INSERT INTO [dbo].[login]
           ([email]
           ,[pass]
           ,[id]
           ,[usertype])
     VALUES('" + Email.Text + "','" + Pass.Text + "','" + rndnum + "','" + Catagory_comboBox.Text + "')", con);
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

                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please complete all the fildes", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Home_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePage hp = new HomePage();   
            hp.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Pic_pictureBox2_Click(object sender, EventArgs e)
        {
            /*OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Select photo";
            ofd.Filter = "Image file(*.png;*jpeg;*jpg;*bmp) | *.png;*jpeg;*jpg;*bmp";
            //ofd.ShowDialog();
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                Pic_pictureBox2.Image = new Bitmap(ofd.FileName);
            }*/

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Select image";
            ofd.Filter = "Image file(All files) *.*|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                imgloc = ofd.FileName.ToString();
                Pic_pictureBox2.ImageLocation = imgloc;
            }
        }

        /*private object Sphoto()
        {
                MemoryStream ms = new MemoryStream();
                Pic_pictureBox2.Image.Save(ms, Pic_pictureBox2.Image.RawFormat);
                return ms.GetBuffer();    
        }*/

        private void Catagory_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Catagory_comboBox.SelectedItem.ToString() == "Customer")
            {
                panel_cus.Visible = true;
            }
            else
            { panel_cus.Visible = false;}
        }
    }
}
