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
using System.Configuration;



namespace shivam_industries
{
    public partial class new_entry : UserControl
    {
        public new_entry()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textb_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void textb_size_TextChanged(object sender, EventArgs e)
        {
            


        }

        private void textb_type_TextChanged(object sender, EventArgs e)
        {

        }

        private void textb_no_packets_TextChanged(object sender, EventArgs e)
        {

        }

        private void textb_price_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void bt_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (textb_name.Text == "")
                {
                    MessageBox.Show(" Please enter item name  ", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
                else if (textb_size.Text == "")
                {
                    MessageBox.Show(" Please enter item size  ", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
                else if (textb_type.Text == "")
                {
                    MessageBox.Show(" Please enter item type  ", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
                else if (textb_no_packets.Text == "")
                {
                    MessageBox.Show(" Please enter item no of packets  ", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

                }
                else if (textb_price.Text == "")
                {
                    MessageBox.Show(" Please enter item price  ", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

                }
                else if (!(int.TryParse(textb_no_packets.Text, out int n)))
                {
                    MessageBox.Show(" Please enter item no Of packets in numbers  ", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
                else if (!(int.TryParse(textb_price.Text, out int n1)))
                {
                    MessageBox.Show(" Please enter item price in numbers  ", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }

                else
                {
                    string connectionstring = System.Configuration.ConfigurationManager.ConnectionStrings["connString"].ConnectionString;


                    SqlConnection con = new SqlConnection(connectionstring);
                    con.Open();

                    string item_name = textb_name.Text;
                    string item_size = textb_size.Text;
                    string item_type = textb_type.Text;
                    int item_no_packets = Convert.ToInt32(textb_no_packets.Text);
                    int item_price = Convert.ToInt32(textb_price.Text);
                    string query = "insert into items(item_name,item_size,item_type,item_no_packets,item_price) values ('" + item_name + "','" + item_size + "','" + item_type + "'," + item_no_packets + "," + item_price + ");";
                    SqlCommand cmd = new SqlCommand(query, con);

                    cmd.ExecuteNonQuery();

                    con.Close();

                    MessageBox.Show(" item saved successfully ");


                    textb_name.Text = "";
                    textb_size.Text = "";
                    textb_type.Text = "";
                    textb_no_packets.Text = "";
                    textb_price.Text = "";

                }


            }
            catch(Exception)
            {
                MessageBox.Show(" please fill correct details ", "error",MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            

            


        }

        private void bt_clear_Click(object sender, EventArgs e)
        {
            textb_name.Text = "";
            textb_size.Text = "";
            textb_type.Text = "";
            textb_no_packets.Text = "";
            textb_price.Text = "";


        }
    }
}
