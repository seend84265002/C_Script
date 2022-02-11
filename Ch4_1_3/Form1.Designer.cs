
namespace Ch4_1_3
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
            this.lb_Counter = new System.Windows.Forms.Label();
            this.Bu_add = new System.Windows.Forms.Button();
            this.Bu_Reduce = new System.Windows.Forms.Button();
            this.Bu_Rest = new System.Windows.Forms.Button();
            this.Bu_end = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_Counter
            // 
            this.lb_Counter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lb_Counter.Font = new System.Drawing.Font("Magneto", 45F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lb_Counter.ForeColor = System.Drawing.Color.Red;
            this.lb_Counter.Location = new System.Drawing.Point(222, 64);
            this.lb_Counter.Name = "lb_Counter";
            this.lb_Counter.Size = new System.Drawing.Size(557, 103);
            this.lb_Counter.TabIndex = 0;
            this.lb_Counter.Text = "0";
            this.lb_Counter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Bu_add
            // 
            this.Bu_add.AllowDrop = true;
            this.Bu_add.Font = new System.Drawing.Font("Forte", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Bu_add.Location = new System.Drawing.Point(222, 229);
            this.Bu_add.Name = "Bu_add";
            this.Bu_add.Size = new System.Drawing.Size(142, 90);
            this.Bu_add.TabIndex = 1;
            this.Bu_add.Text = "增加";
            this.Bu_add.UseVisualStyleBackColor = true;
            this.Bu_add.Click += new System.EventHandler(this.Bu_add_Click);
            // 
            // Bu_Reduce
            // 
            this.Bu_Reduce.Font = new System.Drawing.Font("Haettenschweiler", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Bu_Reduce.Location = new System.Drawing.Point(434, 229);
            this.Bu_Reduce.Name = "Bu_Reduce";
            this.Bu_Reduce.Size = new System.Drawing.Size(140, 90);
            this.Bu_Reduce.TabIndex = 2;
            this.Bu_Reduce.Text = "減少";
            this.Bu_Reduce.UseVisualStyleBackColor = true;
            this.Bu_Reduce.Click += new System.EventHandler(this.Bu_Reduce_Click);
            // 
            // Bu_Rest
            // 
            this.Bu_Rest.Font = new System.Drawing.Font("Matura MT Script Capitals", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Bu_Rest.Location = new System.Drawing.Point(654, 229);
            this.Bu_Rest.Name = "Bu_Rest";
            this.Bu_Rest.Size = new System.Drawing.Size(125, 90);
            this.Bu_Rest.TabIndex = 3;
            this.Bu_Rest.Text = "歸零";
            this.Bu_Rest.UseVisualStyleBackColor = true;
            this.Bu_Rest.Click += new System.EventHandler(this.Bu_Rest_Click);
            // 
            // Bu_end
            // 
            this.Bu_end.Font = new System.Drawing.Font("Microsoft JhengHei UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Bu_end.Location = new System.Drawing.Point(816, 64);
            this.Bu_end.Name = "Bu_end";
            this.Bu_end.Size = new System.Drawing.Size(93, 103);
            this.Bu_end.TabIndex = 4;
            this.Bu_end.Text = "結束";
            this.Bu_end.UseVisualStyleBackColor = true;
            this.Bu_end.Click += new System.EventHandler(this.Bu_end_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.Bu_end);
            this.Controls.Add(this.Bu_Rest);
            this.Controls.Add(this.Bu_Reduce);
            this.Controls.Add(this.Bu_add);
            this.Controls.Add(this.lb_Counter);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lb_Counter;
        private System.Windows.Forms.Button Bu_add;
        private System.Windows.Forms.Button Bu_Reduce;
        private System.Windows.Forms.Button Bu_Rest;
        private System.Windows.Forms.Button Bu_end;
    }
}

