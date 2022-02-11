
namespace Ch5_1_9
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
            this.lb_answer = new System.Windows.Forms.Label();
            this.bt_targetanswer = new System.Windows.Forms.Button();
            this.tb_target = new System.Windows.Forms.TextBox();
            this.tb_guess_Number = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_guess_number = new System.Windows.Forms.Button();
            this.tb_cnt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_outMSG = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_answer
            // 
            this.lb_answer.AutoSize = true;
            this.lb_answer.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_answer.Location = new System.Drawing.Point(220, 59);
            this.lb_answer.Name = "lb_answer";
            this.lb_answer.Size = new System.Drawing.Size(73, 24);
            this.lb_answer.TabIndex = 0;
            this.lb_answer.Text = "答案:";
            // 
            // bt_targetanswer
            // 
            this.bt_targetanswer.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt_targetanswer.Location = new System.Drawing.Point(79, 53);
            this.bt_targetanswer.Name = "bt_targetanswer";
            this.bt_targetanswer.Size = new System.Drawing.Size(134, 37);
            this.bt_targetanswer.TabIndex = 1;
            this.bt_targetanswer.Text = "產生答案";
            this.bt_targetanswer.UseVisualStyleBackColor = true;
            this.bt_targetanswer.Click += new System.EventHandler(this.bt_targetanswer_Click);
            // 
            // tb_target
            // 
            this.tb_target.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tb_target.ForeColor = System.Drawing.Color.Black;
            this.tb_target.Location = new System.Drawing.Point(299, 53);
            this.tb_target.Name = "tb_target";
            this.tb_target.ReadOnly = true;
            this.tb_target.Size = new System.Drawing.Size(117, 36);
            this.tb_target.TabIndex = 2;
            // 
            // tb_guess_Number
            // 
            this.tb_guess_Number.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tb_guess_Number.ForeColor = System.Drawing.Color.Black;
            this.tb_guess_Number.Location = new System.Drawing.Point(271, 145);
            this.tb_guess_Number.Name = "tb_guess_Number";
            this.tb_guess_Number.Size = new System.Drawing.Size(117, 36);
            this.tb_guess_Number.TabIndex = 4;
            this.tb_guess_Number.Text = "0";
            this.tb_guess_Number.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(79, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "累積次數:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // bt_guess_number
            // 
            this.bt_guess_number.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt_guess_number.Location = new System.Drawing.Point(79, 144);
            this.bt_guess_number.Name = "bt_guess_number";
            this.bt_guess_number.Size = new System.Drawing.Size(134, 37);
            this.bt_guess_number.TabIndex = 5;
            this.bt_guess_number.Text = "猜測數字";
            this.bt_guess_number.UseVisualStyleBackColor = true;
            this.bt_guess_number.Click += new System.EventHandler(this.button1_Click);
            // 
            // tb_cnt
            // 
            this.tb_cnt.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tb_cnt.ForeColor = System.Drawing.Color.Black;
            this.tb_cnt.Location = new System.Drawing.Point(271, 207);
            this.tb_cnt.Name = "tb_cnt";
            this.tb_cnt.ReadOnly = true;
            this.tb_cnt.Size = new System.Drawing.Size(117, 36);
            this.tb_cnt.TabIndex = 6;
            this.tb_cnt.Text = "0";
            this.tb_cnt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(79, 286);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "猜測結果:";
            // 
            // lb_outMSG
            // 
            this.lb_outMSG.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lb_outMSG.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_outMSG.Location = new System.Drawing.Point(220, 277);
            this.lb_outMSG.Name = "lb_outMSG";
            this.lb_outMSG.Size = new System.Drawing.Size(253, 43);
            this.lb_outMSG.TabIndex = 8;
            this.lb_outMSG.Text = "0";
            this.lb_outMSG.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lb_outMSG);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_cnt);
            this.Controls.Add(this.bt_guess_number);
            this.Controls.Add(this.tb_guess_Number);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_target);
            this.Controls.Add(this.bt_targetanswer);
            this.Controls.Add(this.lb_answer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_answer;
        private System.Windows.Forms.Button bt_targetanswer;
        private System.Windows.Forms.TextBox tb_target;
        private System.Windows.Forms.TextBox tb_guess_Number;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_guess_number;
        private System.Windows.Forms.TextBox tb_cnt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_outMSG;
    }
}

