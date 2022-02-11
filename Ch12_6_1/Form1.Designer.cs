
namespace Ch12_6_1
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
            this.lab_out = new System.Windows.Forms.Label();
            this.bt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lab_out
            // 
            this.lab_out.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lab_out.Location = new System.Drawing.Point(127, 146);
            this.lab_out.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lab_out.Name = "lab_out";
            this.lab_out.Size = new System.Drawing.Size(357, 243);
            this.lab_out.TabIndex = 0;
            // 
            // bt
            // 
            this.bt.Location = new System.Drawing.Point(143, 43);
            this.bt.Name = "bt";
            this.bt.Size = new System.Drawing.Size(331, 64);
            this.bt.TabIndex = 1;
            this.bt.Text = "使用執行續計算總和";
            this.bt.UseVisualStyleBackColor = true;
            this.bt.Click += new System.EventHandler(this.bt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 446);
            this.Controls.Add(this.bt);
            this.Controls.Add(this.lab_out);
            this.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lab_out;
        private System.Windows.Forms.Button bt;
    }
}

