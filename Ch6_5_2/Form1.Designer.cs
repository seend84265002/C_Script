
namespace Ch6_5_2
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
            this.bt_even_add = new System.Windows.Forms.Button();
            this.bt_odd_Add = new System.Windows.Forms.Button();
            this.tb_MSB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "最大值:";
            // 
            // tb_input
            // 
            this.tb_input.Location = new System.Drawing.Point(206, 71);
            this.tb_input.Name = "tb_input";
            this.tb_input.Size = new System.Drawing.Size(100, 28);
            this.tb_input.TabIndex = 1;
            // 
            // bt_even_add
            // 
            this.bt_even_add.Location = new System.Drawing.Point(366, 21);
            this.bt_even_add.Name = "bt_even_add";
            this.bt_even_add.Size = new System.Drawing.Size(156, 49);
            this.bt_even_add.TabIndex = 2;
            this.bt_even_add.Text = "偶數和";
            this.bt_even_add.UseVisualStyleBackColor = true;
            this.bt_even_add.Click += new System.EventHandler(this.bt_even_add_Click);
            // 
            // bt_odd_Add
            // 
            this.bt_odd_Add.Location = new System.Drawing.Point(366, 100);
            this.bt_odd_Add.Name = "bt_odd_Add";
            this.bt_odd_Add.Size = new System.Drawing.Size(156, 49);
            this.bt_odd_Add.TabIndex = 2;
            this.bt_odd_Add.Text = "奇數和";
            this.bt_odd_Add.UseVisualStyleBackColor = true;
            this.bt_odd_Add.Click += new System.EventHandler(this.bt_odd_Add_Click);
            // 
            // tb_MSB
            // 
            this.tb_MSB.Location = new System.Drawing.Point(83, 178);
            this.tb_MSB.Multiline = true;
            this.tb_MSB.Name = "tb_MSB";
            this.tb_MSB.ReadOnly = true;
            this.tb_MSB.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_MSB.Size = new System.Drawing.Size(439, 218);
            this.tb_MSB.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 600);
            this.Controls.Add(this.tb_MSB);
            this.Controls.Add(this.bt_odd_Add);
            this.Controls.Add(this.bt_even_add);
            this.Controls.Add(this.tb_input);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "計算偶數奇數";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_input;
        private System.Windows.Forms.Button bt_even_add;
        private System.Windows.Forms.Button bt_odd_Add;
        private System.Windows.Forms.TextBox tb_MSB;
    }
}

