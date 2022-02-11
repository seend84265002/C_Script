
namespace Ch6_1_1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_start = new System.Windows.Forms.TextBox();
            this.tb_end = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tb_MSG = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "起始值:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 30);
            this.label2.TabIndex = 0;
            this.label2.Text = "終止值:";
            // 
            // tb_start
            // 
            this.tb_start.Location = new System.Drawing.Point(158, 65);
            this.tb_start.Name = "tb_start";
            this.tb_start.Size = new System.Drawing.Size(100, 38);
            this.tb_start.TabIndex = 1;
            this.tb_start.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_end
            // 
            this.tb_end.Location = new System.Drawing.Point(158, 143);
            this.tb_end.Name = "tb_end";
            this.tb_end.Size = new System.Drawing.Size(100, 38);
            this.tb_end.TabIndex = 1;
            this.tb_end.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(314, 65);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 116);
            this.button1.TabIndex = 2;
            this.button1.Text = "計算總和";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tb_MSG
            // 
            this.tb_MSG.Location = new System.Drawing.Point(49, 202);
            this.tb_MSG.Multiline = true;
            this.tb_MSG.Name = "tb_MSG";
            this.tb_MSG.Size = new System.Drawing.Size(390, 140);
            this.tb_MSG.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tb_MSG);
            this.Controls.Add(this.tb_end);
            this.Controls.Add(this.tb_start);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_start;
        private System.Windows.Forms.TextBox tb_end;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tb_MSG;
    }
}

