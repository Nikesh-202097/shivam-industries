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
    public partial class new_user : Form
    {
        public new_user()
        {
            InitializeComponent();
        }

        private void bt_register_Click(object sender, EventArgs e)
        {

            if (textb_user_name.Text == "")
            {
                MessageBox.Show(" user name should not empty ", " Warning ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (textb_passwd.Text == "")
            {
                MessageBox.Show(" passward should not empty ", " Warning ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (textb_start_date.Text == "")
            {
                MessageBox.Show(" start date should not empty ", " Warning ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string connectionstring = System.Configuration.ConfigurationManager.ConnectionStrings["connString"].ConnectionString;

                string query1 = "insert into users(users_name,users_password,start_date) values ('" + textb_user_name.Text + "','" + textb_passwd.Text + "','" + textb_start_date.Text + "');";

                SqlConnection con = new SqlConnection(connectionstring);
                con.Open();

                SqlCommand cmd = new SqlCommand(query1, con);

                cmd.ExecuteNonQuery();

                con.Close();
                MessageBox.Show(" new user registed successfully "," information ", MessageBoxButtons.OK,MessageBoxIcon.Information);
                this.Close();
            }
            
        }

        private void bt_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
