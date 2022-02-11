
namespace Ch8_5_2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tb_4 = new System.Windows.Forms.TextBox();
            this.tb_3 = new System.Windows.Forms.TextBox();
            this.tb_2 = new System.Windows.Forms.TextBox();
            this.tb_1 = new System.Windows.Forms.TextBox();
            this.tb_0 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_Search = new System.Windows.Forms.Button();
            this.bt_LinearSearch = new System.Windows.Forms.Button();
            this.tb_MSG = new System.Windows.Forms.TextBox();
            this.tb_input = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.tb_4);
            this.groupBox1.Controls.Add(this.tb_3);
            this.groupBox1.Controls.Add(this.tb_2);
            this.groupBox1.Controls.Add(this.tb_1);
            this.groupBox1.Controls.Add(this.tb_0);
            this.groupBox1.Location = new System.Drawing.Point(31, 39);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1141, 119);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "陣列排序";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(913, 40);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 55);
            this.button1.TabIndex = 1;
            this.button1.Text = "排序";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tb_4
            // 
            this.tb_4.Location = new System.Drawing.Point(709, 53);
            this.tb_4.Margin = new System.Windows.Forms.Padding(4);
            this.tb_4.Name = "tb_4";
            this.tb_4.Size = new System.Drawing.Size(141, 28);
            this.tb_4.TabIndex = 0;
            // 
            // tb_3
            // 
            this.tb_3.Location = new System.Drawing.Point(533, 53);
            this.tb_3.Margin = new System.Windows.Forms.Padding(4);
            this.tb_3.Name = "tb_3";
            this.tb_3.Size = new System.Drawing.Size(141, 28);
            this.tb_3.TabIndex = 0;
            // 
            // tb_2
            // 
            this.tb_2.Location = new System.Drawing.Point(369, 53);
            this.tb_2.Margin = new System.Windows.Forms.Padding(4);
            this.tb_2.Name = "tb_2";
            this.tb_2.Size = new System.Drawing.Size(141, 28);
            this.tb_2.TabIndex = 0;
            // 
            // tb_1
            // 
            this.tb_1.Location = new System.Drawing.Point(200, 53);
            this.tb_1.Margin = new System.Windows.Forms.Padding(4);
            this.tb_1.Name = "tb_1";
            this.tb_1.Size = new System.Drawing.Size(141, 28);
            this.tb_1.TabIndex = 0;
            // 
            // tb_0
            // 
            this.tb_0.Location = new System.Drawing.Point(36, 53);
            this.tb_0.Margin = new System.Windows.Forms.Padding(4);
            this.tb_0.Name = "tb_0";
            this.tb_0.Size = new System.Drawing.Size(141, 28);
            this.tb_0.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.bt_Search);
            this.groupBox2.Controls.Add(this.bt_LinearSearch);
            this.groupBox2.Controls.Add(this.tb_MSG);
            this.groupBox2.Controls.Add(this.tb_input);
            this.groupBox2.Location = new System.Drawing.Point(31, 177);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(907, 279);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "陣列搜尋";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "鍵值";
            // 
            // bt_Search
            // 
            this.bt_Search.Location = new System.Drawing.Point(653, 29);
            this.bt_Search.Margin = new System.Windows.Forms.Padding(4);
            this.bt_Search.Name = "bt_Search";
            this.bt_Search.Size = new System.Drawing.Size(156, 61);
            this.bt_Search.TabIndex = 1;
            this.bt_Search.Text = "二元搜尋";
            this.bt_Search.UseVisualStyleBackColor = true;
            this.bt_Search.Click += new System.EventHandler(this.bt_Search_Click);
            // 
            // bt_LinearSearch
            // 
            this.bt_LinearSearch.Location = new System.Drawing.Point(427, 29);
            this.bt_LinearSearch.Margin = new System.Windows.Forms.Padding(4);
            this.bt_LinearSearch.Name = "bt_LinearSearch";
            this.bt_LinearSearch.Size = new System.Drawing.Size(156, 61);
            this.bt_LinearSearch.TabIndex = 1;
            this.bt_LinearSearch.Text = "線性搜尋";
            this.bt_LinearSearch.UseVisualStyleBackColor = true;
            this.bt_LinearSearch.Click += new System.EventHandler(this.bt_LinearSearch_Click);
            // 
            // tb_MSG
            // 
            this.tb_MSG.Location = new System.Drawing.Point(54, 181);
            this.tb_MSG.Margin = new System.Windows.Forms.Padding(4);
            this.tb_MSG.Name = "tb_MSG";
            this.tb_MSG.Size = new System.Drawing.Size(753, 28);
            this.tb_MSG.TabIndex = 0;
            // 
            // tb_input
            // 
            this.tb_input.Location = new System.Drawing.Point(169, 49);
            this.tb_input.Margin = new System.Windows.Forms.Padding(4);
            this.tb_input.Name = "tb_input";
            this.tb_input.Size = new System.Drawing.Size(141, 28);
            this.tb_input.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1252, 592);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tb_4;
        private System.Windows.Forms.TextBox tb_3;
        private System.Windows.Forms.TextBox tb_2;
        private System.Windows.Forms.TextBox tb_1;
        private System.Windows.Forms.TextBox tb_0;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_Search;
        private System.Windows.Forms.Button bt_LinearSearch;
        private System.Windows.Forms.TextBox tb_MSG;
        private System.Windows.Forms.TextBox tb_input;
    }
}

