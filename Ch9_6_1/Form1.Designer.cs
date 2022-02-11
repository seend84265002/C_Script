
namespace Ch9_6_1
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
            this.bt_name = new System.Windows.Forms.Button();
            this.tb_MSG = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bt_name
            // 
            this.bt_name.Location = new System.Drawing.Point(88, 68);
            this.bt_name.Name = "bt_name";
            this.bt_name.Size = new System.Drawing.Size(445, 63);
            this.bt_name.TabIndex = 0;
            this.bt_name.Text = "顯示姓名資料";
            this.bt_name.UseVisualStyleBackColor = true;
            this.bt_name.Click += new System.EventHandler(this.bt_name_Click);
            // 
            // tb_MSG
            // 
            this.tb_MSG.Location = new System.Drawing.Point(88, 155);
            this.tb_MSG.Multiline = true;
            this.tb_MSG.Name = "tb_MSG";
            this.tb_MSG.Size = new System.Drawing.Size(445, 249);
            this.tb_MSG.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 537);
            this.Controls.Add(this.tb_MSG);
            this.Controls.Add(this.bt_name);
            this.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_name;
        private System.Windows.Forms.TextBox tb_MSG;
    }
}

