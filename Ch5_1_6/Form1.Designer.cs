
namespace Ch5_1_6
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
            this.tb_quantity = new System.Windows.Forms.TextBox();
            this.bt_output = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_message = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_price = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_deice = new System.Windows.Forms.CheckBox();
            this.cb_sweeten = new System.Windows.Forms.CheckBox();
            this.cb_addpearl = new System.Windows.Forms.CheckBox();
            this.cb_addAiyu = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_quantity
            // 
            this.tb_quantity.BackColor = System.Drawing.Color.White;
            this.tb_quantity.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_quantity.Location = new System.Drawing.Point(381, 83);
            this.tb_quantity.Name = "tb_quantity";
            this.tb_quantity.Size = new System.Drawing.Size(82, 30);
            this.tb_quantity.TabIndex = 27;
            // 
            // bt_output
            // 
            this.bt_output.BackColor = System.Drawing.Color.Red;
            this.bt_output.Cursor = System.Windows.Forms.Cursors.Default;
            this.bt_output.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt_output.Location = new System.Drawing.Point(378, 169);
            this.bt_output.Name = "bt_output";
            this.bt_output.Size = new System.Drawing.Size(85, 197);
            this.bt_output.TabIndex = 26;
            this.bt_output.Text = "結帳";
            this.bt_output.UseVisualStyleBackColor = false;
            this.bt_output.Click += new System.EventHandler(this.bt_output_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label2.Font = new System.Drawing.Font("Jokerman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(295, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 28);
            this.label2.TabIndex = 25;
            this.label2.Text = "數量 :";
            // 
            // tb_message
            // 
            this.tb_message.BackColor = System.Drawing.Color.Black;
            this.tb_message.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tb_message.ForeColor = System.Drawing.Color.White;
            this.tb_message.Location = new System.Drawing.Point(162, 382);
            this.tb_message.Name = "tb_message";
            this.tb_message.Size = new System.Drawing.Size(301, 30);
            this.tb_message.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Jokerman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(76, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 28);
            this.label1.TabIndex = 28;
            this.label1.Text = "單價 :";
            // 
            // tb_price
            // 
            this.tb_price.BackColor = System.Drawing.Color.White;
            this.tb_price.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_price.Location = new System.Drawing.Point(162, 85);
            this.tb_price.Name = "tb_price";
            this.tb_price.Size = new System.Drawing.Size(82, 30);
            this.tb_price.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label3.Font = new System.Drawing.Font("Jokerman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(76, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 28);
            this.label3.TabIndex = 25;
            this.label3.Text = "選項 :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_addAiyu);
            this.groupBox1.Controls.Add(this.cb_addpearl);
            this.groupBox1.Controls.Add(this.cb_sweeten);
            this.groupBox1.Controls.Add(this.cb_deice);
            this.groupBox1.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(162, 160);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 206);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Menu";
            // 
            // cb_deice
            // 
            this.cb_deice.AutoSize = true;
            this.cb_deice.Location = new System.Drawing.Point(22, 26);
            this.cb_deice.Name = "cb_deice";
            this.cb_deice.Size = new System.Drawing.Size(78, 20);
            this.cb_deice.TabIndex = 31;
            this.cb_deice.Text = "去冰$0";
            this.cb_deice.UseVisualStyleBackColor = true;
            // 
            // cb_sweeten
            // 
            this.cb_sweeten.AutoSize = true;
            this.cb_sweeten.Location = new System.Drawing.Point(22, 52);
            this.cb_sweeten.Name = "cb_sweeten";
            this.cb_sweeten.Size = new System.Drawing.Size(78, 20);
            this.cb_sweeten.TabIndex = 31;
            this.cb_sweeten.Text = "加糖$5";
            this.cb_sweeten.UseVisualStyleBackColor = true;
            // 
            // cb_addpearl
            // 
            this.cb_addpearl.AutoSize = true;
            this.cb_addpearl.Location = new System.Drawing.Point(22, 78);
            this.cb_addpearl.Name = "cb_addpearl";
            this.cb_addpearl.Size = new System.Drawing.Size(104, 20);
            this.cb_addpearl.TabIndex = 31;
            this.cb_addpearl.Text = "加珍珠$10";
            this.cb_addpearl.UseVisualStyleBackColor = true;
            // 
            // cb_addAiyu
            // 
            this.cb_addAiyu.AutoSize = true;
            this.cb_addAiyu.Location = new System.Drawing.Point(22, 104);
            this.cb_addAiyu.Name = "cb_addAiyu";
            this.cb_addAiyu.Size = new System.Drawing.Size(104, 20);
            this.cb_addAiyu.TabIndex = 31;
            this.cb_addAiyu.Text = "加愛玉$15";
            this.cb_addAiyu.UseVisualStyleBackColor = true;
            this.cb_addAiyu.CheckedChanged += new System.EventHandler(this.cb_04_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label4.Cursor = System.Windows.Forms.Cursors.Default;
            this.label4.Font = new System.Drawing.Font("Jokerman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(76, 382);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 28);
            this.label4.TabIndex = 25;
            this.label4.Text = "價錢 :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 500);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tb_price);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_quantity);
            this.Controls.Add(this.bt_output);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_message);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_quantity;
        private System.Windows.Forms.Button bt_output;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_message;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_price;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cb_addAiyu;
        private System.Windows.Forms.CheckBox cb_addpearl;
        private System.Windows.Forms.CheckBox cb_sweeten;
        private System.Windows.Forms.CheckBox cb_deice;
        private System.Windows.Forms.Label label4;
    }
}

