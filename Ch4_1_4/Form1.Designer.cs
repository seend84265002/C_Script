
namespace Ch4_1_4
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
            this.Tx_height = new System.Windows.Forms.TextBox();
            this.Tx_weight = new System.Windows.Forms.TextBox();
            this.Tx_bmi = new System.Windows.Forms.TextBox();
            this.Bu_cal = new System.Windows.Forms.Button();
            this.Bu_color = new System.Windows.Forms.Button();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(113, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "身高(公分)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(113, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "體重(公斤)";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(113, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "BMI";
            // 
            // Tx_height
            // 
            this.Tx_height.Location = new System.Drawing.Point(264, 80);
            this.Tx_height.Multiline = true;
            this.Tx_height.Name = "Tx_height";
            this.Tx_height.Size = new System.Drawing.Size(100, 23);
            this.Tx_height.TabIndex = 3;
            // 
            // Tx_weight
            // 
            this.Tx_weight.Location = new System.Drawing.Point(264, 121);
            this.Tx_weight.Multiline = true;
            this.Tx_weight.Name = "Tx_weight";
            this.Tx_weight.Size = new System.Drawing.Size(100, 23);
            this.Tx_weight.TabIndex = 4;
            // 
            // Tx_bmi
            // 
            this.Tx_bmi.Location = new System.Drawing.Point(264, 173);
            this.Tx_bmi.Multiline = true;
            this.Tx_bmi.Name = "Tx_bmi";
            this.Tx_bmi.Size = new System.Drawing.Size(100, 23);
            this.Tx_bmi.TabIndex = 5;
            // 
            // Bu_cal
            // 
            this.Bu_cal.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Bu_cal.Location = new System.Drawing.Point(478, 80);
            this.Bu_cal.Name = "Bu_cal";
            this.Bu_cal.Size = new System.Drawing.Size(102, 117);
            this.Bu_cal.TabIndex = 6;
            this.Bu_cal.Text = "計算BMI";
            this.Bu_cal.UseVisualStyleBackColor = true;
            this.Bu_cal.Click += new System.EventHandler(this.Bu_cal_Click);
            // 
            // Bu_color
            // 
            this.Bu_color.Location = new System.Drawing.Point(478, 274);
            this.Bu_color.Name = "Bu_color";
            this.Bu_color.Size = new System.Drawing.Size(102, 70);
            this.Bu_color.TabIndex = 7;
            this.Bu_color.Text = "調色盤";
            this.Bu_color.UseVisualStyleBackColor = true;
            this.Bu_color.Click += new System.EventHandler(this.Bu_color_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Bu_color);
            this.Controls.Add(this.Bu_cal);
            this.Controls.Add(this.Tx_bmi);
            this.Controls.Add(this.Tx_weight);
            this.Controls.Add(this.Tx_height);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Tx_height;
        private System.Windows.Forms.TextBox Tx_weight;
        private System.Windows.Forms.TextBox Tx_bmi;
        private System.Windows.Forms.Button Bu_cal;
        private System.Windows.Forms.Button Bu_color;
        private System.Windows.Forms.ColorDialog colorDialog;
    }
}

