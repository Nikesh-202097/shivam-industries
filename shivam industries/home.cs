using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shivam_industries
{
    public partial class home : UserControl
    {
        public home()
        {
            InitializeComponent();
        }
        // for home page 
        private void bt_home_Click(object sender, EventArgs e)
        {
            new_entry1.BringToFront();
            update_entry1.Visible = false;
            search_entry1.Visible = false;
            new_entry1.Visible= true;
            billing1.Visible = false;
            bills1.Visible = false;

        }

        // for update page
        private void bt_update_entry_Click(object sender, EventArgs e)
        {
            update_entry1.BringToFront();
            new_entry1.Visible = false;
            search_entry1.Visible = false;
            update_entry1.Visible = true;
            billing1.Visible = false;
            bills1.Visible = false;


        }

        // for billing page
        private void bt_billing_Click(object sender, EventArgs e)
        {
            billing1.BringToFront();
            billing1.Visible = true;
            new_entry1.Visible = false;
            search_entry1.Visible = false;
            update_entry1.Visible = false;
            bills1.Visible = false;

        }

        //for search entry page 
        private void bt_search_entry_Click(object sender, EventArgs e)
        {
            search_entry1.BringToFront();
            update_entry1.Visible = false;
            new_entry1.Visible = false;
            search_entry1.Visible = true;
            billing1.Visible = false;
            bills1.Visible = false;

        }

        // for bills page
        private void bt_bills_Click(object sender, EventArgs e)
        {
            bills1.BringToFront();
            update_entry1.Visible = false;
            new_entry1.Visible = false;
            search_entry1.Visible = false;
            billing1.Visible = false;
            bills1.Visible = true;
        }

        private void billing1_Load(object sender, EventArgs e)
        {



        }

        

        

        private void bt_new_entry_Enter(object sender, EventArgs e)
        {
            this.bt_new_entry.BackColor = Color.CadetBlue;

        }

        private void bt_new_entry_Leave(object sender, EventArgs e)
        {
            this.bt_new_entry.BackColor = Color.Honeydew;
        }

        private void bt_update_entry_Enter(object sender, EventArgs e)
        {
            this.bt_update_entry.BackColor = Color.CadetBlue;
        }

        private void bt_update_entry_Leave(object sender, EventArgs e)
        {
            this.bt_update_entry.BackColor = Color.Honeydew;
        }

        private void bt_billing_Enter(object sender, EventArgs e)
        {
            this.bt_billing.BackColor = Color.CadetBlue;
        }

        private void bt_billing_Leave(object sender, EventArgs e)
        {
            this.bt_billing.BackColor = Color.Honeydew;
        }

        private void bt_search_entry_Enter(object sender, EventArgs e)
        {
            this.bt_search_entry.BackColor = Color.CadetBlue;
        }

        private void bt_search_entry_Leave(object sender, EventArgs e)
        {
            this.bt_search_entry.BackColor = Color.Honeydew;
        }

        private void bt_bills_Enter(object sender, EventArgs e)
        {
            this.bt_bills.BackColor = Color.CadetBlue;
        }

        private void bt_bills_Leave(object sender, EventArgs e)
        {
            this.bt_bills.BackColor = Color.Honeydew;
        }
    }
}
