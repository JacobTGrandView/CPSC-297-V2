using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            RedColor();
            GreenColor();
            ResetColor();   
            this.BackColor = Color.Blue;
        }

        private void redButton_Click(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.Red;
            label1.Text = "The form is red";
        }

        private void RedColor()
        {
            redButton.ImageAlign = ContentAlignment.MiddleCenter;
            int newSize = 16;
            redButton.Font = new Font(redButton.Font.FontFamily, newSize);
        }

        private void greenButton_Click(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.Green;
            label1.Text = "The form is green";
        }

        private void GreenColor()
        {
            greenButton.ImageAlign = ContentAlignment.MiddleCenter;
            int newSize = 16;
            greenButton.Font = new Font(greenButton.Font.FontFamily, newSize);
        }

        private void ResetColor()
        {
            resetButton.ImageAlign = ContentAlignment.MiddleCenter;
            int newSize = 16;
            resetButton.Font = new Font(resetButton.Font.FontFamily, newSize);
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.Blue;
            label1.Text = "The form is blue";
        }
    }
}
