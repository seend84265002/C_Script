
namespace Ch4_1_7
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
            this.tb_ML = new System.Windows.Forms.TextBox();
            this.bt_sel = new System.Windows.Forms.Button();
            this.bt_Dis = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_start = new System.Windows.Forms.TextBox();
            this.tb_Ouyput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tb_ML
            // 
            this.tb_ML.Location = new System.Drawing.Point(109, 47);
            this.tb_ML.Multiline = true;
            this.tb_ML.Name = "tb_ML";
            this.tb_ML.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_ML.Size = new System.Drawing.Size(249, 170);
            this.tb_ML.TabIndex = 0;
            this.tb_ML.Text = "Python是一種廣泛使用的直譯式、進階和通用的程式語言。Python支援多種程式設計範式，包括函數式、指令式、結構化、物件導向和反射式程式。它擁有動態型別系統和" +
    "垃圾回收功能，能夠自動管理記憶體使用，並且其本身擁有一個巨大而廣泛的標準庫。";
            // 
            // bt_sel
            // 
            this.bt_sel.Location = new System.Drawing.Point(395, 47);
            this.bt_sel.Name = "bt_sel";
            this.bt_sel.Size = new System.Drawing.Size(141, 42);
            this.bt_sel.TabIndex = 1;
            this.bt_sel.Text = "選取6個字";
            this.bt_sel.UseVisualStyleBackColor = true;
            this.bt_sel.Click += new System.EventHandler(this.bt_sel_Click);
            // 
            // bt_Dis
            // 
            this.bt_Dis.Location = new System.Drawing.Point(395, 140);
            this.bt_Dis.Name = "bt_Dis";
            this.bt_Dis.Size = new System.Drawing.Size(141, 42);
            this.bt_Dis.TabIndex = 2;
            this.bt_Dis.Text = "顯示";
            this.bt_Dis.UseVisualStyleBackColor = true;
            this.bt_Dis.Click += new System.EventHandler(this.bt_Dis_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(109, 231);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "起始位置";
            // 
            // tb_start
            // 
            this.tb_start.Font = new System.Drawing.Font("Magneto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tb_start.Location = new System.Drawing.Point(211, 224);
            this.tb_start.Name = "tb_start";
            this.tb_start.Size = new System.Drawing.Size(114, 27);
            this.tb_start.TabIndex = 4;
            this.tb_start.Text = "0";
            this.tb_start.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_Ouyput
            // 
            this.tb_Ouyput.Font = new System.Drawing.Font("Magneto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tb_Ouyput.Location = new System.Drawing.Point(109, 284);
            this.tb_Ouyput.Name = "tb_Ouyput";
            this.tb_Ouyput.ReadOnly = true;
            this.tb_Ouyput.Size = new System.Drawing.Size(427, 27);
            this.tb_Ouyput.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 510);
            this.Controls.Add(this.tb_Ouyput);
            this.Controls.Add(this.tb_start);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_Dis);
            this.Controls.Add(this.bt_sel);
            this.Controls.Add(this.tb_ML);
            this.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_ML;
        private System.Windows.Forms.Button bt_sel;
        private System.Windows.Forms.Button bt_Dis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_start;
        private System.Windows.Forms.TextBox tb_Ouyput;
    }
}

