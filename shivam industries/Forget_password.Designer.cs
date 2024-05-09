
namespace shivam_industries
{
    partial class Forget_password
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Forget_password));
            this.textb_new_password = new System.Windows.Forms.TextBox();
            this.textb_re_password = new System.Windows.Forms.TextBox();
            this.textb_start_year = new System.Windows.Forms.TextBox();
            this.bt_change = new System.Windows.Forms.Button();
            this.bt_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textb_new_password
            // 
            this.textb_new_password.BackColor = System.Drawing.Color.DodgerBlue;
            this.textb_new_password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textb_new_password.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textb_new_password.Location = new System.Drawing.Point(170, 108);
            this.textb_new_password.Name = "textb_new_password";
            this.textb_new_password.PlaceholderText = " New Password";
            this.textb_new_password.Size = new System.Drawing.Size(214, 32);
            this.textb_new_password.TabIndex = 0;
            this.textb_new_password.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textb_re_password
            // 
            this.textb_re_password.BackColor = System.Drawing.Color.DodgerBlue;
            this.textb_re_password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textb_re_password.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textb_re_password.Location = new System.Drawing.Point(170, 170);
            this.textb_re_password.Name = "textb_re_password";
            this.textb_re_password.PlaceholderText = "Re-enter Password";
            this.textb_re_password.Size = new System.Drawing.Size(214, 32);
            this.textb_re_password.TabIndex = 1;
            // 
            // textb_start_year
            // 
            this.textb_start_year.BackColor = System.Drawing.Color.DodgerBlue;
            this.textb_start_year.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textb_start_year.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textb_start_year.Location = new System.Drawing.Point(170, 232);
            this.textb_start_year.Name = "textb_start_year";
            this.textb_start_year.PlaceholderText = "      Start Year";
            this.textb_start_year.Size = new System.Drawing.Size(221, 32);
            this.textb_start_year.TabIndex = 2;
            // 
            // bt_change
            // 
            this.bt_change.BackColor = System.Drawing.Color.DodgerBlue;
            this.bt_change.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_change.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_change.Location = new System.Drawing.Point(106, 314);
            this.bt_change.Name = "bt_change";
            this.bt_change.Size = new System.Drawing.Size(112, 50);
            this.bt_change.TabIndex = 3;
            this.bt_change.Text = "Change";
            this.bt_change.UseVisualStyleBackColor = false;
            this.bt_change.Click += new System.EventHandler(this.bt_change_Click);
            // 
            // bt_cancel
            // 
            this.bt_cancel.BackColor = System.Drawing.Color.DodgerBlue;
            this.bt_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_cancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_cancel.Location = new System.Drawing.Point(330, 314);
            this.bt_cancel.Name = "bt_cancel";
            this.bt_cancel.Size = new System.Drawing.Size(112, 50);
            this.bt_cancel.TabIndex = 4;
            this.bt_cancel.Text = "Cancel";
            this.bt_cancel.UseVisualStyleBackColor = false;
            this.bt_cancel.Click += new System.EventHandler(this.bt_cancel_Click);
            // 
            // Forget_password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(567, 528);
            this.Controls.Add(this.bt_cancel);
            this.Controls.Add(this.bt_change);
            this.Controls.Add(this.textb_start_year);
            this.Controls.Add(this.textb_re_password);
            this.Controls.Add(this.textb_new_password);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Forget_password";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Forget_password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textb_new_password;
        private System.Windows.Forms.TextBox textb_re_password;
        private System.Windows.Forms.TextBox textb_start_year;
        private System.Windows.Forms.Button bt_change;
        private System.Windows.Forms.Button bt_cancel;
    }
}