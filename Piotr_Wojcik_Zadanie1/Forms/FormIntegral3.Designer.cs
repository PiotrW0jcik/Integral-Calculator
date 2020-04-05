namespace Piotr_Wojcik_Zadanie1.Forms
{
    partial class FormIntegral3
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.calculate_btn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.results_out = new System.Windows.Forms.ListBox();
            this.x1_input = new System.Windows.Forms.TextBox();
            this.x2_input = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // calculate_btn
            // 
            this.calculate_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.calculate_btn.Location = new System.Drawing.Point(382, 139);
            this.calculate_btn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.calculate_btn.Name = "calculate_btn";
            this.calculate_btn.Size = new System.Drawing.Size(99, 53);
            this.calculate_btn.TabIndex = 18;
            this.calculate_btn.Text = "Calculate";
            this.calculate_btn.UseVisualStyleBackColor = false;
            this.calculate_btn.Click += new System.EventHandler(this.calculate_btn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.LightGray;
            this.label4.Location = new System.Drawing.Point(35, 234);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Results:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // results_out
            // 
            this.results_out.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.results_out.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.results_out.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.results_out.ForeColor = System.Drawing.Color.LightGray;
            this.results_out.FormattingEnabled = true;
            this.results_out.ItemHeight = 17;
            this.results_out.Location = new System.Drawing.Point(35, 273);
            this.results_out.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.results_out.Name = "results_out";
            this.results_out.Size = new System.Drawing.Size(446, 153);
            this.results_out.TabIndex = 16;
            // 
            // x1_input
            // 
            this.x1_input.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(70)))), ((int)(((byte)(82)))));
            this.x1_input.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.x1_input.ForeColor = System.Drawing.Color.LightGray;
            this.x1_input.Location = new System.Drawing.Point(80, 48);
            this.x1_input.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.x1_input.Name = "x1_input";
            this.x1_input.Size = new System.Drawing.Size(70, 20);
            this.x1_input.TabIndex = 15;
            this.x1_input.TextChanged += new System.EventHandler(this.x1_input_TextChanged);
            // 
            // x2_input
            // 
            this.x2_input.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(70)))), ((int)(((byte)(82)))));
            this.x2_input.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.x2_input.ForeColor = System.Drawing.Color.LightGray;
            this.x2_input.Location = new System.Drawing.Point(78, 76);
            this.x2_input.Name = "x2_input";
            this.x2_input.Size = new System.Drawing.Size(70, 20);
            this.x2_input.TabIndex = 19;
            this.x2_input.TextChanged += new System.EventHandler(this.x2_input_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.LightGray;
            this.label2.Location = new System.Drawing.Point(35, 44);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "x1:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 76);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "x2:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Location = new System.Drawing.Point(69, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(70, 1);
            this.panel1.TabIndex = 22;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.Location = new System.Drawing.Point(349, 76);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(70, 0);
            this.panel2.TabIndex = 23;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightGray;
            this.panel3.Location = new System.Drawing.Point(69, 95);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(70, 1);
            this.panel3.TabIndex = 24;
            // 
            // FormIntegral3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(70)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(609, 467);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.x2_input);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.calculate_btn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.results_out);
            this.Controls.Add(this.x1_input);
            this.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.LightGray;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "FormIntegral3";
            this.Text = "Integral 3";
            this.Load += new System.EventHandler(this.FormIntegral3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button calculate_btn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox results_out;
        private System.Windows.Forms.TextBox x1_input;
        private System.Windows.Forms.TextBox x2_input;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}