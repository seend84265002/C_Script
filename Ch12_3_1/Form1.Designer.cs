
namespace Ch12_3_1
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
            this.tb_in = new System.Windows.Forms.TextBox();
            this.tb_out = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_in
            // 
            this.tb_in.Location = new System.Drawing.Point(192, 41);
            this.tb_in.Name = "tb_in";
            this.tb_in.Size = new System.Drawing.Size(100, 28);
            this.tb_in.TabIndex = 0;
            // 
            // tb_out
            // 
            this.tb_out.Location = new System.Drawing.Point(71, 119);
            this.tb_out.Multiline = true;
            this.tb_out.Name = "tb_out";
            this.tb_out.Size = new System.Drawing.Size(426, 303);
            this.tb_out.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(347, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 49);
            this.button1.TabIndex = 1;
            this.button1.Text = "丟出例外";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "輸入值";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 454);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tb_out);
            this.Controls.Add(this.tb_in);
            this.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_in;
        private System.Windows.Forms.TextBox tb_out;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}

