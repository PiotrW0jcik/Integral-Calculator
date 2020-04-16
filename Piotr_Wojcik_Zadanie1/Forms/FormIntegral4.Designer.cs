namespace Piotr_Wojcik_Zadanie1.Forms
{
    partial class FormIntegral4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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

        private void InitializeComponent()
        {
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.x2_input = new System.Windows.Forms.TextBox();
            this.calculate_btn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.result_out = new System.Windows.Forms.ListBox();
            this.x1_input = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.k_input = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.z_input = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.errorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.LightGray;
            this.label3.Location = new System.Drawing.Point(18, 81);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 20);
            this.label3.TabIndex = 28;
            this.label3.Text = "x2:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(18, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 20);
            this.label1.TabIndex = 27;
            this.label1.Text = "x1:";
            // 
            // x2_input
            // 
            this.x2_input.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(70)))), ((int)(((byte)(82)))));
            this.x2_input.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.x2_input.ForeColor = System.Drawing.Color.LightGray;
            this.x2_input.Location = new System.Drawing.Point(68, 81);
            this.x2_input.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.x2_input.Name = "x2_input";
            this.x2_input.Size = new System.Drawing.Size(116, 16);
            this.x2_input.TabIndex = 26;
            this.x2_input.TextChanged += new System.EventHandler(this.x2_input_TextChanged);
            // 
            // calculate_btn
            // 
            this.calculate_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.calculate_btn.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.calculate_btn.ForeColor = System.Drawing.Color.LightGray;
            this.calculate_btn.Location = new System.Drawing.Point(342, 173);
            this.calculate_btn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.calculate_btn.Name = "calculate_btn";
            this.calculate_btn.Size = new System.Drawing.Size(99, 53);
            this.calculate_btn.TabIndex = 25;
            this.calculate_btn.Text = "Calculate";
            this.calculate_btn.UseVisualStyleBackColor = false;
            this.calculate_btn.Click += new System.EventHandler(this.calculate_btn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.LightGray;
            this.label4.Location = new System.Drawing.Point(21, 242);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 20);
            this.label4.TabIndex = 24;
            this.label4.Text = "Result";
            // 
            // result_out
            // 
            this.result_out.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.result_out.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.result_out.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.result_out.ForeColor = System.Drawing.Color.LightGray;
            this.result_out.FormattingEnabled = true;
            this.result_out.ItemHeight = 20;
            this.result_out.Location = new System.Drawing.Point(21, 276);
            this.result_out.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.result_out.Name = "result_out";
            this.result_out.Size = new System.Drawing.Size(420, 140);
            this.result_out.TabIndex = 23;
            // 
            // x1_input
            // 
            this.x1_input.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(70)))), ((int)(((byte)(82)))));
            this.x1_input.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.x1_input.ForeColor = System.Drawing.Color.LightGray;
            this.x1_input.Location = new System.Drawing.Point(68, 47);
            this.x1_input.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.x1_input.Name = "x1_input";
            this.x1_input.Size = new System.Drawing.Size(116, 16);
            this.x1_input.TabIndex = 22;
            this.x1_input.TextChanged += new System.EventHandler(this.x1_input_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.LightGray;
            this.label5.Location = new System.Drawing.Point(26, 116);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 20);
            this.label5.TabIndex = 30;
            this.label5.Text = "k:";
            // 
            // k_input
            // 
            this.k_input.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(70)))), ((int)(((byte)(82)))));
            this.k_input.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.k_input.ForeColor = System.Drawing.Color.LightGray;
            this.k_input.Location = new System.Drawing.Point(68, 116);
            this.k_input.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.k_input.Name = "k_input";
            this.k_input.Size = new System.Drawing.Size(116, 16);
            this.k_input.TabIndex = 29;
            this.k_input.TextChanged += new System.EventHandler(this.k_input_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.LightGray;
            this.label6.Location = new System.Drawing.Point(26, 153);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 20);
            this.label6.TabIndex = 32;
            this.label6.Text = "z:";
            // 
            // z_input
            // 
            this.z_input.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(70)))), ((int)(((byte)(82)))));
            this.z_input.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.z_input.ForeColor = System.Drawing.Color.LightGray;
            this.z_input.Location = new System.Drawing.Point(68, 153);
            this.z_input.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.z_input.Name = "z_input";
            this.z_input.Size = new System.Drawing.Size(116, 16);
            this.z_input.TabIndex = 31;
            this.z_input.TextChanged += new System.EventHandler(this.z_input_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Location = new System.Drawing.Point(58, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(75, 1);
            this.panel1.TabIndex = 33;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.Location = new System.Drawing.Point(58, 101);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(75, 1);
            this.panel2.TabIndex = 34;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightGray;
            this.panel3.Location = new System.Drawing.Point(58, 136);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(75, 1);
            this.panel3.TabIndex = 35;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightGray;
            this.panel4.Location = new System.Drawing.Point(58, 173);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(75, 1);
            this.panel4.TabIndex = 36;
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.ForeColor = System.Drawing.Color.Cornsilk;
            this.errorLabel.Location = new System.Drawing.Point(201, 67);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(38, 15);
            this.errorLabel.TabIndex = 37;
            this.errorLabel.Text = "label2";
            // 
            // FormIntegral4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(70)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(620, 467);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.z_input);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.k_input);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.x2_input);
            this.Controls.Add(this.calculate_btn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.result_out);
            this.Controls.Add(this.x1_input);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FormIntegral4";
            this.Text = "Integral 4";
            this.Load += new System.EventHandler(this.FormIntegral4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

      //  #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox x2_input;
        private System.Windows.Forms.Button calculate_btn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox result_out;
        private System.Windows.Forms.TextBox x1_input;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox k_input;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox z_input;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label errorLabel;
    }
}
