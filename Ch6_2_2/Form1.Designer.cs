
namespace Ch6_2_2
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
            this.tb_input = new System.Windows.Forms.TextBox();
            this.bt_compute = new System.Windows.Forms.Button();
            this.tb_out_OMG = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "輸入增量(可負值):";
            // 
            // tb_input
            // 
            this.tb_input.Location = new System.Drawing.Point(335, 78);
            this.tb_input.Name = "tb_input";
            this.tb_input.Size = new System.Drawing.Size(100, 38);
            this.tb_input.TabIndex = 1;
            this.tb_input.Text = "0";
            this.tb_input.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bt_compute
            // 
            this.bt_compute.Location = new System.Drawing.Point(507, 78);
            this.bt_compute.Name = "bt_compute";
            this.bt_compute.Size = new System.Drawing.Size(137, 37);
            this.bt_compute.TabIndex = 2;
            this.bt_compute.Text = "計算總和";
            this.bt_compute.UseVisualStyleBackColor = true;
            this.bt_compute.Click += new System.EventHandler(this.bt_compute_Click);
            // 
            // tb_out_OMG
            // 
            this.tb_out_OMG.Location = new System.Drawing.Point(112, 160);
            this.tb_out_OMG.Multiline = true;
            this.tb_out_OMG.Name = "tb_out_OMG";
            this.tb_out_OMG.Size = new System.Drawing.Size(532, 167);
            this.tb_out_OMG.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 385);
            this.Controls.Add(this.bt_compute);
            this.Controls.Add(this.tb_out_OMG);
            this.Controls.Add(this.tb_input);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_input;
        private System.Windows.Forms.Button bt_compute;
        private System.Windows.Forms.TextBox tb_out_OMG;
    }
}

