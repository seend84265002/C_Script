
namespace Ch4_1_8
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
            this.tb_money = new System.Windows.Forms.TextBox();
            this.tb_USD = new System.Windows.Forms.TextBox();
            this.tb_JPY = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_output_TWD = new System.Windows.Forms.TextBox();
            this.bt_USD = new System.Windows.Forms.Button();
            this.bt_JPY = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(58, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "金額 :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(202, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "匯率 :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // tb_money
            // 
            this.tb_money.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_money.Location = new System.Drawing.Point(156, 104);
            this.tb_money.Name = "tb_money";
            this.tb_money.Size = new System.Drawing.Size(100, 28);
            this.tb_money.TabIndex = 2;
            // 
            // tb_USD
            // 
            this.tb_USD.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_USD.Location = new System.Drawing.Point(308, 189);
            this.tb_USD.Name = "tb_USD";
            this.tb_USD.Size = new System.Drawing.Size(100, 28);
            this.tb_USD.TabIndex = 3;
            this.tb_USD.Text = "28.01";
            this.tb_USD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_JPY
            // 
            this.tb_JPY.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_JPY.Location = new System.Drawing.Point(466, 189);
            this.tb_JPY.Name = "tb_JPY";
            this.tb_JPY.Size = new System.Drawing.Size(100, 28);
            this.tb_JPY.TabIndex = 4;
            this.tb_JPY.Text = "0.24";
            this.tb_JPY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_JPY.TextChanged += new System.EventHandler(this.tb_m2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(160, 279);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 26);
            this.label3.TabIndex = 5;
            this.label3.Text = "成交台幣 :";
            // 
            // tb_output_TWD
            // 
            this.tb_output_TWD.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_output_TWD.Location = new System.Drawing.Point(308, 281);
            this.tb_output_TWD.Name = "tb_output_TWD";
            this.tb_output_TWD.ReadOnly = true;
            this.tb_output_TWD.Size = new System.Drawing.Size(100, 28);
            this.tb_output_TWD.TabIndex = 6;
            this.tb_output_TWD.Text = "0.0";
            this.tb_output_TWD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bt_USD
            // 
            this.bt_USD.Location = new System.Drawing.Point(302, 86);
            this.bt_USD.Name = "bt_USD";
            this.bt_USD.Size = new System.Drawing.Size(106, 46);
            this.bt_USD.TabIndex = 7;
            this.bt_USD.Text = "美金換台幣";
            this.bt_USD.UseVisualStyleBackColor = true;
            this.bt_USD.Click += new System.EventHandler(this.bt_USD_Click);
            // 
            // bt_JPY
            // 
            this.bt_JPY.Location = new System.Drawing.Point(460, 84);
            this.bt_JPY.Name = "bt_JPY";
            this.bt_JPY.Size = new System.Drawing.Size(106, 46);
            this.bt_JPY.TabIndex = 8;
            this.bt_JPY.Text = "日幣換台幣";
            this.bt_JPY.UseVisualStyleBackColor = true;
            this.bt_JPY.Click += new System.EventHandler(this.bt_JPY_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt_JPY);
            this.Controls.Add(this.bt_USD);
            this.Controls.Add(this.tb_output_TWD);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_JPY);
            this.Controls.Add(this.tb_USD);
            this.Controls.Add(this.tb_money);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "匯率兌換程式";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_money;
        private System.Windows.Forms.TextBox tb_USD;
        private System.Windows.Forms.TextBox tb_JPY;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_output_TWD;
        private System.Windows.Forms.Button bt_USD;
        private System.Windows.Forms.Button bt_JPY;
    }
}

