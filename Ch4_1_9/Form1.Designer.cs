
namespace Ch4_1_9
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_height = new System.Windows.Forms.TextBox();
            this.tb_weight = new System.Windows.Forms.TextBox();
            this.tb_A_max = new System.Windows.Forms.TextBox();
            this.tb_A_min = new System.Windows.Forms.TextBox();
            this.tb_B_min = new System.Windows.Forms.TextBox();
            this.tb_B_max = new System.Windows.Forms.TextBox();
            this.tb_BMI = new System.Windows.Forms.TextBox();
            this.bt_input = new System.Windows.Forms.Button();
            this.bt_if = new System.Windows.Forms.Button();
            this.bt_enter = new System.Windows.Forms.Button();
            this.rb_ok = new System.Windows.Forms.RadioButton();
            this.rb_ng = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Goudy Stout", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(103, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "輸入身高(公分)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Goudy Stout", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(103, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "輸入體重(公斤)";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Goudy Stout", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(91, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "A:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Goudy Stout", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(393, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 26);
            this.label4.TabIndex = 3;
            this.label4.Text = ">";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(376, 320);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "&&&&";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Goudy Stout", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(94, 386);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 26);
            this.label6.TabIndex = 5;
            this.label6.Text = "B:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Goudy Stout", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(376, 385);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 26);
            this.label7.TabIndex = 6;
            this.label7.Text = "<=";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Goudy Stout", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(62, 496);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 26);
            this.label8.TabIndex = 7;
            this.label8.Text = "BMI";
            // 
            // tb_height
            // 
            this.tb_height.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_height.Location = new System.Drawing.Point(325, 72);
            this.tb_height.Name = "tb_height";
            this.tb_height.Size = new System.Drawing.Size(189, 27);
            this.tb_height.TabIndex = 8;
            this.tb_height.Text = "0";
            this.tb_height.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_height.TextChanged += new System.EventHandler(this.tb_height_TextChanged);
            // 
            // tb_weight
            // 
            this.tb_weight.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_weight.Location = new System.Drawing.Point(325, 136);
            this.tb_weight.Name = "tb_weight";
            this.tb_weight.Size = new System.Drawing.Size(189, 27);
            this.tb_weight.TabIndex = 9;
            this.tb_weight.Text = "0";
            this.tb_weight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_A_max
            // 
            this.tb_A_max.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tb_A_max.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_A_max.Location = new System.Drawing.Point(186, 235);
            this.tb_A_max.Name = "tb_A_max";
            this.tb_A_max.ReadOnly = true;
            this.tb_A_max.Size = new System.Drawing.Size(189, 27);
            this.tb_A_max.TabIndex = 10;
            this.tb_A_max.Text = "0";
            this.tb_A_max.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_A_min
            // 
            this.tb_A_min.BackColor = System.Drawing.Color.Red;
            this.tb_A_min.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_A_min.Location = new System.Drawing.Point(428, 236);
            this.tb_A_min.Name = "tb_A_min";
            this.tb_A_min.Size = new System.Drawing.Size(189, 27);
            this.tb_A_min.TabIndex = 11;
            this.tb_A_min.Text = "50";
            this.tb_A_min.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_B_min
            // 
            this.tb_B_min.BackColor = System.Drawing.Color.Aqua;
            this.tb_B_min.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_B_min.Location = new System.Drawing.Point(186, 384);
            this.tb_B_min.Name = "tb_B_min";
            this.tb_B_min.ReadOnly = true;
            this.tb_B_min.Size = new System.Drawing.Size(189, 27);
            this.tb_B_min.TabIndex = 12;
            this.tb_B_min.Text = "0";
            this.tb_B_min.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_B_max
            // 
            this.tb_B_max.BackColor = System.Drawing.Color.Red;
            this.tb_B_max.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_B_max.Location = new System.Drawing.Point(428, 385);
            this.tb_B_max.Name = "tb_B_max";
            this.tb_B_max.Size = new System.Drawing.Size(189, 27);
            this.tb_B_max.TabIndex = 13;
            this.tb_B_max.Text = "200";
            this.tb_B_max.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_BMI
            // 
            this.tb_BMI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.tb_BMI.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_BMI.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tb_BMI.Location = new System.Drawing.Point(186, 495);
            this.tb_BMI.Name = "tb_BMI";
            this.tb_BMI.ReadOnly = true;
            this.tb_BMI.Size = new System.Drawing.Size(431, 27);
            this.tb_BMI.TabIndex = 14;
            this.tb_BMI.Text = "0";
            this.tb_BMI.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bt_input
            // 
            this.bt_input.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_input.Location = new System.Drawing.Point(760, 49);
            this.bt_input.Name = "bt_input";
            this.bt_input.Size = new System.Drawing.Size(154, 76);
            this.bt_input.TabIndex = 15;
            this.bt_input.Text = "填入參數";
            this.bt_input.UseVisualStyleBackColor = true;
            this.bt_input.Click += new System.EventHandler(this.bt_input_Click);
            // 
            // bt_if
            // 
            this.bt_if.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_if.Location = new System.Drawing.Point(760, 187);
            this.bt_if.Name = "bt_if";
            this.bt_if.Size = new System.Drawing.Size(154, 76);
            this.bt_if.TabIndex = 16;
            this.bt_if.Text = "判斷參數";
            this.bt_if.UseVisualStyleBackColor = true;
            this.bt_if.Click += new System.EventHandler(this.bt_if_Click);
            // 
            // bt_enter
            // 
            this.bt_enter.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_enter.Location = new System.Drawing.Point(760, 446);
            this.bt_enter.Name = "bt_enter";
            this.bt_enter.Size = new System.Drawing.Size(154, 76);
            this.bt_enter.TabIndex = 17;
            this.bt_enter.Text = "計算BMI";
            this.bt_enter.UseVisualStyleBackColor = true;
            this.bt_enter.Click += new System.EventHandler(this.bt_enter_Click);
            // 
            // rb_ok
            // 
            this.rb_ok.AutoSize = true;
            this.rb_ok.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rb_ok.Location = new System.Drawing.Point(760, 319);
            this.rb_ok.Name = "rb_ok";
            this.rb_ok.Size = new System.Drawing.Size(59, 24);
            this.rb_ok.TabIndex = 18;
            this.rb_ok.TabStop = true;
            this.rb_ok.Text = "合格";
            this.rb_ok.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rb_ok.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.rb_ok.UseVisualStyleBackColor = true;
            // 
            // rb_ng
            // 
            this.rb_ng.AutoSize = true;
            this.rb_ng.Checked = true;
            this.rb_ng.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rb_ng.Location = new System.Drawing.Point(760, 367);
            this.rb_ng.Name = "rb_ng";
            this.rb_ng.Size = new System.Drawing.Size(75, 24);
            this.rb_ng.TabIndex = 19;
            this.rb_ng.TabStop = true;
            this.rb_ng.Text = "不合格";
            this.rb_ng.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rb_ng.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.rb_ng.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1037, 561);
            this.Controls.Add(this.rb_ng);
            this.Controls.Add(this.rb_ok);
            this.Controls.Add(this.bt_enter);
            this.Controls.Add(this.bt_if);
            this.Controls.Add(this.bt_input);
            this.Controls.Add(this.tb_BMI);
            this.Controls.Add(this.tb_B_max);
            this.Controls.Add(this.tb_B_min);
            this.Controls.Add(this.tb_A_min);
            this.Controls.Add(this.tb_A_max);
            this.Controls.Add(this.tb_weight);
            this.Controls.Add(this.tb_height);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "BMI計算器";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_height;
        private System.Windows.Forms.TextBox tb_weight;
        private System.Windows.Forms.TextBox tb_A_max;
        private System.Windows.Forms.TextBox tb_A_min;
        private System.Windows.Forms.TextBox tb_B_min;
        private System.Windows.Forms.TextBox tb_B_max;
        private System.Windows.Forms.TextBox tb_BMI;
        private System.Windows.Forms.Button bt_input;
        private System.Windows.Forms.Button bt_if;
        private System.Windows.Forms.Button bt_enter;
        private System.Windows.Forms.RadioButton rb_ok;
        private System.Windows.Forms.RadioButton rb_ng;
    }
}

