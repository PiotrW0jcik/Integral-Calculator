namespace Piotr_Wojcik_Zadanie1.Forms
{
    partial class FormIntegral5
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
            this.calculate_btn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.result_out = new System.Windows.Forms.ListBox();
            this.k_input = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.LightGray;
            this.label2.Location = new System.Drawing.Point(38, 57);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 20);
            this.label2.TabIndex = 25;
            this.label2.Text = "k:";
            // 
            // calculate_btn
            // 
            this.calculate_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.calculate_btn.Location = new System.Drawing.Point(345, 142);
            this.calculate_btn.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.calculate_btn.Name = "calculate_btn";
            this.calculate_btn.Size = new System.Drawing.Size(99, 53);
            this.calculate_btn.TabIndex = 24;
            this.calculate_btn.Text = "Calculate";
            this.calculate_btn.UseVisualStyleBackColor = false;
            this.calculate_btn.Click += new System.EventHandler(this.calculate_btn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.LightGray;
            this.label4.Location = new System.Drawing.Point(38, 207);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "Result:";
            // 
            // result_out
            // 
            this.result_out.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.result_out.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.result_out.ForeColor = System.Drawing.Color.LightGray;
            this.result_out.FormattingEnabled = true;
            this.result_out.ItemHeight = 20;
            this.result_out.Location = new System.Drawing.Point(38, 243);
            this.result_out.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.result_out.Name = "result_out";
            this.result_out.Size = new System.Drawing.Size(406, 200);
            this.result_out.TabIndex = 22;
            this.result_out.SelectedIndexChanged += new System.EventHandler(this.wynik_out_SelectedIndexChanged);
            // 
            // k_input
            // 
            this.k_input.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(70)))), ((int)(((byte)(82)))));
            this.k_input.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.k_input.ForeColor = System.Drawing.Color.LightGray;
            this.k_input.Location = new System.Drawing.Point(78, 57);
            this.k_input.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.k_input.Name = "k_input";
            this.k_input.Size = new System.Drawing.Size(132, 20);
            this.k_input.TabIndex = 21;
            this.k_input.TextChanged += new System.EventHandler(this.k_input_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(114, 112);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(75, 1);
            this.panel1.TabIndex = 26;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkGray;
            this.panel2.Location = new System.Drawing.Point(67, 78);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(75, 1);
            this.panel2.TabIndex = 27;
            // 
            // FormIntegral5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(70)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(620, 467);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.calculate_btn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.result_out);
            this.Controls.Add(this.k_input);
            this.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.LightGray;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "FormIntegral5";
            this.Text = "Integral 5";
            this.Load += new System.EventHandler(this.FormIntegral5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button calculate_btn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox result_out;
        private System.Windows.Forms.TextBox k_input;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}
