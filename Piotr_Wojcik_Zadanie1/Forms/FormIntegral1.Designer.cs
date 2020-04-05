namespace Piotr_Wojcik_Zadanie1.Forms
{
    partial class FormIntegral1
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
            this.m_input = new System.Windows.Forms.TextBox();
            this.z_input = new System.Windows.Forms.TextBox();
            this.lblM = new System.Windows.Forms.Label();
            this.lblZ = new System.Windows.Forms.Label();
            this.calculate_btn = new System.Windows.Forms.Button();
            this.rectangles_out = new System.Windows.Forms.ListBox();
            this.trapezoid_out = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // m_input
            // 
            this.m_input.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(70)))), ((int)(((byte)(82)))));
            this.m_input.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.m_input.ForeColor = System.Drawing.Color.LightGray;
            this.m_input.Location = new System.Drawing.Point(68, 58);
            this.m_input.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.m_input.Name = "m_input";
            this.m_input.Size = new System.Drawing.Size(49, 16);
            this.m_input.TabIndex = 0;
            this.m_input.TextChanged += new System.EventHandler(this.m_input_TextChanged);
            // 
            // z_input
            // 
            this.z_input.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(70)))), ((int)(((byte)(82)))));
            this.z_input.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.z_input.ForeColor = System.Drawing.Color.LightGray;
            this.z_input.Location = new System.Drawing.Point(68, 98);
            this.z_input.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.z_input.Name = "z_input";
            this.z_input.Size = new System.Drawing.Size(49, 16);
            this.z_input.TabIndex = 1;
            this.z_input.TextChanged += new System.EventHandler(this.z_input_TextChanged);
            // 
            // lblM
            // 
            this.lblM.AutoSize = true;
            this.lblM.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblM.ForeColor = System.Drawing.Color.LightGray;
            this.lblM.Location = new System.Drawing.Point(28, 57);
            this.lblM.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblM.Name = "lblM";
            this.lblM.Size = new System.Drawing.Size(25, 20);
            this.lblM.TabIndex = 2;
            this.lblM.Text = "m:";
            this.lblM.Click += new System.EventHandler(this.lblM_Click);
            // 
            // lblZ
            // 
            this.lblZ.AutoSize = true;
            this.lblZ.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblZ.ForeColor = System.Drawing.Color.LightGray;
            this.lblZ.Location = new System.Drawing.Point(31, 98);
            this.lblZ.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblZ.Name = "lblZ";
            this.lblZ.Size = new System.Drawing.Size(19, 20);
            this.lblZ.TabIndex = 3;
            this.lblZ.Text = "z:";
            this.lblZ.Click += new System.EventHandler(this.lblZ_Click);
            // 
            // calculate_btn
            // 
            this.calculate_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.calculate_btn.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.calculate_btn.ForeColor = System.Drawing.Color.LightGray;
            this.calculate_btn.Location = new System.Drawing.Point(448, 129);
            this.calculate_btn.Margin = new System.Windows.Forms.Padding(1);
            this.calculate_btn.Name = "calculate_btn";
            this.calculate_btn.Size = new System.Drawing.Size(99, 53);
            this.calculate_btn.TabIndex = 4;
            this.calculate_btn.TabStop = false;
            this.calculate_btn.Text = "Calculate";
            this.calculate_btn.UseVisualStyleBackColor = false;
            this.calculate_btn.Click += new System.EventHandler(this.calculate_btn_Click);
            // 
            // rectangles_out
            // 
            this.rectangles_out.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.rectangles_out.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rectangles_out.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rectangles_out.ForeColor = System.Drawing.Color.LightGray;
            this.rectangles_out.FormattingEnabled = true;
            this.rectangles_out.ItemHeight = 20;
            this.rectangles_out.Location = new System.Drawing.Point(20, 290);
            this.rectangles_out.Margin = new System.Windows.Forms.Padding(3, 3, 4, 3);
            this.rectangles_out.Name = "rectangles_out";
            this.rectangles_out.Size = new System.Drawing.Size(220, 120);
            this.rectangles_out.TabIndex = 5;
            this.rectangles_out.SelectedIndexChanged += new System.EventHandler(this.prostakoty_out_SelectedIndexChanged);
            // 
            // trapezoid_out
            // 
            this.trapezoid_out.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.trapezoid_out.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.trapezoid_out.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.trapezoid_out.ForeColor = System.Drawing.Color.LightGray;
            this.trapezoid_out.FormattingEnabled = true;
            this.trapezoid_out.ItemHeight = 20;
            this.trapezoid_out.Location = new System.Drawing.Point(322, 290);
            this.trapezoid_out.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.trapezoid_out.Name = "trapezoid_out";
            this.trapezoid_out.Size = new System.Drawing.Size(225, 120);
            this.trapezoid_out.TabIndex = 6;
            this.trapezoid_out.SelectedIndexChanged += new System.EventHandler(this.trapezy_out_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 5);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 15);
            this.label3.TabIndex = 7;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.LightGray;
            this.label4.Location = new System.Drawing.Point(20, 255);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Rectangles method";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.LightGray;
            this.label5.Location = new System.Drawing.Point(322, 255);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Trapezoid method";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Location = new System.Drawing.Point(56, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(75, 1);
            this.panel1.TabIndex = 10;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.Location = new System.Drawing.Point(56, 114);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(75, 1);
            this.panel2.TabIndex = 11;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // FormIntegral1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(70)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(604, 467);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.trapezoid_out);
            this.Controls.Add(this.rectangles_out);
            this.Controls.Add(this.calculate_btn);
            this.Controls.Add(this.lblZ);
            this.Controls.Add(this.lblM);
            this.Controls.Add(this.z_input);
            this.Controls.Add(this.m_input);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FormIntegral1";
            this.Text = "Integral 1";
            this.Load += new System.EventHandler(this.FormIntegral1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox m_input;
        private System.Windows.Forms.TextBox z_input;
        private System.Windows.Forms.Label lblM;
        private System.Windows.Forms.Label lblZ;
        private System.Windows.Forms.Button calculate_btn;
        private System.Windows.Forms.ListBox rectangles_out;
        private System.Windows.Forms.ListBox trapezoid_out;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}