
namespace Ch5_1_4
{
    partial class form1
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
            this.tb_message = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bt_add = new System.Windows.Forms.Button();
            this.tb_number = new System.Windows.Forms.TextBox();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_Female = new System.Windows.Forms.RadioButton();
            this.rb_Male = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rb_other = new System.Windows.Forms.RadioButton();
            this.rb_officical = new System.Windows.Forms.RadioButton();
            this.rb_Commerce = new System.Windows.Forms.RadioButton();
            this.bt_output = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_message
            // 
            this.tb_message.BackColor = System.Drawing.Color.White;
            this.tb_message.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tb_message.ForeColor = System.Drawing.Color.Black;
            this.tb_message.Location = new System.Drawing.Point(259, 329);
            this.tb_message.Multiline = true;
            this.tb_message.Name = "tb_message";
            this.tb_message.Size = new System.Drawing.Size(387, 174);
            this.tb_message.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Jokerman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(85, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 28);
            this.label1.TabIndex = 12;
            this.label1.Text = "Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label2.Font = new System.Drawing.Font("Jokerman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(683, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 28);
            this.label2.TabIndex = 16;
            this.label2.Text = "總人數 :";
            // 
            // bt_add
            // 
            this.bt_add.BackColor = System.Drawing.Color.Red;
            this.bt_add.Cursor = System.Windows.Forms.Cursors.Default;
            this.bt_add.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt_add.Location = new System.Drawing.Point(683, 40);
            this.bt_add.Name = "bt_add";
            this.bt_add.Size = new System.Drawing.Size(176, 145);
            this.bt_add.TabIndex = 17;
            this.bt_add.Text = "增加人員";
            this.bt_add.UseVisualStyleBackColor = false;
            this.bt_add.Click += new System.EventHandler(this.button1_Click);
            // 
            // tb_number
            // 
            this.tb_number.BackColor = System.Drawing.Color.White;
            this.tb_number.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_number.Location = new System.Drawing.Point(777, 210);
            this.tb_number.Name = "tb_number";
            this.tb_number.Size = new System.Drawing.Size(82, 30);
            this.tb_number.TabIndex = 18;
            // 
            // tb_name
            // 
            this.tb_name.BackColor = System.Drawing.Color.White;
            this.tb_name.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_name.Location = new System.Drawing.Point(192, 43);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(146, 30);
            this.tb_name.TabIndex = 19;
            this.tb_name.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_Female);
            this.groupBox1.Controls.Add(this.rb_Male);
            this.groupBox1.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(85, 91);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(210, 131);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "性別 :";
            // 
            // rb_Female
            // 
            this.rb_Female.AutoSize = true;
            this.rb_Female.Checked = true;
            this.rb_Female.Location = new System.Drawing.Point(20, 66);
            this.rb_Female.Name = "rb_Female";
            this.rb_Female.Size = new System.Drawing.Size(69, 23);
            this.rb_Female.TabIndex = 23;
            this.rb_Female.TabStop = true;
            this.rb_Female.Text = "女性";
            this.rb_Female.UseVisualStyleBackColor = true;
            // 
            // rb_Male
            // 
            this.rb_Male.AutoSize = true;
            this.rb_Male.Location = new System.Drawing.Point(20, 29);
            this.rb_Male.Name = "rb_Male";
            this.rb_Male.Size = new System.Drawing.Size(69, 23);
            this.rb_Male.TabIndex = 22;
            this.rb_Male.Text = "男性";
            this.rb_Male.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rb_other);
            this.groupBox2.Controls.Add(this.rb_officical);
            this.groupBox2.Controls.Add(this.rb_Commerce);
            this.groupBox2.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(342, 91);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(270, 220);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "職業 :";
            // 
            // rb_other
            // 
            this.rb_other.AutoSize = true;
            this.rb_other.Checked = true;
            this.rb_other.Location = new System.Drawing.Point(27, 108);
            this.rb_other.Name = "rb_other";
            this.rb_other.Size = new System.Drawing.Size(69, 23);
            this.rb_other.TabIndex = 26;
            this.rb_other.TabStop = true;
            this.rb_other.Text = "其他";
            this.rb_other.UseVisualStyleBackColor = true;
            // 
            // rb_officical
            // 
            this.rb_officical.AutoSize = true;
            this.rb_officical.Location = new System.Drawing.Point(27, 66);
            this.rb_officical.Name = "rb_officical";
            this.rb_officical.Size = new System.Drawing.Size(90, 23);
            this.rb_officical.TabIndex = 25;
            this.rb_officical.Text = "公務員";
            this.rb_officical.UseVisualStyleBackColor = true;
            // 
            // rb_Commerce
            // 
            this.rb_Commerce.AutoSize = true;
            this.rb_Commerce.Location = new System.Drawing.Point(27, 29);
            this.rb_Commerce.Name = "rb_Commerce";
            this.rb_Commerce.Size = new System.Drawing.Size(90, 23);
            this.rb_Commerce.TabIndex = 24;
            this.rb_Commerce.Text = "工商業";
            this.rb_Commerce.UseVisualStyleBackColor = true;
            // 
            // bt_output
            // 
            this.bt_output.BackColor = System.Drawing.Color.Red;
            this.bt_output.Cursor = System.Windows.Forms.Cursors.Default;
            this.bt_output.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt_output.Location = new System.Drawing.Point(65, 329);
            this.bt_output.Name = "bt_output";
            this.bt_output.Size = new System.Drawing.Size(176, 53);
            this.bt_output.TabIndex = 22;
            this.bt_output.Text = "列印人員";
            this.bt_output.UseVisualStyleBackColor = false;
            this.bt_output.Click += new System.EventHandler(this.bt_output_Click_1);
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 554);
            this.Controls.Add(this.bt_output);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.tb_number);
            this.Controls.Add(this.bt_add);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_message);
            this.Controls.Add(this.label1);
            this.Name = "form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tb_message;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bt_add;
        private System.Windows.Forms.TextBox tb_number;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb_Female;
        private System.Windows.Forms.RadioButton rb_Male;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rb_other;
        private System.Windows.Forms.RadioButton rb_officical;
        private System.Windows.Forms.RadioButton rb_Commerce;
        private System.Windows.Forms.Button bt_output;
    }
}

