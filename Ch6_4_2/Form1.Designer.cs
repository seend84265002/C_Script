
namespace Ch6_4_2
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
            this.tb_output = new System.Windows.Forms.TextBox();
            this.bt_9x9 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_output
            // 
            this.tb_output.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_output.Location = new System.Drawing.Point(32, 18);
            this.tb_output.Margin = new System.Windows.Forms.Padding(2);
            this.tb_output.Multiline = true;
            this.tb_output.Name = "tb_output";
            this.tb_output.ReadOnly = true;
            this.tb_output.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tb_output.Size = new System.Drawing.Size(627, 121);
            this.tb_output.TabIndex = 0;
            // 
            // bt_9x9
            // 
            this.bt_9x9.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt_9x9.Location = new System.Drawing.Point(32, 153);
            this.bt_9x9.Margin = new System.Windows.Forms.Padding(2);
            this.bt_9x9.Name = "bt_9x9";
            this.bt_9x9.Size = new System.Drawing.Size(627, 53);
            this.bt_9x9.TabIndex = 1;
            this.bt_9x9.Text = "顯示九九乘法表";
            this.bt_9x9.UseVisualStyleBackColor = true;
            this.bt_9x9.Click += new System.EventHandler(this.bt_9x9_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 261);
            this.Controls.Add(this.bt_9x9);
            this.Controls.Add(this.tb_output);
            this.Font = new System.Drawing.Font("Ravie", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.Text = "九九乘法表";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_output;
        private System.Windows.Forms.Button bt_9x9;
    }
}

