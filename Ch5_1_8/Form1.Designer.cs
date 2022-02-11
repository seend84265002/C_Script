
namespace Ch5_1_8
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
            this.rb_drinks_blacktea = new System.Windows.Forms.RadioButton();
            this.gb_m = new System.Windows.Forms.GroupBox();
            this.cb_Quiche = new System.Windows.Forms.CheckBox();
            this.cb_hamburgeradd = new System.Windows.Forms.CheckBox();
            this.cb_sandwich = new System.Windows.Forms.CheckBox();
            this.cb_hamburger = new System.Windows.Forms.CheckBox();
            this.bt_output = new System.Windows.Forms.Button();
            this.tb_price = new System.Windows.Forms.TextBox();
            this.gb_fries = new System.Windows.Forms.GroupBox();
            this.rb_fries_samll = new System.Windows.Forms.RadioButton();
            this.rb_fries_big = new System.Windows.Forms.RadioButton();
            this.cb_fries = new System.Windows.Forms.CheckBox();
            this.gb_drinks = new System.Windows.Forms.GroupBox();
            this.rb_drinks_milktea = new System.Windows.Forms.RadioButton();
            this.rb_drinks_coffee = new System.Windows.Forms.RadioButton();
            this.cb_drinks = new System.Windows.Forms.CheckBox();
            this.gb_m.SuspendLayout();
            this.gb_fries.SuspendLayout();
            this.gb_drinks.SuspendLayout();
            this.SuspendLayout();
            // 
            // rb_drinks_blacktea
            // 
            this.rb_drinks_blacktea.AutoSize = true;
            this.rb_drinks_blacktea.Location = new System.Drawing.Point(22, 112);
            this.rb_drinks_blacktea.Name = "rb_drinks_blacktea";
            this.rb_drinks_blacktea.Size = new System.Drawing.Size(69, 23);
            this.rb_drinks_blacktea.TabIndex = 2;
            this.rb_drinks_blacktea.TabStop = true;
            this.rb_drinks_blacktea.Text = "紅茶";
            this.rb_drinks_blacktea.UseVisualStyleBackColor = true;
            this.rb_drinks_blacktea.CheckedChanged += new System.EventHandler(this.rb_drinks_blacktea_CheckedChanged);
            // 
            // gb_m
            // 
            this.gb_m.BackColor = System.Drawing.Color.Aqua;
            this.gb_m.Controls.Add(this.cb_Quiche);
            this.gb_m.Controls.Add(this.cb_hamburgeradd);
            this.gb_m.Controls.Add(this.cb_sandwich);
            this.gb_m.Controls.Add(this.cb_hamburger);
            this.gb_m.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gb_m.Location = new System.Drawing.Point(84, 21);
            this.gb_m.Name = "gb_m";
            this.gb_m.Size = new System.Drawing.Size(215, 302);
            this.gb_m.TabIndex = 24;
            this.gb_m.TabStop = false;
            this.gb_m.Text = "主餐 :";
            // 
            // cb_Quiche
            // 
            this.cb_Quiche.AutoSize = true;
            this.cb_Quiche.Location = new System.Drawing.Point(33, 187);
            this.cb_Quiche.Name = "cb_Quiche";
            this.cb_Quiche.Size = new System.Drawing.Size(103, 23);
            this.cb_Quiche.TabIndex = 0;
            this.cb_Quiche.Text = "蛋餅$25";
            this.cb_Quiche.UseVisualStyleBackColor = true;
            // 
            // cb_hamburgeradd
            // 
            this.cb_hamburgeradd.AutoSize = true;
            this.cb_hamburgeradd.Location = new System.Drawing.Point(33, 142);
            this.cb_hamburgeradd.Name = "cb_hamburgeradd";
            this.cb_hamburgeradd.Size = new System.Drawing.Size(145, 23);
            this.cb_hamburgeradd.TabIndex = 0;
            this.cb_hamburgeradd.Text = "漢堡加蛋$40";
            this.cb_hamburgeradd.UseVisualStyleBackColor = true;
            // 
            // cb_sandwich
            // 
            this.cb_sandwich.AutoSize = true;
            this.cb_sandwich.Location = new System.Drawing.Point(33, 95);
            this.cb_sandwich.Name = "cb_sandwich";
            this.cb_sandwich.Size = new System.Drawing.Size(124, 23);
            this.cb_sandwich.TabIndex = 0;
            this.cb_sandwich.Text = "三明治$30";
            this.cb_sandwich.UseVisualStyleBackColor = true;
            // 
            // cb_hamburger
            // 
            this.cb_hamburger.AutoSize = true;
            this.cb_hamburger.Location = new System.Drawing.Point(33, 50);
            this.cb_hamburger.Name = "cb_hamburger";
            this.cb_hamburger.Size = new System.Drawing.Size(103, 23);
            this.cb_hamburger.TabIndex = 0;
            this.cb_hamburger.Text = "漢堡$35";
            this.cb_hamburger.UseVisualStyleBackColor = true;
            // 
            // bt_output
            // 
            this.bt_output.BackColor = System.Drawing.Color.Red;
            this.bt_output.Cursor = System.Windows.Forms.Cursors.Default;
            this.bt_output.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt_output.Location = new System.Drawing.Point(84, 352);
            this.bt_output.Name = "bt_output";
            this.bt_output.Size = new System.Drawing.Size(176, 45);
            this.bt_output.TabIndex = 25;
            this.bt_output.Text = "點餐";
            this.bt_output.UseVisualStyleBackColor = false;
            this.bt_output.Click += new System.EventHandler(this.bt_output_Click);
            // 
            // tb_price
            // 
            this.tb_price.BackColor = System.Drawing.Color.DarkGray;
            this.tb_price.Font = new System.Drawing.Font("標楷體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tb_price.ForeColor = System.Drawing.Color.White;
            this.tb_price.Location = new System.Drawing.Point(340, 352);
            this.tb_price.Name = "tb_price";
            this.tb_price.Size = new System.Drawing.Size(299, 40);
            this.tb_price.TabIndex = 23;
            this.tb_price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gb_fries
            // 
            this.gb_fries.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.gb_fries.Controls.Add(this.rb_fries_samll);
            this.gb_fries.Controls.Add(this.rb_fries_big);
            this.gb_fries.Controls.Add(this.cb_fries);
            this.gb_fries.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gb_fries.Location = new System.Drawing.Point(341, 21);
            this.gb_fries.Name = "gb_fries";
            this.gb_fries.Size = new System.Drawing.Size(298, 65);
            this.gb_fries.TabIndex = 26;
            this.gb_fries.TabStop = false;
            // 
            // rb_fries_samll
            // 
            this.rb_fries_samll.AutoSize = true;
            this.rb_fries_samll.Location = new System.Drawing.Point(22, 29);
            this.rb_fries_samll.Name = "rb_fries_samll";
            this.rb_fries_samll.Size = new System.Drawing.Size(102, 23);
            this.rb_fries_samll.TabIndex = 1;
            this.rb_fries_samll.TabStop = true;
            this.rb_fries_samll.Text = "小薯$25";
            this.rb_fries_samll.UseVisualStyleBackColor = true;
            this.rb_fries_samll.CheckedChanged += new System.EventHandler(this.rb_fries_samll_CheckedChanged);
            // 
            // rb_fries_big
            // 
            this.rb_fries_big.AutoSize = true;
            this.rb_fries_big.Location = new System.Drawing.Point(158, 29);
            this.rb_fries_big.Name = "rb_fries_big";
            this.rb_fries_big.Size = new System.Drawing.Size(102, 23);
            this.rb_fries_big.TabIndex = 1;
            this.rb_fries_big.TabStop = true;
            this.rb_fries_big.Text = "大薯$35";
            this.rb_fries_big.UseVisualStyleBackColor = true;
            this.rb_fries_big.CheckedChanged += new System.EventHandler(this.rb_fries_big_CheckedChanged);
            // 
            // cb_fries
            // 
            this.cb_fries.AutoSize = true;
            this.cb_fries.Location = new System.Drawing.Point(21, 0);
            this.cb_fries.Name = "cb_fries";
            this.cb_fries.Size = new System.Drawing.Size(70, 23);
            this.cb_fries.TabIndex = 0;
            this.cb_fries.Text = "薯條";
            this.cb_fries.UseVisualStyleBackColor = true;
            this.cb_fries.CheckedChanged += new System.EventHandler(this.cb_fries_CheckedChanged);
            // 
            // gb_drinks
            // 
            this.gb_drinks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.gb_drinks.Controls.Add(this.rb_drinks_blacktea);
            this.gb_drinks.Controls.Add(this.rb_drinks_milktea);
            this.gb_drinks.Controls.Add(this.rb_drinks_coffee);
            this.gb_drinks.Controls.Add(this.cb_drinks);
            this.gb_drinks.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gb_drinks.Location = new System.Drawing.Point(341, 116);
            this.gb_drinks.Name = "gb_drinks";
            this.gb_drinks.Size = new System.Drawing.Size(298, 207);
            this.gb_drinks.TabIndex = 26;
            this.gb_drinks.TabStop = false;
            // 
            // rb_drinks_milktea
            // 
            this.rb_drinks_milktea.AutoSize = true;
            this.rb_drinks_milktea.Location = new System.Drawing.Point(22, 29);
            this.rb_drinks_milktea.Name = "rb_drinks_milktea";
            this.rb_drinks_milktea.Size = new System.Drawing.Size(102, 23);
            this.rb_drinks_milktea.TabIndex = 1;
            this.rb_drinks_milktea.TabStop = true;
            this.rb_drinks_milktea.Text = "奶茶+$5";
            this.rb_drinks_milktea.UseVisualStyleBackColor = true;
            this.rb_drinks_milktea.CheckedChanged += new System.EventHandler(this.rb_drinks_milktea_CheckedChanged);
            // 
            // rb_drinks_coffee
            // 
            this.rb_drinks_coffee.AutoSize = true;
            this.rb_drinks_coffee.Location = new System.Drawing.Point(22, 71);
            this.rb_drinks_coffee.Name = "rb_drinks_coffee";
            this.rb_drinks_coffee.Size = new System.Drawing.Size(113, 23);
            this.rb_drinks_coffee.TabIndex = 1;
            this.rb_drinks_coffee.TabStop = true;
            this.rb_drinks_coffee.Text = "咖啡+$10";
            this.rb_drinks_coffee.UseVisualStyleBackColor = true;
            this.rb_drinks_coffee.CheckedChanged += new System.EventHandler(this.rb_drinks_coffee_CheckedChanged);
            // 
            // cb_drinks
            // 
            this.cb_drinks.AutoSize = true;
            this.cb_drinks.Location = new System.Drawing.Point(21, 0);
            this.cb_drinks.Name = "cb_drinks";
            this.cb_drinks.Size = new System.Drawing.Size(70, 23);
            this.cb_drinks.TabIndex = 0;
            this.cb_drinks.Text = "飲料";
            this.cb_drinks.UseVisualStyleBackColor = true;
            this.cb_drinks.CheckedChanged += new System.EventHandler(this.cb_drinks_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1060, 586);
            this.Controls.Add(this.gb_drinks);
            this.Controls.Add(this.gb_fries);
            this.Controls.Add(this.bt_output);
            this.Controls.Add(this.tb_price);
            this.Controls.Add(this.gb_m);
            this.Name = "Form1";
            this.Text = "早餐店點餐系統";
            this.gb_m.ResumeLayout(false);
            this.gb_m.PerformLayout();
            this.gb_fries.ResumeLayout(false);
            this.gb_fries.PerformLayout();
            this.gb_drinks.ResumeLayout(false);
            this.gb_drinks.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_output;
        private System.Windows.Forms.GroupBox gb_m;
        private System.Windows.Forms.TextBox tb_price;
        private System.Windows.Forms.CheckBox cb_Quiche;
        private System.Windows.Forms.CheckBox cb_hamburgeradd;
        private System.Windows.Forms.CheckBox cb_sandwich;
        private System.Windows.Forms.CheckBox cb_hamburger;
        private System.Windows.Forms.GroupBox gb_fries;
        private System.Windows.Forms.RadioButton rb_fries_samll;
        private System.Windows.Forms.RadioButton rb_fries_big;
        private System.Windows.Forms.CheckBox cb_fries;
        private System.Windows.Forms.GroupBox gb_drinks;
        private System.Windows.Forms.RadioButton rb_drinks_blacktea;
        private System.Windows.Forms.RadioButton rb_drinks_milktea;
        private System.Windows.Forms.RadioButton rb_drinks_coffee;
        private System.Windows.Forms.CheckBox cb_drinks;
    }
}

