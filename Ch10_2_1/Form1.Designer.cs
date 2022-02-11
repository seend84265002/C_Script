
namespace Ch10_2_1
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
            this.bt_Person_Info = new System.Windows.Forms.Button();
            this.bt_Student_Info = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_number = new System.Windows.Forms.TextBox();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.tb_score = new System.Windows.Forms.TextBox();
            this.tb_MSG = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_Person_Info
            // 
            this.bt_Person_Info.Location = new System.Drawing.Point(395, 45);
            this.bt_Person_Info.Name = "bt_Person_Info";
            this.bt_Person_Info.Size = new System.Drawing.Size(144, 74);
            this.bt_Person_Info.TabIndex = 0;
            this.bt_Person_Info.Text = "Person物件";
            this.bt_Person_Info.UseVisualStyleBackColor = true;
            this.bt_Person_Info.Click += new System.EventHandler(this.bt_Person_Info_Click);
            // 
            // bt_Student_Info
            // 
            this.bt_Student_Info.Location = new System.Drawing.Point(395, 128);
            this.bt_Student_Info.Name = "bt_Student_Info";
            this.bt_Student_Info.Size = new System.Drawing.Size(144, 74);
            this.bt_Student_Info.TabIndex = 0;
            this.bt_Student_Info.Text = "Student物件";
            this.bt_Student_Info.UseVisualStyleBackColor = true;
            this.bt_Student_Info.Click += new System.EventHandler(this.bt_Student_Info_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(121, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "編號:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(121, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "姓名:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(121, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "成績:";
            // 
            // tb_number
            // 
            this.tb_number.Location = new System.Drawing.Point(189, 70);
            this.tb_number.Name = "tb_number";
            this.tb_number.Size = new System.Drawing.Size(178, 30);
            this.tb_number.TabIndex = 2;
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(189, 128);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(178, 30);
            this.tb_name.TabIndex = 2;
            // 
            // tb_score
            // 
            this.tb_score.Location = new System.Drawing.Point(189, 194);
            this.tb_score.Name = "tb_score";
            this.tb_score.Size = new System.Drawing.Size(178, 30);
            this.tb_score.TabIndex = 2;
            // 
            // tb_MSG
            // 
            this.tb_MSG.Location = new System.Drawing.Point(121, 274);
            this.tb_MSG.Multiline = true;
            this.tb_MSG.Name = "tb_MSG";
            this.tb_MSG.ReadOnly = true;
            this.tb_MSG.Size = new System.Drawing.Size(446, 178);
            this.tb_MSG.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(395, 213);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 37);
            this.button1.TabIndex = 3;
            this.button1.Text = "清除";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 588);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tb_MSG);
            this.Controls.Add(this.tb_score);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.tb_number);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_Student_Info);
            this.Controls.Add(this.bt_Person_Info);
            this.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.Text = "顯示個人與學生資料";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_Person_Info;
        private System.Windows.Forms.Button bt_Student_Info;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_number;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.TextBox tb_score;
        private System.Windows.Forms.TextBox tb_MSG;
        private System.Windows.Forms.Button button1;
    }
}

