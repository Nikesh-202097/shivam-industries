using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace shivam_industries
{
    public partial class Sign_In : Form
    {
        private string username = "";
        private string password = "";
        private string start_date = "";
        public Sign_In()
        {
            InitializeComponent();
            // code to get user details from database
            string connectionstring = System.Configuration.ConfigurationManager.ConnectionStrings["connString"].ConnectionString;

            string query1 = "select * from users;  ";

            SqlConnection con = new SqlConnection(connectionstring);
            con.Open();

            SqlCommand cmd = new SqlCommand(query1, con);

            var reader = cmd.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(reader);

            username = table.Rows[0]["users_name"].ToString();
            password = table.Rows[0]["users_password"].ToString();
            start_date = table.Rows[0]["start_date"].ToString();


            con.Close();

        }

        public void set_password(string p)
        {
            string connectionstring = System.Configuration.ConfigurationManager.ConnectionStrings["connString"].ConnectionString;

            string query1 = " update users set users_password ='"+ p +"'  where users_name = '"+ username +"';";

            SqlConnection con = new SqlConnection(connectionstring);
            con.Open();

            SqlCommand cmd = new SqlCommand(query1, con);

            cmd.ExecuteNonQuery();

            con.Close();
        }

        public string get_password()
        {
            return (password);
        }

        public string get_start_date()
        {
            return start_date;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            if (textBox1.Text== username)
            {
                if (textBox2.Text == password)
                {
                    home1.Visible = true;

                }
                else
                {
                    MessageBox.Show(" incorrect password ","Error",MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

                }
            }
            else
            {
                MessageBox.Show(" incorrect username ", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode ==Keys.Enter)
            {
                textBox2.Focus();
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode== Keys.Enter)
            {
                bt_sign_in.Focus();
            }

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1.Text = username;

        }

        private void home1_Load(object sender, EventArgs e)
        {

        }

        private void Sign_in_Load(object sender, EventArgs e)
        {

        }

        private void bt_forget_password_Click(object sender, EventArgs e)
        {
            Forget_password fp = new Forget_password();
            this.AddOwnedForm(fp);
            fp.ShowDialog();
            
        }

        private void bt_new_user_Click(object sender, EventArgs e)
        {
            new_user nu = new new_user();
            this.AddOwnedForm(nu);
            nu.ShowDialog();
        }
    }
}
