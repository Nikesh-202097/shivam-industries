
namespace shivam_industries
{
    partial class search_entry
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
            this.bt_complete = new System.Windows.Forms.Button();
            this.bt_savepdf1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.bt_search = new System.Windows.Forms.Button();
            this.bt_savepdf2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textb_combo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(257, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search entry";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(59, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Get complete list";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // bt_complete
            // 
            this.bt_complete.BackColor = System.Drawing.SystemColors.Control;
            this.bt_complete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_complete.Location = new System.Drawing.Point(304, 95);
            this.bt_complete.Name = "bt_complete";
            this.bt_complete.Size = new System.Drawing.Size(166, 45);
            this.bt_complete.TabIndex = 2;
            this.bt_complete.Text = "Complete";
            this.bt_complete.UseVisualStyleBackColor = false;
            this.bt_complete.Click += new System.EventHandler(this.bt_complete_Click);
            // 
            // bt_savepdf1
            // 
            this.bt_savepdf1.BackColor = System.Drawing.SystemColors.Control;
            this.bt_savepdf1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_savepdf1.Location = new System.Drawing.Point(508, 95);
            this.bt_savepdf1.Name = "bt_savepdf1";
            this.bt_savepdf1.Size = new System.Drawing.Size(166, 45);
            this.bt_savepdf1.TabIndex = 3;
            this.bt_savepdf1.Text = "Save as PDF";
            this.bt_savepdf1.UseVisualStyleBackColor = false;
            this.bt_savepdf1.Click += new System.EventHandler(this.bt_savepdf1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Name",
            "Size",
            "Type"});
            this.comboBox1.Location = new System.Drawing.Point(59, 188);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(182, 40);
            this.comboBox1.TabIndex = 4;
            // 
            // bt_search
            // 
            this.bt_search.BackColor = System.Drawing.SystemColors.Control;
            this.bt_search.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_search.Location = new System.Drawing.Point(459, 188);
            this.bt_search.Name = "bt_search";
            this.bt_search.Size = new System.Drawing.Size(166, 45);
            this.bt_search.TabIndex = 5;
            this.bt_search.Text = "Search";
            this.bt_search.UseVisualStyleBackColor = false;
            this.bt_search.Click += new System.EventHandler(this.bt_search_Click);
            // 
            // bt_savepdf2
            // 
            this.bt_savepdf2.BackColor = System.Drawing.SystemColors.Control;
            this.bt_savepdf2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_savepdf2.Location = new System.Drawing.Point(644, 188);
            this.bt_savepdf2.Name = "bt_savepdf2";
            this.bt_savepdf2.Size = new System.Drawing.Size(159, 45);
            this.bt_savepdf2.TabIndex = 6;
            this.bt_savepdf2.Text = "Save as PDF";
            this.bt_savepdf2.UseVisualStyleBackColor = false;
            this.bt_savepdf2.Click += new System.EventHandler(this.bt_savepdf2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(25, 270);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(798, 405);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // textb_combo
            // 
            this.textb_combo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textb_combo.Location = new System.Drawing.Point(273, 188);
            this.textb_combo.Name = "textb_combo";
            this.textb_combo.Size = new System.Drawing.Size(150, 39);
            this.textb_combo.TabIndex = 8;
            // 
            // search_entry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.Controls.Add(this.textb_combo);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bt_savepdf2);
            this.Controls.Add(this.bt_search);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.bt_savepdf1);
            this.Controls.Add(this.bt_complete);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "search_entry";
            this.Size = new System.Drawing.Size(891, 696);
            this.Load += new System.EventHandler(this.search_entry_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bt_complete;
        private System.Windows.Forms.Button bt_savepdf1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button bt_search;
        private System.Windows.Forms.Button bt_savepdf2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textb_combo;
    }
}
