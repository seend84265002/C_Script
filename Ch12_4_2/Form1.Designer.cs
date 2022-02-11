
namespace Ch12_4_2
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
            this.bt_cal = new System.Windows.Forms.Button();
            this.tb_02 = new System.Windows.Forms.TextBox();
            this.tb_01 = new System.Windows.Forms.TextBox();
            this.lab_MSG = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bt_cal
            // 
            this.bt_cal.Location = new System.Drawing.Point(372, 91);
            this.bt_cal.Name = "bt_cal";
            this.bt_cal.Size = new System.Drawing.Size(105, 131);
            this.bt_cal.TabIndex = 10;
            this.bt_cal.Text = "計算";
            this.bt_cal.UseVisualStyleBackColor = true;
            this.bt_cal.Click += new System.EventHandler(this.bt_cal_Click);
            // 
            // tb_02
            // 
            this.tb_02.Location = new System.Drawing.Point(255, 151);
            this.tb_02.Name = "tb_02";
            this.tb_02.Size = new System.Drawing.Size(100, 28);
            this.tb_02.TabIndex = 7;
            // 
            // tb_01
            // 
            this.tb_01.Location = new System.Drawing.Point(66, 148);
            this.tb_01.Name = "tb_01";
            this.tb_01.Size = new System.Drawing.Size(100, 28);
            this.tb_01.TabIndex = 8;
            // 
            // lab_MSG
            // 
            this.lab_MSG.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lab_MSG.Location = new System.Drawing.Point(66, 242);
            this.lab_MSG.Name = "lab_MSG";
            this.lab_MSG.Size = new System.Drawing.Size(411, 175);
            this.lab_MSG.TabIndex = 4;
            this.lab_MSG.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(181, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "+,-,*,/";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 529);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_cal);
            this.Controls.Add(this.tb_02);
            this.Controls.Add(this.tb_01);
            this.Controls.Add(this.lab_MSG);
            this.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_cal;
        private System.Windows.Forms.TextBox tb_02;
        private System.Windows.Forms.TextBox tb_01;
        private System.Windows.Forms.Label lab_MSG;
        private System.Windows.Forms.Label label1;
    }
}

