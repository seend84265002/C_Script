
namespace Ch2_3_3_1_WinAppDemo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Ib_Welcome = new System.Windows.Forms.Label();
            this.text_box = new System.Windows.Forms.TextBox();
            this.bt_login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Ib_Welcome
            // 
            this.Ib_Welcome.AutoSize = true;
            this.Ib_Welcome.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Ib_Welcome.Location = new System.Drawing.Point(259, 63);
            this.Ib_Welcome.Name = "Ib_Welcome";
            this.Ib_Welcome.Size = new System.Drawing.Size(52, 24);
            this.Ib_Welcome.TabIndex = 0;
            this.Ib_Welcome.Text = "歡迎:";
            // 
            // text_box
            // 
            this.text_box.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.text_box.Location = new System.Drawing.Point(45, 63);
            this.text_box.Multiline = true;
            this.text_box.Name = "text_box";
            this.text_box.Size = new System.Drawing.Size(182, 68);
            this.text_box.TabIndex = 1;
            // 
            // bt_login
            // 
            this.bt_login.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_login.Location = new System.Drawing.Point(45, 156);
            this.bt_login.Name = "bt_login";
            this.bt_login.Size = new System.Drawing.Size(182, 83);
            this.bt_login.TabIndex = 2;
            this.bt_login.Text = "登入";
            this.bt_login.UseVisualStyleBackColor = true;
            this.bt_login.Click += new System.EventHandler(this.bt_login_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt_login);
            this.Controls.Add(this.text_box);
            this.Controls.Add(this.Ib_Welcome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Ib_Welcome;
        private System.Windows.Forms.TextBox text_box;
        private System.Windows.Forms.Button bt_login;
    }
}

