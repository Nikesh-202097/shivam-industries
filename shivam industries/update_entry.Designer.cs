
namespace shivam_industries
{
    partial class update_entry
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
            this.label3 = new System.Windows.Forms.Label();
            this.textb_name = new System.Windows.Forms.TextBox();
            this.textB_combo = new System.Windows.Forms.TextBox();
            this.bt_update = new System.Windows.Forms.Button();
            this.bt_delete = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(242, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "UPDATE ENTRY";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(58, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "NAME";
            // 
            // textb_name
            // 
            this.textb_name.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textb_name.Location = new System.Drawing.Point(339, 174);
            this.textb_name.Name = "textb_name";
            this.textb_name.Size = new System.Drawing.Size(328, 39);
            this.textb_name.TabIndex = 4;
            this.textb_name.TextChanged += new System.EventHandler(this.textb_name_TextChanged);
            // 
            // textB_combo
            // 
            this.textB_combo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textB_combo.Location = new System.Drawing.Point(339, 296);
            this.textB_combo.Name = "textB_combo";
            this.textB_combo.Size = new System.Drawing.Size(328, 39);
            this.textB_combo.TabIndex = 5;
            this.textB_combo.TextChanged += new System.EventHandler(this.textB_combo_TextChanged);
            // 
            // bt_update
            // 
            this.bt_update.BackColor = System.Drawing.SystemColors.Control;
            this.bt_update.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_update.Location = new System.Drawing.Point(375, 449);
            this.bt_update.Name = "bt_update";
            this.bt_update.Size = new System.Drawing.Size(160, 59);
            this.bt_update.TabIndex = 6;
            this.bt_update.Text = "Update";
            this.bt_update.UseVisualStyleBackColor = false;
            this.bt_update.Click += new System.EventHandler(this.bt_update_Click);
            // 
            // bt_delete
            // 
            this.bt_delete.BackColor = System.Drawing.Color.Red;
            this.bt_delete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_delete.Location = new System.Drawing.Point(83, 449);
            this.bt_delete.Name = "bt_delete";
            this.bt_delete.Size = new System.Drawing.Size(157, 59);
            this.bt_delete.TabIndex = 7;
            this.bt_delete.Text = "Delete";
            this.bt_delete.UseVisualStyleBackColor = false;
            this.bt_delete.Click += new System.EventHandler(this.bt_delete_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Size",
            "Type",
            "No of packets",
            "Price"});
            this.comboBox1.Location = new System.Drawing.Point(58, 296);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(182, 40);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // update_entry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.bt_delete);
            this.Controls.Add(this.bt_update);
            this.Controls.Add(this.textB_combo);
            this.Controls.Add(this.textb_name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "update_entry";
            this.Size = new System.Drawing.Size(782, 869);
            this.Load += new System.EventHandler(this.update_entry_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textb_name;
        private System.Windows.Forms.TextBox textB_combo;
        private System.Windows.Forms.Button bt_update;
        private System.Windows.Forms.Button bt_delete;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}
