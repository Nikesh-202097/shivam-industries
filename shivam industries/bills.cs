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
    public partial class bills : UserControl
    {
        public bills()
        {
            InitializeComponent();
        }

        private void textb_cust_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void bt_all_bills_Click(object sender, EventArgs e)
        {
            string connectionstring = System.Configuration.ConfigurationManager.ConnectionStrings["connString"].ConnectionString;

            string query = "select cust_name,cust_address,cust_mob_no,cust_date,cust_total,cust_arrears,pur_item_name,pur_item_size,pur_item_type,pur_item_no_packets,pur_item_price" +
                           " from customers,purchase_items where cust_name = pur_cust_name and cust_date = pur_date  order by cust_date; ";

            SqlConnection con = new SqlConnection(connectionstring);
            con.Open();

            SqlCommand cmd = new SqlCommand(query, con);

            var reader = cmd.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(reader);

            dataGridView1.DataSource = table;

            con.Close();

        }

        private void bt_search_Click(object sender, EventArgs e)
        {
            string connectionstring = System.Configuration.ConfigurationManager.ConnectionStrings["connString"].ConnectionString;

            string query1 = "select cust_name,cust_address,cust_mob_no,cust_date,cust_total,cust_arrears,pur_item_name,pur_item_size,pur_item_type,pur_item_no_packets,pur_item_price" +
                           " from customers,purchase_items where (cust_name = '" + textb_cust_name.Text +"' and cust_name = pur_cust_name) and cust_date = pur_date  order by cust_date; ";

            SqlConnection con = new SqlConnection(connectionstring);
            con.Open();

            SqlCommand cmd = new SqlCommand(query1, con);

            var reader = cmd.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(reader);

            dataGridView1.DataSource = table;

            con.Close();

        }

        private void bt_clear_Click(object sender, EventArgs e)
        {
            textb_cust_name.Text = "";
            dataGridView1.DataSource = null;

        }
    }
}
