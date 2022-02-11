
namespace Ch12_4_1
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
            this.tb_01 = new System.Windows.Forms.TextBox();
            this.tb_02 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_ad = new System.Windows.Forms.RadioButton();
            this.rb_sub = new System.Windows.Forms.RadioButton();
            this.rb_mul = new System.Windows.Forms.RadioButton();
            this.rb_div = new System.Windows.Forms.RadioButton();
            this.bt_cal = new System.Windows.Forms.Button();
            this.lab_MSG = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "運算元1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "運算元2";
            // 
            // tb_01
            // 
            this.tb_01.Location = new System.Drawing.Point(200, 79);
            this.tb_01.Name = "tb_01";
            this.tb_01.Size = new System.Drawing.Size(100, 28);
            this.tb_01.TabIndex = 1;
            // 
            // tb_02
            // 
            this.tb_02.Location = new System.Drawing.Point(200, 239);
            this.tb_02.Name = "tb_02";
            this.tb_02.Size = new System.Drawing.Size(100, 28);
            this.tb_02.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_div);
            this.groupBox1.Controls.Add(this.rb_mul);
            this.groupBox1.Controls.Add(this.rb_sub);
            this.groupBox1.Controls.Add(this.rb_ad);
            this.groupBox1.Location = new System.Drawing.Point(56, 132);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(244, 82);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "運算子";
            // 
            // rb_ad
            // 
            this.rb_ad.AutoSize = true;
            this.rb_ad.Location = new System.Drawing.Point(23, 39);
            this.rb_ad.Name = "rb_ad";
            this.rb_ad.Size = new System.Drawing.Size(39, 24);
            this.rb_ad.TabIndex = 0;
            this.rb_ad.TabStop = true;
            this.rb_ad.Text = "+";
            this.rb_ad.UseVisualStyleBackColor = true;
            // 
            // rb_sub
            // 
            this.rb_sub.AutoSize = true;
            this.rb_sub.Location = new System.Drawing.Point(80, 39);
            this.rb_sub.Name = "rb_sub";
            this.rb_sub.Size = new System.Drawing.Size(34, 24);
            this.rb_sub.TabIndex = 0;
            this.rb_sub.TabStop = true;
            this.rb_sub.Text = "-";
            this.rb_sub.UseVisualStyleBackColor = true;
            // 
            // rb_mul
            // 
            this.rb_mul.AutoSize = true;
            this.rb_mul.Location = new System.Drawing.Point(135, 39);
            this.rb_mul.Name = "rb_mul";
            this.rb_mul.Size = new System.Drawing.Size(34, 24);
            this.rb_mul.TabIndex = 0;
            this.rb_mul.TabStop = true;
            this.rb_mul.Text = "*";
            this.rb_mul.UseVisualStyleBackColor = true;
            // 
            // rb_div
            // 
            this.rb_div.AutoSize = true;
            this.rb_div.Location = new System.Drawing.Point(191, 39);
            this.rb_div.Name = "rb_div";
            this.rb_div.Size = new System.Drawing.Size(34, 24);
            this.rb_div.TabIndex = 0;
            this.rb_div.TabStop = true;
            this.rb_div.Text = "/";
            this.rb_div.UseVisualStyleBackColor = true;
            // 
            // bt_cal
            // 
            this.bt_cal.Location = new System.Drawing.Point(362, 109);
            this.bt_cal.Name = "bt_cal";
            this.bt_cal.Size = new System.Drawing.Size(105, 131);
            this.bt_cal.TabIndex = 3;
            this.bt_cal.Text = "計算";
            this.bt_cal.UseVisualStyleBackColor = true;
            this.bt_cal.Click += new System.EventHandler(this.bt_cal_Click);
            // 
            // lab_MSG
            // 
            this.lab_MSG.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lab_MSG.Location = new System.Drawing.Point(56, 324);
            this.lab_MSG.Name = "lab_MSG";
            this.lab_MSG.Size = new System.Drawing.Size(411, 136);
            this.lab_MSG.TabIndex = 0;
            this.lab_MSG.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 606);
            this.Controls.Add(this.bt_cal);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tb_02);
            this.Controls.Add(this.tb_01);
            this.Controls.Add(this.lab_MSG);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_01;
        private System.Windows.Forms.TextBox tb_02;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb_div;
        private System.Windows.Forms.RadioButton rb_mul;
        private System.Windows.Forms.RadioButton rb_sub;
        private System.Windows.Forms.RadioButton rb_ad;
        private System.Windows.Forms.Button bt_cal;
        private System.Windows.Forms.Label lab_MSG;
    }
}

