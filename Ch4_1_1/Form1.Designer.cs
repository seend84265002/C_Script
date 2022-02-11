
namespace Ch4_1_1
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
            this.label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Tb_x = new System.Windows.Forms.TextBox();
            this.Tb_y = new System.Windows.Forms.TextBox();
            this.Tb_xy = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label.Cursor = System.Windows.Forms.Cursors.No;
            this.label.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label.Location = new System.Drawing.Point(235, 86);
            this.label.Margin = new System.Windows.Forms.Padding(18, 0, 3, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(26, 24);
            this.label.TabIndex = 0;
            this.label.Text = "X:";
            this.label.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Yellow;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(228, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Y:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(167, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 43);
            this.label3.TabIndex = 2;
            this.label3.Text = "X+Y:";
            // 
            // Tb_x
            // 
            this.Tb_x.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Tb_x.Location = new System.Drawing.Point(302, 86);
            this.Tb_x.Multiline = true;
            this.Tb_x.Name = "Tb_x";
            this.Tb_x.Size = new System.Drawing.Size(100, 23);
            this.Tb_x.TabIndex = 3;
            // 
            // Tb_y
            // 
            this.Tb_y.BackColor = System.Drawing.Color.Yellow;
            this.Tb_y.Location = new System.Drawing.Point(302, 127);
            this.Tb_y.Multiline = true;
            this.Tb_y.Name = "Tb_y";
            this.Tb_y.Size = new System.Drawing.Size(216, 26);
            this.Tb_y.TabIndex = 4;
            // 
            // Tb_xy
            // 
            this.Tb_xy.Location = new System.Drawing.Point(302, 175);
            this.Tb_xy.Multiline = true;
            this.Tb_xy.Name = "Tb_xy";
            this.Tb_xy.Size = new System.Drawing.Size(281, 43);
            this.Tb_xy.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Fuchsia;
            this.button1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.Info;
            this.button1.Location = new System.Drawing.Point(302, 252);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 99);
            this.button1.TabIndex = 6;
            this.button1.Text = "Compute";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(710, 561);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Tb_xy);
            this.Controls.Add(this.Tb_y);
            this.Controls.Add(this.Tb_x);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Tb_x;
        private System.Windows.Forms.TextBox Tb_y;
        private System.Windows.Forms.TextBox Tb_xy;
        private System.Windows.Forms.Button button1;
    }
}

