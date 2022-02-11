
namespace Ch4_1_2
{
    partial class Form
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
            this.Bu_Int = new System.Windows.Forms.Button();
            this.Bu_Rest = new System.Windows.Forms.Button();
            this.Bu_Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Bu_Int
            // 
            this.Bu_Int.Font = new System.Drawing.Font("Gill Sans Ultra Bold Condensed", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Bu_Int.Location = new System.Drawing.Point(252, 34);
            this.Bu_Int.Name = "Bu_Int";
            this.Bu_Int.Size = new System.Drawing.Size(262, 88);
            this.Bu_Int.TabIndex = 0;
            this.Bu_Int.Text = "&Increment";
            this.Bu_Int.UseVisualStyleBackColor = true;
            this.Bu_Int.Click += new System.EventHandler(this.Bu_Int_Click);
            // 
            // Bu_Rest
            // 
            this.Bu_Rest.Font = new System.Drawing.Font("Informal Roman", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Bu_Rest.Location = new System.Drawing.Point(252, 170);
            this.Bu_Rest.Name = "Bu_Rest";
            this.Bu_Rest.Size = new System.Drawing.Size(111, 58);
            this.Bu_Rest.TabIndex = 1;
            this.Bu_Rest.Text = "&Rest";
            this.Bu_Rest.UseVisualStyleBackColor = true;
            this.Bu_Rest.Click += new System.EventHandler(this.Bu_Rest_Click);
            // 
            // Bu_Exit
            // 
            this.Bu_Exit.Font = new System.Drawing.Font("Matura MT Script Capitals", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Bu_Exit.Location = new System.Drawing.Point(399, 170);
            this.Bu_Exit.Name = "Bu_Exit";
            this.Bu_Exit.Size = new System.Drawing.Size(115, 58);
            this.Bu_Exit.TabIndex = 2;
            this.Bu_Exit.Text = "&Exit";
            this.Bu_Exit.UseVisualStyleBackColor = true;
            this.Bu_Exit.Click += new System.EventHandler(this.Bu_Exit_Click);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 450);
            this.Controls.Add(this.Bu_Exit);
            this.Controls.Add(this.Bu_Rest);
            this.Controls.Add(this.Bu_Int);
            this.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "Form";
            this.Text = "標題";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Bu_Int;
        private System.Windows.Forms.Button Bu_Rest;
        private System.Windows.Forms.Button Bu_Exit;
    }
}

