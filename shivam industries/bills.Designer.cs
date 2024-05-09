
namespace shivam_industries
{
    partial class bills
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textb_cust_name = new System.Windows.Forms.TextBox();
            this.bt_all_bills = new System.Windows.Forms.Button();
            this.bt_search = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bt_clear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(228, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(413, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search Customer And Their Bills";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(164, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Customer Name";
            // 
            // textb_cust_name
            // 
            this.textb_cust_name.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textb_cust_name.Location = new System.Drawing.Point(439, 127);
            this.textb_cust_name.Name = "textb_cust_name";
            this.textb_cust_name.Size = new System.Drawing.Size(248, 37);
            this.textb_cust_name.TabIndex = 2;
            this.textb_cust_name.TextChanged += new System.EventHandler(this.textb_cust_name_TextChanged);
            // 
            // bt_all_bills
            // 
            this.bt_all_bills.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_all_bills.ForeColor = System.Drawing.Color.Red;
            this.bt_all_bills.Location = new System.Drawing.Point(164, 204);
            this.bt_all_bills.Name = "bt_all_bills";
            this.bt_all_bills.Size = new System.Drawing.Size(160, 54);
            this.bt_all_bills.TabIndex = 3;
            this.bt_all_bills.Text = "All BIlls";
            this.bt_all_bills.UseVisualStyleBackColor = true;
            this.bt_all_bills.Click += new System.EventHandler(this.bt_all_bills_Click);
            // 
            // bt_search
            // 
            this.bt_search.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_search.Location = new System.Drawing.Point(419, 204);
            this.bt_search.Name = "bt_search";
            this.bt_search.Size = new System.Drawing.Size(160, 54);
            this.bt_search.TabIndex = 4;
            this.bt_search.Text = "Search";
            this.bt_search.UseVisualStyleBackColor = true;
            this.bt_search.Click += new System.EventHandler(this.bt_search_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(51, 299);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(772, 475);
            this.dataGridView1.TabIndex = 5;
            // 
            // bt_clear
            // 
            this.bt_clear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_clear.Location = new System.Drawing.Point(641, 204);
            this.bt_clear.Name = "bt_clear";
            this.bt_clear.Size = new System.Drawing.Size(160, 54);
            this.bt_clear.TabIndex = 6;
            this.bt_clear.Text = "Clear";
            this.bt_clear.UseVisualStyleBackColor = true;
            this.bt_clear.Click += new System.EventHandler(this.bt_clear_Click);
            // 
            // bills
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.Controls.Add(this.bt_clear);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bt_search);
            this.Controls.Add(this.bt_all_bills);
            this.Controls.Add(this.textb_cust_name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "bills";
            this.Size = new System.Drawing.Size(901, 830);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textb_cust_name;
        private System.Windows.Forms.Button bt_all_bills;
        private System.Windows.Forms.Button bt_search;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bt_clear;
    }
}
