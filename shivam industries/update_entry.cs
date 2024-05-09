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
    public partial class update_entry : UserControl
    {
        public update_entry()
        {
            InitializeComponent();
        }

        private void textb_name_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void textB_combo_TextChanged(object sender, EventArgs e)
        {

        }

        private void bt_update_Click(object sender, EventArgs e)
        {
            try
            {




                string query = "";
                if (Convert.ToString(comboBox1.SelectedItem) == "Size")
                {
                    query = " update items set item_size = '" + textB_combo.Text + "' where item_name = '" + textb_name.Text + "';";

                }
                if (Convert.ToString(comboBox1.SelectedItem) == "Type")
                {
                    query = " update items set item_type = '" + textB_combo.Text + "' where item_name = '" + textb_name.Text + "';";

                }
                if (Convert.ToString(comboBox1.SelectedItem) == "No of packets")
                {
                    query = " update items set item_no_packets = '" + Convert.ToInt32(textB_combo.Text) + "' where item_name = '" + textb_name.Text + "';";

                }
                if (Convert.ToString(comboBox1.SelectedItem) == "price")
                {
                    query = " update items set item_price = '" + Convert.ToInt32(textB_combo.Text) + "' where item_name = '" + textb_name.Text + "';";

                }

                string connectionstring = System.Configuration.ConfigurationManager.ConnectionStrings["connString"].ConnectionString;

                SqlConnection con = new SqlConnection(connectionstring);
                con.Open();
                String query1 = "select item_name from items where item_name = '" + textb_name.Text + "';";

                SqlCommand cmd = new SqlCommand(query1, con);

                var reader = cmd.ExecuteReader();
                DataTable table = new DataTable();
                table.Load(reader);
                string name = Convert.ToString(table.Rows[0]["item_name"]);

                if (name == textb_name.Text)
                {
                    MessageBox.Show(" Are you sure to DELETE that entry  ", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    
                    SqlCommand cmd1 = new SqlCommand(query, con);
                    cmd1.ExecuteNonQuery();
                    MessageBox.Show(" item has been updated successfully ");
                    textb_name.Text = "";
                    textB_combo.Text = "";
                    comboBox1.SelectedItem = null;
                }

               

                con.Close();

                

            }
            catch(Exception)
            {
                MessageBox.Show(" please enter correct detail ", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            



        }

        private void bt_delete_Click(object sender, EventArgs e)
        {
            try
            {
                

                string connectionstring = System.Configuration.ConfigurationManager.ConnectionStrings["connString"].ConnectionString;

                SqlConnection con = new SqlConnection(connectionstring);
                con.Open();
                String query1 = "select item_name from items where item_name = '" + textb_name.Text + "';";
                
                SqlCommand cmd = new SqlCommand(query1, con);

                var reader = cmd.ExecuteReader();
                DataTable table = new DataTable();
                table.Load(reader);
                string name = Convert.ToString(table.Rows[0]["item_name"]);

                if(name==textb_name.Text)
                {
                    MessageBox.Show(" Are you sure to DELETE that entry  ", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    string query = "delete from items where item_name = '" + textb_name.Text + "';";
                    SqlCommand cmd1 = new SqlCommand(query, con);
                    cmd1.ExecuteNonQuery();
                    MessageBox.Show(" item has been deleted successfully ");
                    textb_name.Text = "";
                    textB_combo.Text = "";
                    comboBox1.SelectedItem = null;
                }
                else
                {
                    MessageBox.Show(" item does not found please enter correct name ", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

                


                con.Close();



            }
            catch(Exception)
            {
                MessageBox.Show(" please enter correct detail ", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
           

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if(comboBox1.SelectedItem == null)
            {
                MessageBox.Show(" select what you want to update ", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void update_entry_Load(object sender, EventArgs e)
        {

        }
    }
}
