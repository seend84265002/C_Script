
namespace Ch5_1_2
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
            this.bt_jud = new System.Windows.Forms.Button();
            this.tb_message = new System.Windows.Forms.TextBox();
            this.tb_score = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bt_jud
            // 
            this.bt_jud.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt_jud.Location = new System.Drawing.Point(385, 79);
            this.bt_jud.Name = "bt_jud";
            this.bt_jud.Size = new System.Drawing.Size(96, 31);
            this.bt_jud.TabIndex = 7;
            this.bt_jud.Text = "判斷";
            this.bt_jud.UseVisualStyleBackColor = true;
            this.bt_jud.Click += new System.EventHandler(this.bt_jud_Click);
            // 
            // tb_message
            // 
            this.tb_message.BackColor = System.Drawing.Color.Yellow;
            this.tb_message.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tb_message.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.tb_message.Location = new System.Drawing.Point(118, 124);
            this.tb_message.Multiline = true;
            this.tb_message.Name = "tb_message";
            this.tb_message.Size = new System.Drawing.Size(357, 174);
            this.tb_message.TabIndex = 6;
            // 
            // tb_score
            // 
            this.tb_score.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tb_score.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_score.Location = new System.Drawing.Point(233, 80);
            this.tb_score.Name = "tb_score";
            this.tb_score.Size = new System.Drawing.Size(146, 30);
            this.tb_score.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SeaGreen;
            this.label1.Font = new System.Drawing.Font("Jokerman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(118, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 28);
            this.label1.TabIndex = 4;
            this.label1.Text = "學生分數 :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt_jud);
            this.Controls.Add(this.tb_message);
            this.Controls.Add(this.tb_score);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "成績判斷";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_jud;
        private System.Windows.Forms.TextBox tb_message;
        private System.Windows.Forms.TextBox tb_score;
        private System.Windows.Forms.Label label1;
    }
}

