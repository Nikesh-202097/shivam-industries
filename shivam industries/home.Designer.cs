
namespace shivam_industries
{
    partial class home
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.bt_bills = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bt_search_entry = new System.Windows.Forms.Button();
            this.bt_billing = new System.Windows.Forms.Button();
            this.bt_update_entry = new System.Windows.Forms.Button();
            this.bt_new_entry = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bills1 = new shivam_industries.bills();
            this.billing1 = new shivam_industries.billing();
            this.search_entry1 = new shivam_industries.search_entry();
            this.update_entry1 = new shivam_industries.update_entry();
            this.new_entry1 = new shivam_industries.new_entry();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.bt_bills);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.bt_search_entry);
            this.panel1.Controls.Add(this.bt_billing);
            this.panel1.Controls.Add(this.bt_update_entry);
            this.panel1.Controls.Add(this.bt_new_entry);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 1039);
            this.panel1.TabIndex = 0;
            // 
            // bt_bills
            // 
            this.bt_bills.BackColor = System.Drawing.Color.Honeydew;
            this.bt_bills.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CadetBlue;
            this.bt_bills.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CadetBlue;
            this.bt_bills.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_bills.Location = new System.Drawing.Point(26, 593);
            this.bt_bills.Name = "bt_bills";
            this.bt_bills.Size = new System.Drawing.Size(168, 48);
            this.bt_bills.TabIndex = 5;
            this.bt_bills.Text = "Bills";
            this.bt_bills.UseVisualStyleBackColor = false;
            this.bt_bills.Click += new System.EventHandler(this.bt_bills_Click);
            this.bt_bills.Enter += new System.EventHandler(this.bt_bills_Enter);
            this.bt_bills.Leave += new System.EventHandler(this.bt_bills_Leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::shivam_industries.Properties.Resources.OIP;
            this.pictureBox1.Location = new System.Drawing.Point(26, 58);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(168, 149);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // bt_search_entry
            // 
            this.bt_search_entry.BackColor = System.Drawing.Color.Honeydew;
            this.bt_search_entry.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CadetBlue;
            this.bt_search_entry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_search_entry.Location = new System.Drawing.Point(26, 429);
            this.bt_search_entry.Name = "bt_search_entry";
            this.bt_search_entry.Size = new System.Drawing.Size(168, 55);
            this.bt_search_entry.TabIndex = 4;
            this.bt_search_entry.Text = "Search Entry";
            this.bt_search_entry.UseVisualStyleBackColor = false;
            this.bt_search_entry.Click += new System.EventHandler(this.bt_search_entry_Click);
            this.bt_search_entry.Enter += new System.EventHandler(this.bt_search_entry_Enter);
            this.bt_search_entry.Leave += new System.EventHandler(this.bt_search_entry_Leave);
            // 
            // bt_billing
            // 
            this.bt_billing.BackColor = System.Drawing.Color.Honeydew;
            this.bt_billing.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CadetBlue;
            this.bt_billing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_billing.Location = new System.Drawing.Point(26, 516);
            this.bt_billing.Name = "bt_billing";
            this.bt_billing.Size = new System.Drawing.Size(168, 49);
            this.bt_billing.TabIndex = 3;
            this.bt_billing.Text = "Billing";
            this.bt_billing.UseVisualStyleBackColor = false;
            this.bt_billing.Click += new System.EventHandler(this.bt_billing_Click);
            this.bt_billing.Enter += new System.EventHandler(this.bt_billing_Enter);
            this.bt_billing.Leave += new System.EventHandler(this.bt_billing_Leave);
            // 
            // bt_update_entry
            // 
            this.bt_update_entry.BackColor = System.Drawing.Color.Honeydew;
            this.bt_update_entry.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CadetBlue;
            this.bt_update_entry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_update_entry.Location = new System.Drawing.Point(26, 343);
            this.bt_update_entry.Name = "bt_update_entry";
            this.bt_update_entry.Size = new System.Drawing.Size(168, 53);
            this.bt_update_entry.TabIndex = 2;
            this.bt_update_entry.Text = "Update Entry";
            this.bt_update_entry.UseVisualStyleBackColor = false;
            this.bt_update_entry.Click += new System.EventHandler(this.bt_update_entry_Click);
            this.bt_update_entry.Enter += new System.EventHandler(this.bt_update_entry_Enter);
            this.bt_update_entry.Leave += new System.EventHandler(this.bt_update_entry_Leave);
            // 
            // bt_new_entry
            // 
            this.bt_new_entry.BackColor = System.Drawing.Color.Honeydew;
            this.bt_new_entry.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CadetBlue;
            this.bt_new_entry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_new_entry.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_new_entry.Location = new System.Drawing.Point(26, 257);
            this.bt_new_entry.Name = "bt_new_entry";
            this.bt_new_entry.Size = new System.Drawing.Size(168, 49);
            this.bt_new_entry.TabIndex = 1;
            this.bt_new_entry.Text = "New  Entry";
            this.bt_new_entry.UseVisualStyleBackColor = false;
            this.bt_new_entry.Click += new System.EventHandler(this.bt_home_Click);
            this.bt_new_entry.Enter += new System.EventHandler(this.bt_new_entry_Enter);
            this.bt_new_entry.Leave += new System.EventHandler(this.bt_new_entry_Leave);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1104, 52);
            this.panel3.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(528, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "SHIVAM INDUSTRIES";
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::shivam_industries.Properties.Resources.OIP;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.bills1);
            this.panel2.Controls.Add(this.billing1);
            this.panel2.Controls.Add(this.search_entry1);
            this.panel2.Controls.Add(this.update_entry1);
            this.panel2.Controls.Add(this.new_entry1);
            this.panel2.Location = new System.Drawing.Point(213, 44);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(901, 991);
            this.panel2.TabIndex = 2;
            // 
            // bills1
            // 
            this.bills1.BackColor = System.Drawing.Color.Honeydew;
            this.bills1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bills1.Location = new System.Drawing.Point(0, 0);
            this.bills1.Name = "bills1";
            this.bills1.Size = new System.Drawing.Size(901, 991);
            this.bills1.TabIndex = 6;
            this.bills1.Visible = false;
            // 
            // billing1
            // 
            this.billing1.BackColor = System.Drawing.Color.Honeydew;
            this.billing1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.billing1.Location = new System.Drawing.Point(0, 0);
            this.billing1.Name = "billing1";
            this.billing1.Size = new System.Drawing.Size(901, 991);
            this.billing1.TabIndex = 1;
            this.billing1.Visible = false;
            this.billing1.Load += new System.EventHandler(this.billing1_Load);
            // 
            // search_entry1
            // 
            this.search_entry1.BackColor = System.Drawing.Color.Honeydew;
            this.search_entry1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.search_entry1.Location = new System.Drawing.Point(0, 0);
            this.search_entry1.Name = "search_entry1";
            this.search_entry1.Size = new System.Drawing.Size(901, 991);
            this.search_entry1.TabIndex = 2;
            this.search_entry1.Visible = false;
            // 
            // update_entry1
            // 
            this.update_entry1.BackColor = System.Drawing.Color.Honeydew;
            this.update_entry1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.update_entry1.Location = new System.Drawing.Point(0, 0);
            this.update_entry1.Name = "update_entry1";
            this.update_entry1.Size = new System.Drawing.Size(901, 991);
            this.update_entry1.TabIndex = 1;
            this.update_entry1.Visible = false;
            // 
            // new_entry1
            // 
            this.new_entry1.BackColor = System.Drawing.Color.Honeydew;
            this.new_entry1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.new_entry1.Location = new System.Drawing.Point(0, 0);
            this.new_entry1.Name = "new_entry1";
            this.new_entry1.Size = new System.Drawing.Size(901, 991);
            this.new_entry1.TabIndex = 0;
            this.new_entry1.Visible = false;
            // 
            // home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "home";
            this.Size = new System.Drawing.Size(1104, 1039);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
    
        private System.Windows.Forms.Button bt_bills;
        private System.Windows.Forms.Button bt_search_entry;
        private System.Windows.Forms.Button bt_billing;
        private System.Windows.Forms.Button bt_update_entry;
        private System.Windows.Forms.Button bt_home;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bt_new_entry;
        private System.Windows.Forms.Panel panel2;
        private new_entry new_entry1;
        private update_entry update_entry1;
        private search_entry search_entry1;
        private billing billing1;
        private bills bills1;
    }
}
