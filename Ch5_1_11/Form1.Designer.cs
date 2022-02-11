
namespace Ch5_1_11
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
            this.tb_input = new System.Windows.Forms.TextBox();
            this.bt_vote = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_other = new System.Windows.Forms.TextBox();
            this.tb_cbb = new System.Windows.Forms.TextBox();
            this.tb_C = new System.Windows.Forms.TextBox();
            this.tb_CCC = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_out_MSG = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(148, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "程式語言代碼:";
            // 
            // tb_input
            // 
            this.tb_input.Location = new System.Drawing.Point(317, 67);
            this.tb_input.Name = "tb_input";
            this.tb_input.Size = new System.Drawing.Size(100, 38);
            this.tb_input.TabIndex = 1;
            this.tb_input.Text = "0";
            this.tb_input.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bt_vote
            // 
            this.bt_vote.Location = new System.Drawing.Point(448, 50);
            this.bt_vote.Name = "bt_vote";
            this.bt_vote.Size = new System.Drawing.Size(160, 55);
            this.bt_vote.TabIndex = 2;
            this.bt_vote.Text = "票選";
            this.bt_vote.UseVisualStyleBackColor = true;
            this.bt_vote.Click += new System.EventHandler(this.bt_vote_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tb_other);
            this.groupBox1.Controls.Add(this.tb_cbb);
            this.groupBox1.Controls.Add(this.tb_C);
            this.groupBox1.Controls.Add(this.tb_CCC);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(148, 139);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(511, 174);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "票選結果";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(367, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 30);
            this.label5.TabIndex = 0;
            this.label5.Text = "其他語言:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(257, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 30);
            this.label4.TabIndex = 0;
            this.label4.Text = "C++:";
            // 
            // tb_other
            // 
            this.tb_other.Location = new System.Drawing.Point(384, 99);
            this.tb_other.Name = "tb_other";
            this.tb_other.ReadOnly = true;
            this.tb_other.Size = new System.Drawing.Size(76, 38);
            this.tb_other.TabIndex = 1;
            this.tb_other.Text = "0";
            this.tb_other.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tb_cbb
            // 
            this.tb_cbb.Location = new System.Drawing.Point(257, 99);
            this.tb_cbb.Name = "tb_cbb";
            this.tb_cbb.ReadOnly = true;
            this.tb_cbb.Size = new System.Drawing.Size(74, 38);
            this.tb_cbb.TabIndex = 1;
            this.tb_cbb.Text = "0";
            this.tb_cbb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_C
            // 
            this.tb_C.Location = new System.Drawing.Point(131, 99);
            this.tb_C.Name = "tb_C";
            this.tb_C.ReadOnly = true;
            this.tb_C.Size = new System.Drawing.Size(74, 38);
            this.tb_C.TabIndex = 1;
            this.tb_C.Text = "0";
            this.tb_C.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_CCC
            // 
            this.tb_CCC.Location = new System.Drawing.Point(20, 99);
            this.tb_CCC.Name = "tb_CCC";
            this.tb_CCC.ReadOnly = true;
            this.tb_CCC.Size = new System.Drawing.Size(74, 38);
            this.tb_CCC.TabIndex = 1;
            this.tb_CCC.Text = "0";
            this.tb_CCC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(131, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 30);
            this.label3.TabIndex = 0;
            this.label3.Text = "C語言:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 30);
            this.label2.TabIndex = 0;
            this.label2.Text = "C#:";
            // 
            // lb_out_MSG
            // 
            this.lb_out_MSG.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lb_out_MSG.Location = new System.Drawing.Point(148, 343);
            this.lb_out_MSG.Name = "lb_out_MSG";
            this.lb_out_MSG.Size = new System.Drawing.Size(511, 58);
            this.lb_out_MSG.TabIndex = 0;
            this.lb_out_MSG.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bt_vote);
            this.Controls.Add(this.tb_input);
            this.Controls.Add(this.lb_out_MSG);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_input;
        private System.Windows.Forms.Button bt_vote;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_other;
        private System.Windows.Forms.TextBox tb_cbb;
        private System.Windows.Forms.TextBox tb_C;
        private System.Windows.Forms.TextBox tb_CCC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_out_MSG;
    }
}

