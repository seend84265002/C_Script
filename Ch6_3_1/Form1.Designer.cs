
namespace Ch6_3_1
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
            this.tb_Good_Price = new System.Windows.Forms.TextBox();
            this.tb_Month_money = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tb_out_MSG = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "購物價格";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "月存金額";
            // 
            // tb_Good_Price
            // 
            this.tb_Good_Price.Location = new System.Drawing.Point(200, 47);
            this.tb_Good_Price.Name = "tb_Good_Price";
            this.tb_Good_Price.Size = new System.Drawing.Size(129, 36);
            this.tb_Good_Price.TabIndex = 1;
            // 
            // tb_Month_money
            // 
            this.tb_Month_money.Location = new System.Drawing.Point(200, 103);
            this.tb_Month_money.Name = "tb_Month_money";
            this.tb_Month_money.Size = new System.Drawing.Size(129, 36);
            this.tb_Month_money.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(368, 47);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 92);
            this.button1.TabIndex = 2;
            this.button1.Text = "所需月份";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tb_out_MSG
            // 
            this.tb_out_MSG.Location = new System.Drawing.Point(81, 182);
            this.tb_out_MSG.Multiline = true;
            this.tb_out_MSG.Name = "tb_out_MSG";
            this.tb_out_MSG.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_out_MSG.Size = new System.Drawing.Size(416, 168);
            this.tb_out_MSG.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 461);
            this.Controls.Add(this.tb_out_MSG);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tb_Month_money);
            this.Controls.Add(this.tb_Good_Price);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form1";
            this.Text = "規劃存錢購物";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_Good_Price;
        private System.Windows.Forms.TextBox tb_Month_money;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tb_out_MSG;
    }
}

