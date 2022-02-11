
namespace Ch4_1_5
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
            this.Bu_form_BC = new System.Windows.Forms.Button();
            this.Color_form_BC = new System.Windows.Forms.ColorDialog();
            this.Group_Bt = new System.Windows.Forms.GroupBox();
            this.Tb_B = new System.Windows.Forms.TextBox();
            this.Lb_B = new System.Windows.Forms.Label();
            this.Tb_G = new System.Windows.Forms.TextBox();
            this.Lb_G = new System.Windows.Forms.Label();
            this.Tb_R = new System.Windows.Forms.TextBox();
            this.Lb_R = new System.Windows.Forms.Label();
            this.Group_Bt.SuspendLayout();
            this.SuspendLayout();
            // 
            // Bu_form_BC
            // 
            this.Bu_form_BC.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Bu_form_BC.Location = new System.Drawing.Point(67, 38);
            this.Bu_form_BC.Name = "Bu_form_BC";
            this.Bu_form_BC.Size = new System.Drawing.Size(189, 40);
            this.Bu_form_BC.TabIndex = 0;
            this.Bu_form_BC.Text = "CHG Form BC";
            this.Bu_form_BC.UseVisualStyleBackColor = true;
            this.Bu_form_BC.Click += new System.EventHandler(this.Bu_form_BC_Click);
            // 
            // Group_Bt
            // 
            this.Group_Bt.Controls.Add(this.Tb_B);
            this.Group_Bt.Controls.Add(this.Lb_B);
            this.Group_Bt.Controls.Add(this.Tb_G);
            this.Group_Bt.Controls.Add(this.Lb_G);
            this.Group_Bt.Controls.Add(this.Tb_R);
            this.Group_Bt.Controls.Add(this.Lb_R);
            this.Group_Bt.Controls.Add(this.Bu_form_BC);
            this.Group_Bt.Location = new System.Drawing.Point(31, 31);
            this.Group_Bt.Name = "Group_Bt";
            this.Group_Bt.Size = new System.Drawing.Size(301, 225);
            this.Group_Bt.TabIndex = 1;
            this.Group_Bt.TabStop = false;
            this.Group_Bt.Text = "選單一";
            this.Group_Bt.Enter += new System.EventHandler(this.Group_Bt_Enter);
            // 
            // Tb_B
            // 
            this.Tb_B.Location = new System.Drawing.Point(114, 158);
            this.Tb_B.Name = "Tb_B";
            this.Tb_B.Size = new System.Drawing.Size(100, 23);
            this.Tb_B.TabIndex = 6;
            // 
            // Lb_B
            // 
            this.Lb_B.AutoSize = true;
            this.Lb_B.Location = new System.Drawing.Point(68, 158);
            this.Lb_B.Name = "Lb_B";
            this.Lb_B.Size = new System.Drawing.Size(23, 15);
            this.Lb_B.TabIndex = 5;
            this.Lb_B.Text = "B  :";
            // 
            // Tb_G
            // 
            this.Tb_G.Location = new System.Drawing.Point(114, 129);
            this.Tb_G.Name = "Tb_G";
            this.Tb_G.Size = new System.Drawing.Size(100, 23);
            this.Tb_G.TabIndex = 4;
            // 
            // Lb_G
            // 
            this.Lb_G.AutoSize = true;
            this.Lb_G.Location = new System.Drawing.Point(67, 129);
            this.Lb_G.Name = "Lb_G";
            this.Lb_G.Size = new System.Drawing.Size(22, 15);
            this.Lb_G.TabIndex = 3;
            this.Lb_G.Text = "G :";
            // 
            // Tb_R
            // 
            this.Tb_R.Location = new System.Drawing.Point(114, 100);
            this.Tb_R.Name = "Tb_R";
            this.Tb_R.Size = new System.Drawing.Size(100, 23);
            this.Tb_R.TabIndex = 2;
            // 
            // Lb_R
            // 
            this.Lb_R.AutoSize = true;
            this.Lb_R.Location = new System.Drawing.Point(68, 100);
            this.Lb_R.Name = "Lb_R";
            this.Lb_R.Size = new System.Drawing.Size(21, 15);
            this.Lb_R.TabIndex = 1;
            this.Lb_R.Text = "R :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 480);
            this.Controls.Add(this.Group_Bt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Group_Bt.ResumeLayout(false);
            this.Group_Bt.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Bu_form_BC;
        private System.Windows.Forms.ColorDialog Color_form_BC;
        private System.Windows.Forms.GroupBox Group_Bt;
        private System.Windows.Forms.TextBox Tb_B;
        private System.Windows.Forms.Label Lb_B;
        private System.Windows.Forms.TextBox Tb_G;
        private System.Windows.Forms.Label Lb_G;
        private System.Windows.Forms.TextBox Tb_R;
        private System.Windows.Forms.Label Lb_R;
    }
}

