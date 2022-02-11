
namespace Ch8_5_1
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
            this.Bt_ = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_3 = new System.Windows.Forms.TextBox();
            this.tb_2 = new System.Windows.Forms.TextBox();
            this.tb_1 = new System.Windows.Forms.TextBox();
            this.tb_0 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Bt_
            // 
            this.Bt_.Location = new System.Drawing.Point(729, 83);
            this.Bt_.Name = "Bt_";
            this.Bt_.Size = new System.Drawing.Size(178, 77);
            this.Bt_.TabIndex = 3;
            this.Bt_.Text = "排序";
            this.Bt_.UseVisualStyleBackColor = true;
            this.Bt_.Click += new System.EventHandler(this.Bt__Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_3);
            this.groupBox1.Controls.Add(this.tb_2);
            this.groupBox1.Controls.Add(this.tb_1);
            this.groupBox1.Controls.Add(this.tb_0);
            this.groupBox1.Location = new System.Drawing.Point(49, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(642, 122);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "陣列排序";
            // 
            // tb_3
            // 
            this.tb_3.Location = new System.Drawing.Point(459, 45);
            this.tb_3.Name = "tb_3";
            this.tb_3.Size = new System.Drawing.Size(100, 23);
            this.tb_3.TabIndex = 0;
            // 
            // tb_2
            // 
            this.tb_2.Location = new System.Drawing.Point(319, 45);
            this.tb_2.Name = "tb_2";
            this.tb_2.Size = new System.Drawing.Size(100, 23);
            this.tb_2.TabIndex = 0;
            // 
            // tb_1
            // 
            this.tb_1.Location = new System.Drawing.Point(179, 45);
            this.tb_1.Name = "tb_1";
            this.tb_1.Size = new System.Drawing.Size(100, 23);
            this.tb_1.TabIndex = 0;
            // 
            // tb_0
            // 
            this.tb_0.Location = new System.Drawing.Point(46, 45);
            this.tb_0.Name = "tb_0";
            this.tb_0.Size = new System.Drawing.Size(100, 23);
            this.tb_0.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 569);
            this.Controls.Add(this.Bt_);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Bt_;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tb_3;
        private System.Windows.Forms.TextBox tb_2;
        private System.Windows.Forms.TextBox tb_1;
        private System.Windows.Forms.TextBox tb_0;
    }
}

