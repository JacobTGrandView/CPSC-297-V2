using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {

        private bool snowGlovesSelected = false;
        private bool skisSelected = false;
        private bool gogglesSelected = false;
        private bool earmuffsSelected = false;


        public Form1()
        {
            InitializeComponent();
        }

        private void glovesCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            snowGlovesSelected = glovesCheckBox.Checked;
        }

        private void gogglesCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            gogglesSelected = gogglesCheckBox.Checked;
        }

        private void skiCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            skisSelected = skiCheckBox.Checked;
        }

        private void earmuffsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            earmuffsSelected = earmuffsCheckBox.Checked;
        }


        // Display selected items
        private void displayButton_Click(object sender, EventArgs e)
        {
            string order = "Selected items:\n";

            if (snowGlovesSelected) order += "- Snow Gloves\n";
            if (skisSelected) order += "- Skis\n";
            if (gogglesSelected) order += "- Goggles\n";
            if (earmuffsSelected) order += "- Earmuffs\n";

            MessageBox.Show(order, "Items Selected");
        }

        // Set the checkboxes to false to clear selections
        private void clearButton_Click(object sender, EventArgs e)
        {
            glovesCheckBox.Checked = false;
            skiCheckBox.Checked = false;
            earmuffsCheckBox.Checked = false;
            gogglesCheckBox.Checked = false;
        }

        // Exit app
        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Setting the ski resort image
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            PictureBox pb1 = new PictureBox();
            pb1.ImageLocation = "\"C:\\Users\\jt108\\Desktop\\ski_resort.jpg\"";
        }
    }
}
