
namespace Ch2_WinFormDemo
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
            this.text = new System.Windows.Forms.TextBox();
            this.button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft JhengHei UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label.Location = new System.Drawing.Point(132, 77);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(107, 44);
            this.label.TabIndex = 0;
            this.label.Text = "MSG:";
            this.label.Click += new System.EventHandler(this.label1_Click);
            // 
            // text
            // 
            this.text.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.text.Font = new System.Drawing.Font("標楷體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.text.Location = new System.Drawing.Point(263, 77);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(227, 40);
            this.text.TabIndex = 1;
            this.text.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button
            // 
            this.button.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button.Location = new System.Drawing.Point(263, 151);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(195, 63);
            this.button.TabIndex = 2;
            this.button.Text = "Welcome";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button);
            this.Controls.Add(this.text);
            this.Controls.Add(this.label);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox text;
        public System.Windows.Forms.Button button;
    }
}

