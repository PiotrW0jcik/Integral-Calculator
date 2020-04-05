namespace Piotr_Wojcik_Zadanie1.Forms
{
    partial class FormIntegral2
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
            this.z_input = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.result_out = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btncalculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // z_input
            // 
            this.z_input.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(70)))), ((int)(((byte)(82)))));
            this.z_input.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.z_input.ForeColor = System.Drawing.Color.LightGray;
            this.z_input.Location = new System.Drawing.Point(79, 56);
            this.z_input.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.z_input.Name = "z_input";
            this.z_input.Size = new System.Drawing.Size(51, 16);
            this.z_input.TabIndex = 1;
            this.z_input.TextChanged += new System.EventHandler(this.z_input_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.LightGray;
            this.label2.Location = new System.Drawing.Point(40, 52);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "z:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.LightGray;
            this.label4.Location = new System.Drawing.Point(39, 226);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Lowest n";
            // 
            // result_out
            // 
            this.result_out.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.result_out.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.result_out.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.result_out.ForeColor = System.Drawing.Color.LightGray;
            this.result_out.FormattingEnabled = true;
            this.result_out.ItemHeight = 20;
            this.result_out.Location = new System.Drawing.Point(39, 263);
            this.result_out.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.result_out.Name = "result_out";
            this.result_out.Size = new System.Drawing.Size(351, 160);
            this.result_out.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Location = new System.Drawing.Point(68, 72);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(75, 1);
            this.panel1.TabIndex = 15;
            // 
            // btncalculate
            // 
            this.btncalculate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btncalculate.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btncalculate.ForeColor = System.Drawing.Color.LightGray;
            this.btncalculate.Location = new System.Drawing.Point(291, 145);
            this.btncalculate.Name = "btncalculate";
            this.btncalculate.Size = new System.Drawing.Size(99, 53);
            this.btncalculate.TabIndex = 16;
            this.btncalculate.Text = "Calculate";
            this.btncalculate.UseVisualStyleBackColor = false;
            this.btncalculate.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormIntegral2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(70)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(569, 467);
            this.Controls.Add(this.btncalculate);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.result_out);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.z_input);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FormIntegral2";
            this.Text = "Integral 2";
            this.Load += new System.EventHandler(this.FormIntegral2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox z_input;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox result_out;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btncalculate;
    }
}