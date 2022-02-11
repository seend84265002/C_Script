
namespace Ch6_4_1
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
            this.bt_Triangle = new System.Windows.Forms.Button();
            this.bt_Triangle_In = new System.Windows.Forms.Button();
            this.bt_Triangle_Eq = new System.Windows.Forms.Button();
            this.tx_MSG = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bt_Triangle
            // 
            this.bt_Triangle.Location = new System.Drawing.Point(92, 572);
            this.bt_Triangle.Name = "bt_Triangle";
            this.bt_Triangle.Size = new System.Drawing.Size(178, 65);
            this.bt_Triangle.TabIndex = 0;
            this.bt_Triangle.Text = "三角形";
            this.bt_Triangle.UseVisualStyleBackColor = true;
            this.bt_Triangle.Click += new System.EventHandler(this.bt_Triangle_Click);
            // 
            // bt_Triangle_In
            // 
            this.bt_Triangle_In.Location = new System.Drawing.Point(323, 572);
            this.bt_Triangle_In.Name = "bt_Triangle_In";
            this.bt_Triangle_In.Size = new System.Drawing.Size(178, 65);
            this.bt_Triangle_In.TabIndex = 0;
            this.bt_Triangle_In.Text = "倒三角形";
            this.bt_Triangle_In.UseVisualStyleBackColor = true;
            this.bt_Triangle_In.Click += new System.EventHandler(this.bt_Triangle_In_Click);
            // 
            // bt_Triangle_Eq
            // 
            this.bt_Triangle_Eq.Location = new System.Drawing.Point(556, 572);
            this.bt_Triangle_Eq.Name = "bt_Triangle_Eq";
            this.bt_Triangle_Eq.Size = new System.Drawing.Size(178, 65);
            this.bt_Triangle_Eq.TabIndex = 0;
            this.bt_Triangle_Eq.Text = "正三角形";
            this.bt_Triangle_Eq.UseVisualStyleBackColor = true;
            this.bt_Triangle_Eq.Click += new System.EventHandler(this.bt_Triangle_Eq_Click);
            // 
            // tx_MSG
            // 
            this.tx_MSG.Location = new System.Drawing.Point(101, 69);
            this.tx_MSG.Multiline = true;
            this.tx_MSG.Name = "tx_MSG";
            this.tx_MSG.ReadOnly = true;
            this.tx_MSG.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tx_MSG.Size = new System.Drawing.Size(633, 443);
            this.tx_MSG.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 683);
            this.Controls.Add(this.tx_MSG);
            this.Controls.Add(this.bt_Triangle_Eq);
            this.Controls.Add(this.bt_Triangle_In);
            this.Controls.Add(this.bt_Triangle);
            this.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.Text = "繪製數字三角形";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_Triangle;
        private System.Windows.Forms.Button bt_Triangle_In;
        private System.Windows.Forms.Button bt_Triangle_Eq;
        private System.Windows.Forms.TextBox tx_MSG;
    }
}

