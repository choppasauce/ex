using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class trueform : Form
    {
        string captchaAnswer = "none";
        int tryCounter = 0;
        public trueform()
        {
            InitializeComponent();
        }

        private void tbLogin_TextChanged(object sender, EventArgs e)
        {
            if (tbLogin.Text != "" && tbPassword.Text != "" && captchaAnswer == "none")
            {
                btnEnter.Enabled = true;
            }
            else
            {
                btnEnter.Enabled = false;
            }
        }

        private void generateCaptcha()
        {
            lbC1.Font = new Font(label1.Font, label1.Font.Style | FontStyle.Strikeout);
            lbC2.Font = new Font(label1.Font, label1.Font.Style | FontStyle.Strikeout);
            Random random = new Random();
            int a = random.Next(10, 100);
            int b = random.Next(10, 100);
            lbC1.Visible = true;
            lbC2.Visible = true;
            tbCaptcha.Visible = true;
            captchaAnswer = a.ToString() + b.ToString();
        }

        private void dropCaptcha()
        {
            captchaAnswer = "none";
            tryCounter = 0;
            lbC1.Visible = false;
            tbCaptcha.Visible = false;
        }
        

        private void trueform_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
           
        }
    }
}
