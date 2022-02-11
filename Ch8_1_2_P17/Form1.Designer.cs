
namespace Ch8_1_2_P17
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
            this.label2 = new System.Windows.Forms.Label();
            this.bt_search = new System.Windows.Forms.Button();
            this.bt_replace = new System.Windows.Forms.Button();
            this.tb_search = new System.Windows.Forms.TextBox();
            this.tb_replace = new System.Windows.Forms.TextBox();
            this.tb_MSG = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(154, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "搜尋字串";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(154, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "取代字串";
            // 
            // bt_search
            // 
            this.bt_search.Location = new System.Drawing.Point(591, 94);
            this.bt_search.Name = "bt_search";
            this.bt_search.Size = new System.Drawing.Size(161, 47);
            this.bt_search.TabIndex = 1;
            this.bt_search.Text = "搜尋";
            this.bt_search.UseVisualStyleBackColor = true;
            this.bt_search.Click += new System.EventHandler(this.bt_search_Click);
            // 
            // bt_replace
            // 
            this.bt_replace.Location = new System.Drawing.Point(591, 150);
            this.bt_replace.Name = "bt_replace";
            this.bt_replace.Size = new System.Drawing.Size(161, 47);
            this.bt_replace.TabIndex = 1;
            this.bt_replace.Text = "取代";
            this.bt_replace.UseVisualStyleBackColor = true;
            this.bt_replace.Click += new System.EventHandler(this.bt_replace_Click);
            // 
            // tb_search
            // 
            this.tb_search.Location = new System.Drawing.Point(297, 94);
            this.tb_search.Name = "tb_search";
            this.tb_search.Size = new System.Drawing.Size(189, 32);
            this.tb_search.TabIndex = 2;
            // 
            // tb_replace
            // 
            this.tb_replace.Location = new System.Drawing.Point(297, 165);
            this.tb_replace.Name = "tb_replace";
            this.tb_replace.Size = new System.Drawing.Size(189, 32);
            this.tb_replace.TabIndex = 2;
            // 
            // tb_MSG
            // 
            this.tb_MSG.Location = new System.Drawing.Point(154, 258);
            this.tb_MSG.Multiline = true;
            this.tb_MSG.Name = "tb_MSG";
            this.tb_MSG.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_MSG.Size = new System.Drawing.Size(598, 211);
            this.tb_MSG.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 720);
            this.Controls.Add(this.tb_MSG);
            this.Controls.Add(this.tb_replace);
            this.Controls.Add(this.tb_search);
            this.Controls.Add(this.bt_replace);
            this.Controls.Add(this.bt_search);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bt_search;
        private System.Windows.Forms.Button bt_replace;
        private System.Windows.Forms.TextBox tb_search;
        private System.Windows.Forms.TextBox tb_replace;
        private System.Windows.Forms.TextBox tb_MSG;
    }
}

