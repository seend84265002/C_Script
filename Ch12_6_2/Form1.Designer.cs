
namespace Ch12_6_2
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
            this.bt_thread = new System.Windows.Forms.Button();
            this.bt_thread2 = new System.Windows.Forms.Button();
            this.bt_thread3 = new System.Windows.Forms.Button();
            this.lab_out = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bt_thread
            // 
            this.bt_thread.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_thread.Location = new System.Drawing.Point(76, 60);
            this.bt_thread.Name = "bt_thread";
            this.bt_thread.Size = new System.Drawing.Size(185, 69);
            this.bt_thread.TabIndex = 0;
            this.bt_thread.Text = "執行緒";
            this.bt_thread.UseVisualStyleBackColor = true;
            this.bt_thread.Click += new System.EventHandler(this.bt_thread_Click);
            // 
            // bt_thread2
            // 
            this.bt_thread2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_thread2.Location = new System.Drawing.Point(307, 60);
            this.bt_thread2.Name = "bt_thread2";
            this.bt_thread2.Size = new System.Drawing.Size(185, 69);
            this.bt_thread2.TabIndex = 0;
            this.bt_thread2.Text = "執行緒同步1";
            this.bt_thread2.UseVisualStyleBackColor = true;
            this.bt_thread2.Click += new System.EventHandler(this.bt_thread2_Click);
            // 
            // bt_thread3
            // 
            this.bt_thread3.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_thread3.Location = new System.Drawing.Point(544, 60);
            this.bt_thread3.Name = "bt_thread3";
            this.bt_thread3.Size = new System.Drawing.Size(185, 69);
            this.bt_thread3.TabIndex = 0;
            this.bt_thread3.Text = "執行緒同步2";
            this.bt_thread3.UseVisualStyleBackColor = true;
            this.bt_thread3.Click += new System.EventHandler(this.bt_thread3_Click);
            // 
            // lab_out
            // 
            this.lab_out.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lab_out.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lab_out.Location = new System.Drawing.Point(76, 174);
            this.lab_out.Name = "lab_out";
            this.lab_out.Size = new System.Drawing.Size(653, 375);
            this.lab_out.TabIndex = 1;
            this.lab_out.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 636);
            this.Controls.Add(this.lab_out);
            this.Controls.Add(this.bt_thread3);
            this.Controls.Add(this.bt_thread2);
            this.Controls.Add(this.bt_thread);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_thread;
        private System.Windows.Forms.Button bt_thread2;
        private System.Windows.Forms.Button bt_thread3;
        private System.Windows.Forms.Label lab_out;
    }
}

