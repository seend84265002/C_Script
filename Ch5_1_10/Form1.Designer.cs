
namespace Ch5_1_10
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
            this.tb_Num1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_div = new System.Windows.Forms.RadioButton();
            this.rb_sub = new System.Windows.Forms.RadioButton();
            this.rb_mul = new System.Windows.Forms.RadioButton();
            this.rb_Add = new System.Windows.Forms.RadioButton();
            this.bt_calculate = new System.Windows.Forms.Button();
            this.tb_Num2 = new System.Windows.Forms.TextBox();
            this.lb_answer = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "運算元1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(106, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "運算元2";
            // 
            // tb_Num1
            // 
            this.tb_Num1.Location = new System.Drawing.Point(230, 50);
            this.tb_Num1.Name = "tb_Num1";
            this.tb_Num1.Size = new System.Drawing.Size(222, 36);
            this.tb_Num1.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_div);
            this.groupBox1.Controls.Add(this.rb_sub);
            this.groupBox1.Controls.Add(this.rb_mul);
            this.groupBox1.Controls.Add(this.rb_Add);
            this.groupBox1.Location = new System.Drawing.Point(106, 103);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(346, 84);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "運算子";
            // 
            // rb_div
            // 
            this.rb_div.AutoSize = true;
            this.rb_div.Location = new System.Drawing.Point(259, 36);
            this.rb_div.Name = "rb_div";
            this.rb_div.Size = new System.Drawing.Size(40, 28);
            this.rb_div.TabIndex = 1;
            this.rb_div.TabStop = true;
            this.rb_div.Text = "/";
            this.rb_div.UseVisualStyleBackColor = true;
            // 
            // rb_sub
            // 
            this.rb_sub.AutoSize = true;
            this.rb_sub.Location = new System.Drawing.Point(105, 35);
            this.rb_sub.Name = "rb_sub";
            this.rb_sub.Size = new System.Drawing.Size(40, 28);
            this.rb_sub.TabIndex = 1;
            this.rb_sub.TabStop = true;
            this.rb_sub.Text = "-";
            this.rb_sub.UseVisualStyleBackColor = true;
            // 
            // rb_mul
            // 
            this.rb_mul.AutoSize = true;
            this.rb_mul.Location = new System.Drawing.Point(182, 36);
            this.rb_mul.Name = "rb_mul";
            this.rb_mul.Size = new System.Drawing.Size(40, 28);
            this.rb_mul.TabIndex = 1;
            this.rb_mul.TabStop = true;
            this.rb_mul.Text = "*";
            this.rb_mul.UseVisualStyleBackColor = true;
            // 
            // rb_Add
            // 
            this.rb_Add.AutoSize = true;
            this.rb_Add.Location = new System.Drawing.Point(32, 36);
            this.rb_Add.Name = "rb_Add";
            this.rb_Add.Size = new System.Drawing.Size(40, 28);
            this.rb_Add.TabIndex = 0;
            this.rb_Add.TabStop = true;
            this.rb_Add.Text = "+";
            this.rb_Add.UseVisualStyleBackColor = true;
            // 
            // bt_calculate
            // 
            this.bt_calculate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bt_calculate.Location = new System.Drawing.Point(474, 50);
            this.bt_calculate.Name = "bt_calculate";
            this.bt_calculate.Size = new System.Drawing.Size(102, 179);
            this.bt_calculate.TabIndex = 5;
            this.bt_calculate.Text = "計算";
            this.bt_calculate.UseVisualStyleBackColor = false;
            this.bt_calculate.Click += new System.EventHandler(this.button1_Click);
            // 
            // tb_Num2
            // 
            this.tb_Num2.Location = new System.Drawing.Point(230, 193);
            this.tb_Num2.Name = "tb_Num2";
            this.tb_Num2.Size = new System.Drawing.Size(222, 36);
            this.tb_Num2.TabIndex = 3;
            // 
            // lb_answer
            // 
            this.lb_answer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lb_answer.Location = new System.Drawing.Point(106, 250);
            this.lb_answer.Name = "lb_answer";
            this.lb_answer.Size = new System.Drawing.Size(470, 39);
            this.lb_answer.TabIndex = 1;
            this.lb_answer.Text = "0";
            this.lb_answer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_answer.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 369);
            this.Controls.Add(this.bt_calculate);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tb_Num2);
            this.Controls.Add(this.tb_Num1);
            this.Controls.Add(this.lb_answer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "四則運算機";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_Num1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb_div;
        private System.Windows.Forms.RadioButton rb_sub;
        private System.Windows.Forms.RadioButton rb_mul;
        private System.Windows.Forms.RadioButton rb_Add;
        private System.Windows.Forms.Button bt_calculate;
        private System.Windows.Forms.TextBox tb_Num2;
        private System.Windows.Forms.Label lb_answer;
    }
}

