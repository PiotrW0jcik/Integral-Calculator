using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Piotr_Wojcik_Zadanie1
{
    public partial class FormMain : Form
    {
        private Form activeForm;
        public FormMain()
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if(activeForm!=null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelContent.Controls.Add(childForm);
            this.panelContent.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Text;
        }
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnIntegral1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormIntegral1(), sender);

        }

        private void btnIntegral2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormIntegral2(), sender);
        }

        private void btnIntegral3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormIntegral3(), sender);
        }

        private void btnIntegral4_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormIntegral4(), sender);
        }

        private void btnIntegral5_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormIntegral5(), sender);
        }

        private void btnIntegral6_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormIntegral6(), sender);
        }

        private void btnIntegral7_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormIntegral7(), sender);
        }

        private void btnIntegral8_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormIntegral8(), sender);
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }
    }
}
