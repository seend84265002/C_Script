
namespace Ch5_1_1
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
            this.tb_temp = new System.Windows.Forms.TextBox();
            this.tb_message = new System.Windows.Forms.TextBox();
            this.bt_jud = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Red;
            this.label1.Font = new System.Drawing.Font("Jokerman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(107, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "輸入溫度:";
            // 
            // tb_temp
            // 
            this.tb_temp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tb_temp.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_temp.Location = new System.Drawing.Point(216, 105);
            this.tb_temp.Name = "tb_temp";
            this.tb_temp.Size = new System.Drawing.Size(146, 30);
            this.tb_temp.TabIndex = 1;
            // 
            // tb_message
            // 
            this.tb_message.BackColor = System.Drawing.Color.Yellow;
            this.tb_message.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tb_message.ForeColor = System.Drawing.Color.Red;
            this.tb_message.Location = new System.Drawing.Point(107, 146);
            this.tb_message.Multiline = true;
            this.tb_message.Name = "tb_message";
            this.tb_message.Size = new System.Drawing.Size(357, 174);
            this.tb_message.TabIndex = 2;
            // 
            // bt_jud
            // 
            this.bt_jud.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt_jud.Location = new System.Drawing.Point(368, 104);
            this.bt_jud.Name = "bt_jud";
            this.bt_jud.Size = new System.Drawing.Size(96, 31);
            this.bt_jud.TabIndex = 3;
            this.bt_jud.Text = "判斷";
            this.bt_jud.UseVisualStyleBackColor = true;
            this.bt_jud.Click += new System.EventHandler(this.bt_jud_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt_jud);
            this.Controls.Add(this.tb_message);
            this.Controls.Add(this.tb_temp);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "感冒預防器";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_temp;
        private System.Windows.Forms.TextBox tb_message;
        private System.Windows.Forms.Button bt_jud;
    }
}

