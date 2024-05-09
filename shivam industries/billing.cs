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
    public partial class billing : UserControl
    {
        // create some globle variable

        int qty_available=0;
        DataTable table_add = new DataTable();
        int sub_total = 0;
        double total = 0;
        int sr_no = 1;
        // variable used in the textb_gst_igst_TextChanged function  to overcome multiple click
        double temp = 0;

        // variables used in printdoccument1_printpage function
        int y_cord = 0;
        int curr_page=1;
        int count = 0;
        int page_count = 1;

        // variables used in bt_save_print function
        int no_bt_click=1;
        double pre_arrears = 0;
        

        public billing()
        {
            InitializeComponent();
            // add colums to table for datagridview
            table_add.Columns.Add("Sr.no.");
            table_add.Columns.Add("item name");
            table_add.Columns.Add("size");
            table_add.Columns.Add("type");
            table_add.Columns.Add("rate");
            table_add.Columns.Add("qty");
            table_add.Columns.Add("item total");
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void textb_name_TextChanged(object sender, EventArgs e)
        {

            // code for auto fetch the details of  item
            if(textb_name.Text=="")
            {
                textb_size.Text = "";
                textb_type.Text = "";
                textb_rate.Text = "";
                qty_available = 0;
            }
            try
            {
                // get connection string from app config.
                string connectionstring = System.Configuration.ConfigurationManager.ConnectionStrings["connString"].ConnectionString;
                
                // search by name
                string query = "select * from items where item_name='" + textb_name.Text + "' ;";
                SqlConnection con = new SqlConnection(connectionstring);
                con.Open();

                SqlCommand cmd = new SqlCommand(query, con);

                var reader = cmd.ExecuteReader();
                DataTable table = new DataTable();
                table.Load(reader);

                // paste size,rate,qty in relative textbox
                textb_size.Text = table.Rows[0]["item_size"].ToString();
                textb_type.Text = table.Rows[0]["item_type"].ToString();
                textb_rate.Text = table.Rows[0]["item_price"].ToString();
                qty_available = Convert.ToInt32(table.Rows[0]["item_no_packets"]);

            }
            catch(Exception)
            {
                // insert name is not exist in database blank all details 
                textb_size.Text = "";
                textb_type.Text = "";
                textb_rate.Text = "";
            }
        }

        private void bt_add_Click(object sender, EventArgs e)
        {
            // code to add item in data grid view

            try
            {
                //check purchasing quanty is less than available quantity, some other fields like name or size
                if (Convert.ToInt32(textb_qty.Text) > qty_available || textb_qty.Text == "")
                {

                    MessageBox.Show("quanty available is less or please enter qty ", "Error", MessageBoxButtons.OKCancel);

                }

                else if (textb_name.Text == "")
                {
                    MessageBox.Show("please enter item name ", "Error", MessageBoxButtons.OKCancel);

                }
                else if (textb_size.Text == "")
                {
                    MessageBox.Show("please enter item size ", "Error", MessageBoxButtons.OKCancel);

                }

                //check inserted purchasing quantity is an integer
                else if (!(int.TryParse(textb_qty.Text, out int n1)))
                {
                    MessageBox.Show(" Please enter qty in numbers  ", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
                

                else
                {
                    //create variables 
                    string item_name = textb_name.Text;
                    string size = textb_size.Text;
                    string type = textb_type.Text;
                    int rate = Convert.ToInt32(textb_rate.Text);
                    int qty = Convert.ToInt32(textb_qty.Text);
                    // item total is total cost of one type of item
                    int item_total = rate * qty;

                    // add row into table
                    table_add.Rows.Add(sr_no, item_name, size, type, rate, qty, item_total);

                    // add table to datagrideview
                    dataGridView1.DataSource = table_add;

                    // update subtotal
                    sub_total = sub_total + item_total;
                    total = total + sub_total;
                    textb_subtotal.Text = sub_total.ToString();
                    temp = sub_total;
                    // clear all entries
                    textb_size.Text = "";
                    textb_type.Text = "";
                    textb_rate.Text = "";
                    textb_qty.Text = "";

                    sr_no = sr_no + 1;
                    item_name = "";
                    size = "";
                    type = "";
                    rate = 0;
                    qty = 0;
                    item_total = 0;

                }

                // code for searching or get pre- arrears of the customer
                string connectionstring = System.Configuration.ConfigurationManager.ConnectionStrings["connString"].ConnectionString;

                // search by name and address or mobile no
                string query = "select cust_arrears from customers where cust_name='" + textb_customer_name.Text + "' and (cust_address='" + textb_address.Text + "' or cust_mob_no='" + textb_mobile_no.Text + "')  ;";
                SqlConnection con = new SqlConnection(connectionstring);
                con.Open();

                SqlCommand cmd = new SqlCommand(query, con);

                var reader = cmd.ExecuteReader();
                DataTable table = new DataTable();
                table.Load(reader);
                //no of rows in table is r
                int r = table.Rows.Count;

                if(r>0)
                {
                    pre_arrears = Convert.ToDouble(table.Rows[r - 1]["cust_arrears"]);
                    textb_pre_arrears.Text = pre_arrears.ToString();

                }
                


            }
            catch(Exception)
            {
                MessageBox.Show(" please enter the correct details", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

  

        }

        private void bt_save_print_Click(object sender, EventArgs e)
        {
            // code for save or print bill

            
                //check for some conditions
                if (textb_customer_name.Text == "")
                {
                    MessageBox.Show("please enter customer name ");
                }
                else if (textb_mobile_no.Text == "")
                {
                    MessageBox.Show("please enter customer mobile no");
                }
                else if (textb_address.Text == "")
                {
                    MessageBox.Show("please enter customer address");
                }
                else if (!(double.TryParse(textb_discount.Text, out double n2)))
                {
                    MessageBox.Show(" Please enter discount in numbers  ", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
                else if (!(double.TryParse(textb_gst_igst.Text, out double n3)))
                {
                    MessageBox.Show(" Please enter gst in numbers  ", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
                else if (!(double.TryParse(textb_total.Text, out double n4)))
                {
                    MessageBox.Show(" Please get total in numbers  ", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
                else if (!(double.TryParse(textb_paid_amount.Text, out double n5)))
                {
                    MessageBox.Show(" Please paid_amount in numbers  ", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
                else if (!(int.TryParse(textb_return_amount.Text, out int n6)))
                {
                    MessageBox.Show(" Please enter return amount in numbers  ", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
                else if (!(double.TryParse(textb_balance.Text, out double n7)))
                {
                    MessageBox.Show(" Please get arrears in numbers  ", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }

                else
                {
                    //add print document into preview dialog
                    printPreviewDialog1.Document = printDocument1;

                    //printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
                    printPreviewDialog1.ShowDialog();
                    if (printDialog1.ShowDialog() == DialogResult.OK)
                    {
                        printDocument1.Print();
                    }


                    //code for only at first click database is updated

                    if (no_bt_click == 1)
                    {
                        // update database after oder place
                        int no_rows = dataGridView1.RowCount;
                        string query = "";
                        string query1 = "";
                        int remain = 0;

                        string connectionstring = System.Configuration.ConfigurationManager.ConnectionStrings["connString"].ConnectionString;
                        SqlConnection con = new SqlConnection(connectionstring);
                        con.Open();

                        for (int i = 0; i < no_rows - 1; i++)
                        {
                            // query to get no of packets of item present
                            query1 = "select item_name,item_size,item_type,item_no_packets,item_price from items where item_name='" + dataGridView1.Rows[i].Cells[1].Value + "' ;";

                            SqlCommand cmd1 = new SqlCommand(query1, con);
                            var reader = cmd1.ExecuteReader();
                            DataTable table = new DataTable();
                            table.Load(reader);

                            // query to update
                            remain = Convert.ToInt32(table.Rows[0]["item_no_packets"]) - Convert.ToInt32(dataGridView1.Rows[i].Cells[5].Value);
                            query = " update items set item_no_packets = " + remain + " where item_name = '" + dataGridView1.Rows[i].Cells[1].Value + "';";



                            SqlCommand cmd = new SqlCommand(query, con);

                            cmd.ExecuteNonQuery();

                            // register purchase items details 
                            string query2= "insert into purchase_items(pur_cust_name,pur_date,pur_item_name,pur_item_size,pur_item_type,pur_item_no_packets,pur_item_price) values ('" + textb_customer_name.Text + "','" + dateTimePicker1.Value.ToString("MMM dd yyyy hh tt ") + "','" + table.Rows[0]["item_name"] + "','" + table.Rows[0]["item_size"] + "','" + table.Rows[0]["item_type"] + "','" + Convert.ToInt32(dataGridView1.Rows[i].Cells[5].Value) + "','" + Convert.ToInt32(table.Rows[0]["item_price"]) + "');";

                            SqlCommand cmd2 = new SqlCommand(query2, con);

                            cmd2.ExecuteNonQuery();
                        }

                        // register customer details 


                        string query3 = "insert into customers(cust_name,cust_mob_no,cust_address,cust_date,cust_total,cust_arrears) values ('" + textb_customer_name.Text + "','" + textb_mobile_no.Text + "','" + textb_address.Text + "','" + dateTimePicker1.Value.ToString("MMM dd yyyy hh tt ")  + "','" + textb_total.Text + "','"+ textb_balance.Text +"' );";

                        SqlCommand cmd3 = new SqlCommand(query3,con);

                        cmd3.ExecuteNonQuery();

                        con.Close();

                    }


                }

                no_bt_click += 1;

           

           

            
        }

        private void textb_discount_TextChanged(object sender, EventArgs e)
        {

            // code for dedect discount from total cost when discount inserted in %

           
                // create variable to store total to overcome multiple clicks
                double temp2 = sub_total;

                if (textb_discount.Text == "")
                {
                    total = 0;
                    total = temp2;
                    temp = total;
                    textb_total.Text = total.ToString();

                }
                else if (textb_discount.Text == "0")
                {
                    total = 0;
                    total = temp2;
                    temp = total;
                    textb_total.Text = total.ToString();
                }

                else
                {
                    total = 0;
                    total = temp2 - sub_total * Convert.ToDouble(textb_discount.Text) / 100;
                    temp2 = sub_total;
                    temp = total;
                    textb_total.Text = total.ToString();

                }

           
           

        }
        
        
        
        
        private void textb_gst_igst_TextChanged(object sender, EventArgs e)
        {

            // code for add gst of igst in total cost when it inserted in %
            if (textb_gst_igst.Text == "")
            {
                total = 0;
                total = temp;
                textb_total.Text = total.ToString();
            }
            else if (textb_gst_igst.Text == "0")
            {
                total = 0;
                total = temp;
                textb_total.Text = total.ToString();
            }
            else
            {

                // create variable to store total to overcome multiple clicks
                total = 0;
                total = temp + temp * Convert.ToDouble(textb_gst_igst.Text) / 100;
                textb_total.Text = total.ToString();

            }






        }

        private void textb_paid_amount_TextChanged(object sender, EventArgs e)
        {
            //code for update return amount when paid amount is inserted
            double arrears = 0;
           if (textb_paid_amount.Text != "")
           {
                textb_return_amount.Text = (Convert.ToInt32(textb_paid_amount.Text) - Convert.ToInt32(total)).ToString();
                arrears = Convert.ToDouble(textb_paid_amount.Text) - Convert.ToDouble(total);
            }

            

           if (textb_paid_amount.Text != "" &&  arrears<0)
           {
                textb_balance.Text = (-arrears).ToString();
                textb_return_amount.Text = "0";

           }
           else
            {
                textb_balance.Text = "0";
                //textb_return_amount.Text = (Convert.ToInt32(textb_paid_amount.Text) - Convert.ToInt32(total)).ToString();
            }
            

            
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e )
        {
            //code for what print in bill 

                
                curr_page = 1;
                count = 0;


                if (curr_page == 1)
                {
                    e.Graphics.DrawString(" SHIVAM INDUSTRIES ", new Font("Arial", 22, FontStyle.Bold), Brushes.Black, new Point(220, 10));
                    e.Graphics.DrawString(" NEAR BIJLI BOARD,ATELI MANDI ", new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(150, 50));
                    e.Graphics.DrawString(" M/GARH,HARYANA (123021) ", new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(180, 80));
                    e.Graphics.DrawString(" Phone No. : 9416747500  ", new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(195, 110));
                    e.Graphics.DrawString(" BILL ", new Font("Arial", 22, FontStyle.Bold), Brushes.Black, new Point(340, 140));
                    e.Graphics.DrawString(" Date : " + dateTimePicker1.Value + "", new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(10, 170));
                    e.Graphics.DrawLine(new Pen(Brushes.Black), new Point(0, 200), new Point(900, 200));
                    e.Graphics.DrawString(" Customer name : " + textb_customer_name.Text + "", new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(10, 210));
                    e.Graphics.DrawString(" Mobile no. : " + textb_mobile_no.Text + "", new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(490, 210));
                    e.Graphics.DrawString(" Address : " + textb_address.Text + "", new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(10, 240));
                    e.Graphics.DrawLine(new Pen(Brushes.Black), new Point(0, 270), new Point(900, 270));




                    e.Graphics.DrawString(" Sr. no. ", new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(10, 280));
                    e.Graphics.DrawString(" Item name ", new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(110, 280));
                    e.Graphics.DrawString(" Size ", new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(340, 280));
                    e.Graphics.DrawString(" Rate ", new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(440, 280));
                    e.Graphics.DrawString(" Qty. ", new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(540, 280));
                    e.Graphics.DrawString(" Item total ", new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(640, 280));

                    y_cord = 310;

                }




                //paste data from data grid view to print doccument
                int no_rows = dataGridView1.RowCount;


                while (count < no_rows - 1)
                {
                    if (y_cord >= 1100)
                    {
                        e.HasMorePages = true;
                        curr_page += 1;
                        y_cord = 10;
                        page_count += 1;
                       

                        
                    }
                    else
                    {
                        //e.HasMorePages = false;
                    }
                    e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(0, y_cord));
                    y_cord = y_cord + 20;
                    e.Graphics.DrawString(" " + dataGridView1.Rows[count].Cells[0].Value + " ", new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(20, y_cord));
                    e.Graphics.DrawString(" " + dataGridView1.Rows[count].Cells[1].Value + " ", new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(120, y_cord));
                    e.Graphics.DrawString(" " + dataGridView1.Rows[count].Cells[2].Value + " ", new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(360, y_cord));
                    e.Graphics.DrawString(" " + dataGridView1.Rows[count].Cells[4].Value + " ", new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(460, y_cord));
                    e.Graphics.DrawString(" " + dataGridView1.Rows[count].Cells[5].Value + " ", new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(560, y_cord));
                    e.Graphics.DrawString(" " + dataGridView1.Rows[count].Cells[6].Value + " ", new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(660, y_cord));

                    y_cord = y_cord + 30;

                    count += 1;

                }


                if (y_cord + 320 >= 1100)
                {
                    e.HasMorePages = true;
                    curr_page += 1;
                    y_cord = 10;
                    page_count += 1;
                    
                

                    
                }
                else
                {
                    e.HasMorePages = false;

                }




                // draw bold line
                e.Graphics.DrawLine(new Pen(Brushes.Black), new Point(0, y_cord), new Point(900, y_cord));

                e.Graphics.DrawString(" Sub Total : ", new Font("Arial", 18, FontStyle.Bold), Brushes.Black, new Point(420, y_cord + 40));
                e.Graphics.DrawString(" " + textb_subtotal.Text + " ", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(640, y_cord + 40));

                e.Graphics.DrawString(" Discount : ", new Font("Arial", 18, FontStyle.Bold), Brushes.Black, new Point(420, y_cord + 80));
                e.Graphics.DrawString(" " + textb_discount.Text + " % ", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(640, y_cord + 80));

                e.Graphics.DrawString(" Gst/Igst : ", new Font("Arial", 18, FontStyle.Bold), Brushes.Black, new Point(420, y_cord + 120));
                e.Graphics.DrawString(" " + textb_gst_igst.Text + " % ", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(640, y_cord + 120));

                e.Graphics.DrawString(" pre-arrears : ", new Font("Arial", 18, FontStyle.Bold), Brushes.Black, new Point(420, y_cord + 160));
                e.Graphics.DrawString(" " + textb_pre_arrears.Text + "  ", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(640, y_cord + 160));

                e.Graphics.DrawString(" Total : ", new Font("Arial", 18, FontStyle.Bold), Brushes.Black, new Point(420, y_cord + 200));
                e.Graphics.DrawString(" " + textb_total.Text + " ", new Font("Arial", 18, FontStyle.Bold), Brushes.Black, new Point(640, y_cord + 200));

                e.Graphics.DrawString(" Paid amount : ", new Font("Arial", 18, FontStyle.Bold), Brushes.Black, new Point(420, y_cord + 240));
                e.Graphics.DrawString(" " + textb_paid_amount.Text + " ", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(640, y_cord + 240));

                e.Graphics.DrawString(" Return amount : ", new Font("Arial", 18, FontStyle.Bold), Brushes.Black, new Point(420, y_cord + 280));
                e.Graphics.DrawString(" " + textb_return_amount.Text + " ", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(640, y_cord + 280));

                e.Graphics.DrawString(" Arrears : ", new Font("Arial", 18, FontStyle.Bold), Brushes.Black, new Point(420, y_cord + 320));
                e.Graphics.DrawString(" " + textb_balance.Text + " ", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(640, y_cord + 320));

                e.HasMorePages = false;
 






        }

        private void bt_clear_Click(object sender, EventArgs e)
        {
            //code for clear all variables or datagridview 

            qty_available = 0;
            table_add.Clear();
             
            sub_total = 0;
            total = 0;
            sr_no = 1;
  
            temp = 0;

           
            y_cord = 0;
            curr_page = 1;
            count = 0;

            
            no_bt_click = 1;
            pre_arrears = 0;
    

            textb_customer_name.Text = "";
            textb_mobile_no.Text = "";
            textb_address.Text = "";
            textb_discount.Text = "";
            textb_gst_igst.Text = "";
            textb_name.Text = "";
            textb_paid_amount.Text = "";
            textb_qty.Text = "";
            textb_rate.Text = "";
            textb_return_amount.Text = "";
            textb_size.Text = "";
            textb_subtotal.Text = "";
            textb_total.Text = "";
            textb_type.Text = "";
            dataGridView1.DataSource=null;
            textb_pre_arrears.Text = "";
            textb_balance.Text = "";


        }

        private void billing_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckStateChanged(object sender, EventArgs e)
        {
           
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
            if(checkBox1.Checked==true)
            {
                total = total + pre_arrears;
                textb_total.Text = total.ToString();

            }
            else
            {
                total = total - pre_arrears;
                textb_total.Text = total.ToString();
            }

        }

        private void printDocument1_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {

        }
    }
}
