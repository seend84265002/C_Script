
namespace Ch6_5_1
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
            this.tb_money = new System.Windows.Forms.TextBox();
            this.bt_intput = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_5 = new System.Windows.Forms.CheckBox();
            this.tb_1 = new System.Windows.Forms.TextBox();
            this.tb_5 = new System.Windows.Forms.TextBox();
            this.tb_10 = new System.Windows.Forms.TextBox();
            this.tb_20 = new System.Windows.Forms.TextBox();
            this.tb_50 = new System.Windows.Forms.TextBox();
            this.cb_10 = new System.Windows.Forms.CheckBox();
            this.cb_20 = new System.Windows.Forms.CheckBox();
            this.cb_50 = new System.Windows.Forms.CheckBox();
            this.lb_1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(127, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "兌換金額$:";
            // 
            // tb_money
            // 
            this.tb_money.Location = new System.Drawing.Point(219, 106);
            this.tb_money.Name = "tb_money";
            this.tb_money.Size = new System.Drawing.Size(216, 28);
            this.tb_money.TabIndex = 1;
            // 
            // bt_intput
            // 
            this.bt_intput.Location = new System.Drawing.Point(470, 90);
            this.bt_intput.Name = "bt_intput";
            this.bt_intput.Size = new System.Drawing.Size(130, 59);
            this.bt_intput.TabIndex = 2;
            this.bt_intput.Text = "兌換硬幣";
            this.bt_intput.UseVisualStyleBackColor = true;
            this.bt_intput.Click += new System.EventHandler(this.bt_intput_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_5);
            this.groupBox1.Controls.Add(this.tb_1);
            this.groupBox1.Controls.Add(this.tb_5);
            this.groupBox1.Controls.Add(this.lb_1);
            this.groupBox1.Controls.Add(this.tb_10);
            this.groupBox1.Controls.Add(this.tb_20);
            this.groupBox1.Controls.Add(this.tb_50);
            this.groupBox1.Controls.Add(this.cb_10);
            this.groupBox1.Controls.Add(this.cb_20);
            this.groupBox1.Controls.Add(this.cb_50);
            this.groupBox1.Location = new System.Drawing.Point(95, 164);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(542, 169);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "兌換種類";
            // 
            // cb_5
            // 
            this.cb_5.AutoSize = true;
            this.cb_5.Location = new System.Drawing.Point(302, 42);
            this.cb_5.Name = "cb_5";
            this.cb_5.Size = new System.Drawing.Size(46, 24);
            this.cb_5.TabIndex = 0;
            this.cb_5.Text = "$5";
            this.cb_5.UseVisualStyleBackColor = true;
            // 
            // tb_1
            // 
            this.tb_1.Location = new System.Drawing.Point(397, 92);
            this.tb_1.Name = "tb_1";
            this.tb_1.Size = new System.Drawing.Size(76, 28);
            this.tb_1.TabIndex = 1;
            // 
            // tb_5
            // 
            this.tb_5.Location = new System.Drawing.Point(302, 92);
            this.tb_5.Name = "tb_5";
            this.tb_5.Size = new System.Drawing.Size(76, 28);
            this.tb_5.TabIndex = 1;
            // 
            // tb_10
            // 
            this.tb_10.Location = new System.Drawing.Point(206, 92);
            this.tb_10.Name = "tb_10";
            this.tb_10.Size = new System.Drawing.Size(76, 28);
            this.tb_10.TabIndex = 1;
            // 
            // tb_20
            // 
            this.tb_20.Location = new System.Drawing.Point(114, 92);
            this.tb_20.Name = "tb_20";
            this.tb_20.Size = new System.Drawing.Size(76, 28);
            this.tb_20.TabIndex = 1;
            // 
            // tb_50
            // 
            this.tb_50.Location = new System.Drawing.Point(14, 92);
            this.tb_50.Name = "tb_50";
            this.tb_50.Size = new System.Drawing.Size(76, 28);
            this.tb_50.TabIndex = 1;
            // 
            // cb_10
            // 
            this.cb_10.AutoSize = true;
            this.cb_10.Location = new System.Drawing.Point(206, 42);
            this.cb_10.Name = "cb_10";
            this.cb_10.Size = new System.Drawing.Size(55, 24);
            this.cb_10.TabIndex = 0;
            this.cb_10.Text = "$10";
            this.cb_10.UseVisualStyleBackColor = true;
            // 
            // cb_20
            // 
            this.cb_20.AutoSize = true;
            this.cb_20.Location = new System.Drawing.Point(114, 42);
            this.cb_20.Name = "cb_20";
            this.cb_20.Size = new System.Drawing.Size(55, 24);
            this.cb_20.TabIndex = 0;
            this.cb_20.Text = "$20";
            this.cb_20.UseVisualStyleBackColor = true;
            // 
            // cb_50
            // 
            this.cb_50.AutoSize = true;
            this.cb_50.Location = new System.Drawing.Point(14, 42);
            this.cb_50.Name = "cb_50";
            this.cb_50.Size = new System.Drawing.Size(55, 24);
            this.cb_50.TabIndex = 0;
            this.cb_50.Text = "$50";
            this.cb_50.UseVisualStyleBackColor = true;
            // 
            // lb_1
            // 
            this.lb_1.AutoSize = true;
            this.lb_1.Location = new System.Drawing.Point(397, 43);
            this.lb_1.Name = "lb_1";
            this.lb_1.Size = new System.Drawing.Size(27, 20);
            this.lb_1.TabIndex = 0;
            this.lb_1.Text = "$1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 460);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bt_intput);
            this.Controls.Add(this.tb_money);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_money;
        private System.Windows.Forms.Button bt_intput;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cb_5;
        private System.Windows.Forms.TextBox tb_1;
        private System.Windows.Forms.TextBox tb_5;
        private System.Windows.Forms.TextBox tb_10;
        private System.Windows.Forms.TextBox tb_20;
        private System.Windows.Forms.TextBox tb_50;
        private System.Windows.Forms.CheckBox cb_10;
        private System.Windows.Forms.CheckBox cb_20;
        private System.Windows.Forms.CheckBox cb_50;
        private System.Windows.Forms.Label lb_1;
    }
}

