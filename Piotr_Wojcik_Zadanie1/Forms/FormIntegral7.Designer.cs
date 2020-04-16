namespace Piotr_Wojcik_Zadanie1.Forms
{
    partial class FormIntegral7
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.x1_input = new System.Windows.Forms.TextBox();
            this.x2_input = new System.Windows.Forms.TextBox();
            this.z_input = new System.Windows.Forms.TextBox();
            this.result_out = new System.Windows.Forms.ListBox();
            this.calculate_btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.LightGray;
            this.label2.Location = new System.Drawing.Point(36, 51);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "x1:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.LightGray;
            this.label3.Location = new System.Drawing.Point(36, 85);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "x2:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.LightGray;
            this.label4.Location = new System.Drawing.Point(40, 114);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "z:";
            // 
            // x1_input
            // 
            this.x1_input.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(70)))), ((int)(((byte)(82)))));
            this.x1_input.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.x1_input.ForeColor = System.Drawing.Color.LightGray;
            this.x1_input.Location = new System.Drawing.Point(71, 51);
            this.x1_input.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.x1_input.Name = "x1_input";
            this.x1_input.Size = new System.Drawing.Size(116, 16);
            this.x1_input.TabIndex = 4;
            this.x1_input.TextChanged += new System.EventHandler(this.x1_input_TextChanged);
            // 
            // x2_input
            // 
            this.x2_input.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(70)))), ((int)(((byte)(82)))));
            this.x2_input.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.x2_input.ForeColor = System.Drawing.Color.LightGray;
            this.x2_input.Location = new System.Drawing.Point(71, 85);
            this.x2_input.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.x2_input.Name = "x2_input";
            this.x2_input.Size = new System.Drawing.Size(116, 16);
            this.x2_input.TabIndex = 5;
            this.x2_input.TextChanged += new System.EventHandler(this.x2_input_TextChanged);
            // 
            // z_input
            // 
            this.z_input.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(70)))), ((int)(((byte)(82)))));
            this.z_input.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.z_input.ForeColor = System.Drawing.Color.LightGray;
            this.z_input.Location = new System.Drawing.Point(71, 114);
            this.z_input.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.z_input.Name = "z_input";
            this.z_input.Size = new System.Drawing.Size(116, 16);
            this.z_input.TabIndex = 6;
            this.z_input.TextChanged += new System.EventHandler(this.z_input_TextChanged);
            // 
            // result_out
            // 
            this.result_out.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.result_out.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.result_out.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.result_out.ForeColor = System.Drawing.Color.LightGray;
            this.result_out.FormattingEnabled = true;
            this.result_out.ItemHeight = 20;
            this.result_out.Location = new System.Drawing.Point(34, 245);
            this.result_out.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.result_out.Name = "result_out";
            this.result_out.Size = new System.Drawing.Size(514, 180);
            this.result_out.TabIndex = 7;
            this.result_out.SelectedIndexChanged += new System.EventHandler(this.wynik_out_SelectedIndexChanged);
            // 
            // calculate_btn
            // 
            this.calculate_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.calculate_btn.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.calculate_btn.ForeColor = System.Drawing.Color.LightGray;
            this.calculate_btn.Location = new System.Drawing.Point(449, 163);
            this.calculate_btn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.calculate_btn.Name = "calculate_btn";
            this.calculate_btn.Size = new System.Drawing.Size(99, 53);
            this.calculate_btn.TabIndex = 8;
            this.calculate_btn.Text = "Calculate";
            this.calculate_btn.UseVisualStyleBackColor = false;
            this.calculate_btn.Click += new System.EventHandler(this.calculate_btn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Location = new System.Drawing.Point(67, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(75, 1);
            this.panel1.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.Location = new System.Drawing.Point(67, 102);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(75, 1);
            this.panel2.TabIndex = 10;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightGray;
            this.panel3.Location = new System.Drawing.Point(67, 131);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(75, 1);
            this.panel3.TabIndex = 11;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl.ForeColor = System.Drawing.Color.LightGray;
            this.lbl.Location = new System.Drawing.Point(36, 212);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(49, 20);
            this.lbl.TabIndex = 12;
            this.lbl.Text = "Result";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-38, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "label1";
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.ForeColor = System.Drawing.Color.Honeydew;
            this.errorLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.errorLabel.Location = new System.Drawing.Point(71, 163);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 15);
            this.errorLabel.TabIndex = 14;
            // 
            // FormIntegral7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(70)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(678, 467);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.calculate_btn);
            this.Controls.Add(this.result_out);
            this.Controls.Add(this.z_input);
            this.Controls.Add(this.x2_input);
            this.Controls.Add(this.x1_input);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FormIntegral7";
            this.Text = "Integral 7";
            this.Load += new System.EventHandler(this.FormIntegral7_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox x1_input;
        private System.Windows.Forms.TextBox x2_input;
        private System.Windows.Forms.TextBox z_input;
        private System.Windows.Forms.ListBox result_out;
        private System.Windows.Forms.Button calculate_btn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label errorLabel;
    }
}