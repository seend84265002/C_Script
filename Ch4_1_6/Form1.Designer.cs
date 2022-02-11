
namespace Ch4_1_6
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
            this.Tx_Passend = new System.Windows.Forms.TextBox();
            this.Tx_Mission = new System.Windows.Forms.TextBox();
            this.Tx_Output = new System.Windows.Forms.TextBox();
            this.Bt_Input = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(220, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "密碼 : ";
            // 
            // Tx_Passend
            // 
            this.Tx_Passend.Location = new System.Drawing.Point(283, 39);
            this.Tx_Passend.Name = "Tx_Passend";
            this.Tx_Passend.PasswordChar = '*';
            this.Tx_Passend.Size = new System.Drawing.Size(305, 23);
            this.Tx_Passend.TabIndex = 1;
            // 
            // Tx_Mission
            // 
            this.Tx_Mission.Location = new System.Drawing.Point(283, 109);
            this.Tx_Mission.Multiline = true;
            this.Tx_Mission.Name = "Tx_Mission";
            this.Tx_Mission.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Tx_Mission.Size = new System.Drawing.Size(305, 109);
            this.Tx_Mission.TabIndex = 2;
            // 
            // Tx_Output
            // 
            this.Tx_Output.Location = new System.Drawing.Point(152, 249);
            this.Tx_Output.Name = "Tx_Output";
            this.Tx_Output.ReadOnly = true;
            this.Tx_Output.Size = new System.Drawing.Size(436, 23);
            this.Tx_Output.TabIndex = 3;
            this.Tx_Output.WordWrap = false;
            this.Tx_Output.TextChanged += new System.EventHandler(this.Tx_Output_TextChanged);
            // 
            // Bt_Input
            // 
            this.Bt_Input.Location = new System.Drawing.Point(618, 39);
            this.Bt_Input.Name = "Bt_Input";
            this.Bt_Input.Size = new System.Drawing.Size(75, 69);
            this.Bt_Input.TabIndex = 4;
            this.Bt_Input.Text = "Enter";
            this.Bt_Input.UseVisualStyleBackColor = true;
            this.Bt_Input.Click += new System.EventHandler(this.Bt_Input_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Bt_Input);
            this.Controls.Add(this.Tx_Output);
            this.Controls.Add(this.Tx_Mission);
            this.Controls.Add(this.Tx_Passend);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "密碼與多行文字方塊";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Tx_Passend;
        private System.Windows.Forms.TextBox Tx_Mission;
        private System.Windows.Forms.TextBox Tx_Output;
        private System.Windows.Forms.Button Bt_Input;
    }
}

