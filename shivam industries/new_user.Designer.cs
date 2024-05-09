
namespace shivam_industries
{
    partial class new_user
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(new_user));
            this.textb_user_name = new System.Windows.Forms.TextBox();
            this.textb_passwd = new System.Windows.Forms.TextBox();
            this.textb_start_date = new System.Windows.Forms.TextBox();
            this.bt_register = new System.Windows.Forms.Button();
            this.bt_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textb_user_name
            // 
            this.textb_user_name.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textb_user_name.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textb_user_name.Location = new System.Drawing.Point(169, 109);
            this.textb_user_name.Name = "textb_user_name";
            this.textb_user_name.PlaceholderText = "     User Name";
            this.textb_user_name.Size = new System.Drawing.Size(209, 39);
            this.textb_user_name.TabIndex = 0;
            // 
            // textb_passwd
            // 
            this.textb_passwd.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textb_passwd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textb_passwd.Location = new System.Drawing.Point(169, 192);
            this.textb_passwd.Name = "textb_passwd";
            this.textb_passwd.PlaceholderText = "      Passward";
            this.textb_passwd.Size = new System.Drawing.Size(209, 39);
            this.textb_passwd.TabIndex = 1;
            // 
            // textb_start_date
            // 
            this.textb_start_date.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.textb_start_date.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textb_start_date.Location = new System.Drawing.Point(169, 266);
            this.textb_start_date.Name = "textb_start_date";
            this.textb_start_date.PlaceholderText = "     Start Date";
            this.textb_start_date.Size = new System.Drawing.Size(209, 39);
            this.textb_start_date.TabIndex = 2;
            // 
            // bt_register
            // 
            this.bt_register.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.bt_register.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_register.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_register.Location = new System.Drawing.Point(111, 353);
            this.bt_register.Name = "bt_register";
            this.bt_register.Size = new System.Drawing.Size(112, 48);
            this.bt_register.TabIndex = 3;
            this.bt_register.Text = "Register";
            this.bt_register.UseVisualStyleBackColor = false;
            this.bt_register.Click += new System.EventHandler(this.bt_register_Click);
            // 
            // bt_cancel
            // 
            this.bt_cancel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bt_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_cancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_cancel.Location = new System.Drawing.Point(324, 353);
            this.bt_cancel.Name = "bt_cancel";
            this.bt_cancel.Size = new System.Drawing.Size(112, 48);
            this.bt_cancel.TabIndex = 4;
            this.bt_cancel.Text = "Cancel";
            this.bt_cancel.UseVisualStyleBackColor = false;
            this.bt_cancel.Click += new System.EventHandler(this.bt_cancel_Click);
            // 
            // new_user
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(570, 581);
            this.Controls.Add(this.bt_cancel);
            this.Controls.Add(this.bt_register);
            this.Controls.Add(this.textb_start_date);
            this.Controls.Add(this.textb_passwd);
            this.Controls.Add(this.textb_user_name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "new_user";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "new_user";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textb_user_name;
        private System.Windows.Forms.TextBox textb_passwd;
        private System.Windows.Forms.TextBox textb_start_date;
        private System.Windows.Forms.Button bt_register;
        private System.Windows.Forms.Button bt_cancel;
    }
}