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
    public partial class Forget_password : Form
    {
        public Forget_password()
        {
            InitializeComponent();
            
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }

        private void bt_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_change_Click(object sender, EventArgs e)
        {
            Sign_In sgin = new Sign_In();
            if (textb_new_password.Text == textb_re_password.Text)
            {
                if(textb_start_year.Text==sgin.get_start_date())
                {
                    sgin.set_password(textb_re_password.Text);
                    MessageBox.Show(" password change successfully ,  please restart software again ", "Done", MessageBoxButtons.OK, MessageBoxIcon.None);
                    this.Close();

                }
                else
                {
                    MessageBox.Show(" start year doesn't match ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(" new password and re-enter password are not same ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
