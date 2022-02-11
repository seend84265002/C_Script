
namespace Ch5_1_7
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
            this.bt_select = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rb_all = new System.Windows.Forms.RadioButton();
            this.rb_seven = new System.Windows.Forms.RadioButton();
            this.rb_five = new System.Windows.Forms.RadioButton();
            this.rb_three = new System.Windows.Forms.RadioButton();
            this.tb_message = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_select
            // 
            this.bt_select.BackColor = System.Drawing.Color.Red;
            this.bt_select.Cursor = System.Windows.Forms.Cursors.Default;
            this.bt_select.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt_select.Location = new System.Drawing.Point(86, 139);
            this.bt_select.Name = "bt_select";
            this.bt_select.Size = new System.Drawing.Size(176, 53);
            this.bt_select.TabIndex = 25;
            this.bt_select.Text = "選擇";
            this.bt_select.UseVisualStyleBackColor = false;
            this.bt_select.Click += new System.EventHandler(this.bt_select_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rb_all);
            this.groupBox2.Controls.Add(this.rb_seven);
            this.groupBox2.Controls.Add(this.rb_five);
            this.groupBox2.Controls.Add(this.rb_three);
            this.groupBox2.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(86, 38);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(486, 75);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            // 
            // rb_all
            // 
            this.rb_all.AutoSize = true;
            this.rb_all.Checked = true;
            this.rb_all.Location = new System.Drawing.Point(354, 29);
            this.rb_all.Name = "rb_all";
            this.rb_all.Size = new System.Drawing.Size(69, 23);
            this.rb_all.TabIndex = 26;
            this.rb_all.Text = "全熟";
            this.rb_all.UseVisualStyleBackColor = true;
            // 
            // rb_seven
            // 
            this.rb_seven.AutoSize = true;
            this.rb_seven.Location = new System.Drawing.Point(246, 29);
            this.rb_seven.Name = "rb_seven";
            this.rb_seven.Size = new System.Drawing.Size(90, 23);
            this.rb_seven.TabIndex = 26;
            this.rb_seven.Text = "七分熟";
            this.rb_seven.UseVisualStyleBackColor = true;
            // 
            // rb_five
            // 
            this.rb_five.AutoSize = true;
            this.rb_five.Location = new System.Drawing.Point(133, 29);
            this.rb_five.Name = "rb_five";
            this.rb_five.Size = new System.Drawing.Size(90, 23);
            this.rb_five.TabIndex = 25;
            this.rb_five.Text = "五分熟";
            this.rb_five.UseVisualStyleBackColor = true;
            // 
            // rb_three
            // 
            this.rb_three.AutoSize = true;
            this.rb_three.Location = new System.Drawing.Point(27, 29);
            this.rb_three.Name = "rb_three";
            this.rb_three.Size = new System.Drawing.Size(90, 23);
            this.rb_three.TabIndex = 24;
            this.rb_three.Text = "三分熟";
            this.rb_three.UseVisualStyleBackColor = true;
            // 
            // tb_message
            // 
            this.tb_message.BackColor = System.Drawing.Color.White;
            this.tb_message.Font = new System.Drawing.Font("標楷體", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tb_message.ForeColor = System.Drawing.Color.Black;
            this.tb_message.Location = new System.Drawing.Point(268, 139);
            this.tb_message.Multiline = true;
            this.tb_message.Name = "tb_message";
            this.tb_message.Size = new System.Drawing.Size(304, 53);
            this.tb_message.TabIndex = 23;
            this.tb_message.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt_select);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.tb_message);
            this.Name = "Form1";
            this.Text = "選擇牛排要幾分熟";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_select;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rb_all;
        private System.Windows.Forms.RadioButton rb_seven;
        private System.Windows.Forms.RadioButton rb_five;
        private System.Windows.Forms.RadioButton rb_three;
        private System.Windows.Forms.TextBox tb_message;
    }
}

