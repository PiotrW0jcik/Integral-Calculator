namespace Piotr_Wojcik_Zadanie1.Forms
{
    partial class FormIntegral8
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
            this.result_out = new System.Windows.Forms.ListBox();
            this.z_input = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // calculate_btn
            // 
            this.calculate_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.calculate_btn.ForeColor = System.Drawing.Color.LightGray;
            this.calculate_btn.Location = new System.Drawing.Point(416, 166);
            this.calculate_btn.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.calculate_btn.Name = "calculate_btn";
            this.calculate_btn.Size = new System.Drawing.Size(99, 53);
            this.calculate_btn.TabIndex = 12;
            this.calculate_btn.Text = "Calculate";
            this.calculate_btn.UseVisualStyleBackColor = false;
            this.calculate_btn.Click += new System.EventHandler(this.calculate_btn_Click);
            // 
            // result_out
            // 
            this.result_out.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.result_out.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.result_out.ForeColor = System.Drawing.Color.LightGray;
            this.result_out.FormattingEnabled = true;
            this.result_out.ItemHeight = 20;
            this.result_out.Location = new System.Drawing.Point(33, 254);
            this.result_out.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.result_out.Name = "result_out";
            this.result_out.Size = new System.Drawing.Size(482, 200);
            this.result_out.TabIndex = 11;
            // 
            // z_input
            // 
            this.z_input.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(70)))), ((int)(((byte)(82)))));
            this.z_input.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.z_input.ForeColor = System.Drawing.Color.LightGray;
            this.z_input.Location = new System.Drawing.Point(62, 44);
            this.z_input.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.z_input.Name = "z_input";
            this.z_input.Size = new System.Drawing.Size(75, 20);
            this.z_input.TabIndex = 10;
            this.z_input.TextChanged += new System.EventHandler(this.z_input_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.LightGray;
            this.label4.Location = new System.Drawing.Point(33, 44);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "z:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.LightGray;
            this.label2.Location = new System.Drawing.Point(33, 218);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Result";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Location = new System.Drawing.Point(62, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(75, 1);
            this.panel1.TabIndex = 14;
            // 
            // FormIntegral8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(70)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(678, 467);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.calculate_btn);
            this.Controls.Add(this.result_out);
            this.Controls.Add(this.z_input);
            this.Controls.Add(this.label4);
            this.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "FormIntegral8";
            this.Text = "Integral 8";
            this.Load += new System.EventHandler(this.Zadanie8_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button calculate_btn;
        private System.Windows.Forms.ListBox result_out;
        private System.Windows.Forms.TextBox z_input;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
    }
}
