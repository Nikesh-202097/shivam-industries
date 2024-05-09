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
using iTextSharp.text.pdf;
using iTextSharp.text;

using System.IO;


namespace shivam_industries
{
    public partial class search_entry : UserControl
    {
        public search_entry()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bt_complete_Click(object sender, EventArgs e)
        {
            //string connectionstring = "Data Source=DESKTOP-1UQDQTR\SQLEXPRESS;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=False;TrustServerCertificate=False";
            string connectionstring =System.Configuration.ConfigurationManager.ConnectionStrings["connString"].ConnectionString;

            SqlConnection con = new SqlConnection(connectionstring);
            con.Open();
            string query = "select * from items;";

            SqlCommand cmd = new SqlCommand(query, con);

            var reader =cmd.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(reader);

            dataGridView1.DataSource = table;

            con.Close();

            
        }

        private void bt_savepdf1_Click(object sender, EventArgs e)
        {

            
            if (dataGridView1.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "PDF (*.pdf)|*.pdf";
                sfd.FileName = "Output.pdf";
                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("It wasn't possible to write the data to the disk." + ex.Message);
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {
                            PdfPTable pdfTable = new PdfPTable(dataGridView1.Columns.Count);
                            pdfTable.DefaultCell.Padding = 3;
                            pdfTable.WidthPercentage = 100;
                            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;

                            foreach (DataGridViewColumn column in dataGridView1.Columns)
                            {
                                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                                pdfTable.AddCell(cell);
                            }

                            foreach (DataGridViewRow row in dataGridView1.Rows)
                            {
                                foreach (DataGridViewCell cell in row.Cells)
                                {
                                    pdfTable.AddCell(cell.Value.ToString());
                                }
                            }

                            using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                            {
                                Document pdfDoc = new Document(PageSize.A4, 10f, 20f, 20f, 10f);
                                PdfWriter.GetInstance(pdfDoc, stream);
                                pdfDoc.Open();
                                pdfDoc.Add(pdfTable);
                                pdfDoc.Close();
                                stream.Close();
                            }

                            MessageBox.Show("Data save as pdf  Successfully !!!", "Info");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error :" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No Record To Export !!!", "Info");
            }

        }

        private void bt_search_Click(object sender, EventArgs e)
        {
            string query = "";
            try 
            {

                if (Convert.ToString(comboBox1.SelectedItem) == "Name")
                {
                    query = "select * from items where item_name='" + textb_combo.Text + "' ;";

                }
                if (Convert.ToString(comboBox1.SelectedItem) == "Size")
                {
                    query = " select * from items where item_size = '" + textb_combo.Text + "';";

                }
                if (Convert.ToString(comboBox1.SelectedItem) == "Type")
                {
                    query = " select * from items where item_type = '" + textb_combo.Text + "';";

                }
               
                string connectionstring = System.Configuration.ConfigurationManager.ConnectionStrings["connString"].ConnectionString;

                SqlConnection con = new SqlConnection(connectionstring);
                con.Open();

                SqlCommand cmd = new SqlCommand(query, con);

                var reader = cmd.ExecuteReader();
                DataTable table = new DataTable();
                table.Load(reader);

                dataGridView1.DataSource = table;

                con.Close(); 
            }


            catch(Exception ex)
            {
                MessageBox.Show("please enter a already store name or size or type  " + ex.Message);
            }

            
        }

        private void bt_savepdf2_Click(object sender, EventArgs e)
        {
            
            if (dataGridView1.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "PDF (*.pdf)|*.pdf";
                sfd.FileName = "Output.pdf";
                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("It wasn't possible to write the data to the disk." + ex.Message);
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {
                            PdfPTable pdfTable = new PdfPTable(dataGridView1.Columns.Count);
                            pdfTable.DefaultCell.Padding = 3;
                            pdfTable.WidthPercentage = 100;
                            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;

                            foreach (DataGridViewColumn column in dataGridView1.Columns)
                            {
                                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                                pdfTable.AddCell(cell);
                            }

                            foreach (DataGridViewRow row in dataGridView1.Rows)
                            {
                                foreach (DataGridViewCell cell in row.Cells)
                                {
                                    pdfTable.AddCell(cell.Value.ToString());
                                }
                            }

                            using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                            {
                                Document pdfDoc = new Document(PageSize.A4, 10f, 20f, 20f, 10f);
                                PdfWriter.GetInstance(pdfDoc, stream);
                                pdfDoc.Open();
                                pdfDoc.Add(pdfTable);
                                pdfDoc.Close();
                                stream.Close();
                            }

                            MessageBox.Show("Data save as pdf  Successfully !!!", "Info");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error :" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No Record To Export !!!", "Info");
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void search_entry_Load(object sender, EventArgs e)
        {

        }
    }
}
