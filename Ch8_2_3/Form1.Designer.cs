
namespace Ch8_2_3
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
            this.bt_name = new System.Windows.Forms.Button();
            this.bt_Score = new System.Windows.Forms.Button();
            this.tb_MSG = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bt_name
            // 
            this.bt_name.Location = new System.Drawing.Point(134, 78);
            this.bt_name.Name = "bt_name";
            this.bt_name.Size = new System.Drawing.Size(222, 96);
            this.bt_name.TabIndex = 0;
            this.bt_name.Text = "顯示成績清單";
            this.bt_name.UseVisualStyleBackColor = true;
            this.bt_name.Click += new System.EventHandler(this.bt_name_Click);
            // 
            // bt_Score
            // 
            this.bt_Score.Location = new System.Drawing.Point(464, 78);
            this.bt_Score.Name = "bt_Score";
            this.bt_Score.Size = new System.Drawing.Size(222, 96);
            this.bt_Score.TabIndex = 0;
            this.bt_Score.Text = "計算平均總合";
            this.bt_Score.UseVisualStyleBackColor = true;
            this.bt_Score.Click += new System.EventHandler(this.bt_Score_Click);
            // 
            // tb_MSG
            // 
            this.tb_MSG.Location = new System.Drawing.Point(134, 208);
            this.tb_MSG.Multiline = true;
            this.tb_MSG.Name = "tb_MSG";
            this.tb_MSG.Size = new System.Drawing.Size(552, 234);
            this.tb_MSG.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 565);
            this.Controls.Add(this.tb_MSG);
            this.Controls.Add(this.bt_Score);
            this.Controls.Add(this.bt_name);
            this.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_name;
        private System.Windows.Forms.Button bt_Score;
        private System.Windows.Forms.TextBox tb_MSG;
    }
}

