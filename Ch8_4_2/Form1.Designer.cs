
namespace Ch8_4_2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_3 = new System.Windows.Forms.TextBox();
            this.tb_2 = new System.Windows.Forms.TextBox();
            this.tb_1 = new System.Windows.Forms.TextBox();
            this.tb_0 = new System.Windows.Forms.TextBox();
            this.Bt_ = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_replace = new System.Windows.Forms.TextBox();
            this.tb_search = new System.Windows.Forms.TextBox();
            this.tb_input = new System.Windows.Forms.TextBox();
            this.tb_MSG = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_3);
            this.groupBox1.Controls.Add(this.tb_2);
            this.groupBox1.Controls.Add(this.tb_1);
            this.groupBox1.Controls.Add(this.tb_0);
            this.groupBox1.Location = new System.Drawing.Point(84, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(642, 122);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "陣列最大值";
            // 
            // tb_3
            // 
            this.tb_3.Location = new System.Drawing.Point(459, 45);
            this.tb_3.Name = "tb_3";
            this.tb_3.Size = new System.Drawing.Size(100, 28);
            this.tb_3.TabIndex = 0;
            // 
            // tb_2
            // 
            this.tb_2.Location = new System.Drawing.Point(319, 45);
            this.tb_2.Name = "tb_2";
            this.tb_2.Size = new System.Drawing.Size(100, 28);
            this.tb_2.TabIndex = 0;
            // 
            // tb_1
            // 
            this.tb_1.Location = new System.Drawing.Point(179, 45);
            this.tb_1.Name = "tb_1";
            this.tb_1.Size = new System.Drawing.Size(100, 28);
            this.tb_1.TabIndex = 0;
            // 
            // tb_0
            // 
            this.tb_0.Location = new System.Drawing.Point(46, 45);
            this.tb_0.Name = "tb_0";
            this.tb_0.Size = new System.Drawing.Size(100, 28);
            this.tb_0.TabIndex = 0;
            // 
            // Bt_
            // 
            this.Bt_.Location = new System.Drawing.Point(752, 53);
            this.Bt_.Name = "Bt_";
            this.Bt_.Size = new System.Drawing.Size(178, 77);
            this.Bt_.TabIndex = 1;
            this.Bt_.Text = "顯示最大值";
            this.Bt_.UseVisualStyleBackColor = true;
            this.Bt_.Click += new System.EventHandler(this.Bt__Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.tb_replace);
            this.groupBox2.Controls.Add(this.tb_search);
            this.groupBox2.Controls.Add(this.tb_input);
            this.groupBox2.Location = new System.Drawing.Point(84, 191);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(642, 255);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "字串取代";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(418, 112);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 94);
            this.button1.TabIndex = 3;
            this.button1.Text = "取代字串";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "取代字串：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "搜尋字串：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "原始字串：";
            // 
            // tb_replace
            // 
            this.tb_replace.Location = new System.Drawing.Point(179, 175);
            this.tb_replace.Name = "tb_replace";
            this.tb_replace.Size = new System.Drawing.Size(181, 28);
            this.tb_replace.TabIndex = 0;
            // 
            // tb_search
            // 
            this.tb_search.Location = new System.Drawing.Point(179, 112);
            this.tb_search.Name = "tb_search";
            this.tb_search.Size = new System.Drawing.Size(181, 28);
            this.tb_search.TabIndex = 0;
            // 
            // tb_input
            // 
            this.tb_input.Location = new System.Drawing.Point(179, 45);
            this.tb_input.Name = "tb_input";
            this.tb_input.Size = new System.Drawing.Size(412, 28);
            this.tb_input.TabIndex = 0;
            // 
            // tb_MSG
            // 
            this.tb_MSG.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tb_MSG.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_MSG.ForeColor = System.Drawing.SystemColors.Window;
            this.tb_MSG.Location = new System.Drawing.Point(115, 461);
            this.tb_MSG.Multiline = true;
            this.tb_MSG.Name = "tb_MSG";
            this.tb_MSG.ReadOnly = true;
            this.tb_MSG.Size = new System.Drawing.Size(560, 76);
            this.tb_MSG.TabIndex = 2;
            this.tb_MSG.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 600);
            this.Controls.Add(this.tb_MSG);
            this.Controls.Add(this.Bt_);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tb_3;
        private System.Windows.Forms.TextBox tb_2;
        private System.Windows.Forms.TextBox tb_1;
        private System.Windows.Forms.TextBox tb_0;
        private System.Windows.Forms.Button Bt_;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_replace;
        private System.Windows.Forms.TextBox tb_search;
        private System.Windows.Forms.TextBox tb_input;
        private System.Windows.Forms.TextBox tb_MSG;
        private System.Windows.Forms.Button button1;
    }
}

