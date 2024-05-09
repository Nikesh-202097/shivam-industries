
namespace shivam_industries
{
    partial class new_entry
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textb_name = new System.Windows.Forms.TextBox();
            this.textb_no_packets = new System.Windows.Forms.TextBox();
            this.textb_type = new System.Windows.Forms.TextBox();
            this.textb_size = new System.Windows.Forms.TextBox();
            this.textb_price = new System.Windows.Forms.TextBox();
            this.bt_save = new System.Windows.Forms.Button();
            this.bt_clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(242, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "NEW ENTRY";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(87, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(87, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 32);
            this.label3.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(87, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 32);
            this.label4.TabIndex = 3;
            this.label4.Text = "Size";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(87, 316);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 32);
            this.label5.TabIndex = 4;
            this.label5.Text = "No_Packets";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(87, 380);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 32);
            this.label6.TabIndex = 5;
            this.label6.Text = "Price";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(93, 260);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 32);
            this.label7.TabIndex = 6;
            this.label7.Text = "Type";
            // 
            // textb_name
            // 
            this.textb_name.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textb_name.Location = new System.Drawing.Point(314, 128);
            this.textb_name.Name = "textb_name";
            this.textb_name.Size = new System.Drawing.Size(336, 39);
            this.textb_name.TabIndex = 7;
            this.textb_name.TextChanged += new System.EventHandler(this.textb_name_TextChanged);
            // 
            // textb_no_packets
            // 
            this.textb_no_packets.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textb_no_packets.Location = new System.Drawing.Point(314, 316);
            this.textb_no_packets.Name = "textb_no_packets";
            this.textb_no_packets.Size = new System.Drawing.Size(336, 39);
            this.textb_no_packets.TabIndex = 8;
            this.textb_no_packets.TextChanged += new System.EventHandler(this.textb_no_packets_TextChanged);
            // 
            // textb_type
            // 
            this.textb_type.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textb_type.Location = new System.Drawing.Point(314, 260);
            this.textb_type.Name = "textb_type";
            this.textb_type.Size = new System.Drawing.Size(336, 39);
            this.textb_type.TabIndex = 9;
            this.textb_type.TextChanged += new System.EventHandler(this.textb_type_TextChanged);
            // 
            // textb_size
            // 
            this.textb_size.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textb_size.Location = new System.Drawing.Point(314, 191);
            this.textb_size.Name = "textb_size";
            this.textb_size.Size = new System.Drawing.Size(336, 39);
            this.textb_size.TabIndex = 10;
            this.textb_size.TextChanged += new System.EventHandler(this.textb_size_TextChanged);
            // 
            // textb_price
            // 
            this.textb_price.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textb_price.Location = new System.Drawing.Point(314, 380);
            this.textb_price.Name = "textb_price";
            this.textb_price.Size = new System.Drawing.Size(336, 39);
            this.textb_price.TabIndex = 11;
            this.textb_price.TextChanged += new System.EventHandler(this.textb_price_TextChanged);
            // 
            // bt_save
            // 
            this.bt_save.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.bt_save.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_save.Location = new System.Drawing.Point(164, 483);
            this.bt_save.Name = "bt_save";
            this.bt_save.Size = new System.Drawing.Size(138, 53);
            this.bt_save.TabIndex = 12;
            this.bt_save.Text = "Save";
            this.bt_save.UseVisualStyleBackColor = false;
            this.bt_save.Click += new System.EventHandler(this.bt_save_Click);
            // 
            // bt_clear
            // 
            this.bt_clear.BackColor = System.Drawing.Color.White;
            this.bt_clear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_clear.Location = new System.Drawing.Point(407, 483);
            this.bt_clear.Name = "bt_clear";
            this.bt_clear.Size = new System.Drawing.Size(138, 53);
            this.bt_clear.TabIndex = 13;
            this.bt_clear.Text = "Clear";
            this.bt_clear.UseVisualStyleBackColor = false;
            this.bt_clear.Click += new System.EventHandler(this.bt_clear_Click);
            // 
            // new_entry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.Controls.Add(this.bt_clear);
            this.Controls.Add(this.bt_save);
            this.Controls.Add(this.textb_price);
            this.Controls.Add(this.textb_size);
            this.Controls.Add(this.textb_type);
            this.Controls.Add(this.textb_no_packets);
            this.Controls.Add(this.textb_name);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "new_entry";
            this.Size = new System.Drawing.Size(768, 840);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textb_name;
        private System.Windows.Forms.TextBox textb_no_packets;
        private System.Windows.Forms.TextBox textb_type;
        private System.Windows.Forms.TextBox textb_size;
        private System.Windows.Forms.TextBox textb_price;
        private System.Windows.Forms.Button bt_save;
        private System.Windows.Forms.Button bt_clear;
    }
}
