
namespace Ch12_2_1
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
            this.tb_1 = new System.Windows.Forms.TextBox();
            this.tb_2 = new System.Windows.Forms.TextBox();
            this.tb_MSG = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn = new System.Windows.Forms.Button();
            this.tb_index = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_1
            // 
            this.tb_1.Location = new System.Drawing.Point(133, 72);
            this.tb_1.Name = "tb_1";
            this.tb_1.Size = new System.Drawing.Size(100, 28);
            this.tb_1.TabIndex = 0;
            // 
            // tb_2
            // 
            this.tb_2.Location = new System.Drawing.Point(391, 72);
            this.tb_2.Name = "tb_2";
            this.tb_2.Size = new System.Drawing.Size(100, 28);
            this.tb_2.TabIndex = 0;
            // 
            // tb_MSG
            // 
            this.tb_MSG.Location = new System.Drawing.Point(133, 168);
            this.tb_MSG.Multiline = true;
            this.tb_MSG.Name = "tb_MSG";
            this.tb_MSG.ReadOnly = true;
            this.tb_MSG.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_MSG.Size = new System.Drawing.Size(507, 226);
            this.tb_MSG.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(293, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "/";
            // 
            // Btn
            // 
            this.Btn.Location = new System.Drawing.Point(533, 63);
            this.Btn.Name = "Btn";
            this.Btn.Size = new System.Drawing.Size(107, 49);
            this.Btn.TabIndex = 2;
            this.Btn.Text = "計算";
            this.Btn.UseVisualStyleBackColor = true;
            this.Btn.Click += new System.EventHandler(this.Btn_Click);
            // 
            // tb_index
            // 
            this.tb_index.Location = new System.Drawing.Point(199, 121);
            this.tb_index.Name = "tb_index";
            this.tb_index.Size = new System.Drawing.Size(100, 28);
            this.tb_index.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(133, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "索引直";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 600);
            this.Controls.Add(this.tb_index);
            this.Controls.Add(this.Btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_MSG);
            this.Controls.Add(this.tb_2);
            this.Controls.Add(this.tb_1);
            this.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_1;
        private System.Windows.Forms.TextBox tb_2;
        private System.Windows.Forms.TextBox tb_MSG;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn;
        private System.Windows.Forms.TextBox tb_index;
        private System.Windows.Forms.Label label2;
    }
}

