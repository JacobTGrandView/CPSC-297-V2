using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp10
{
    public partial class Form1 : Form
    {
        private Dictionary<string, double> prices = new Dictionary<string, double>()
        {
            {"XS", 20.00},
            {"S", 16.00},
            {"M", 16.00},
            {"L", 16.00},
            {"XL", 16.00},
            {"XXL", 20.00}
        };

        private Dictionary<string, int> cart = new Dictionary<string, int>();

        public Form1()
        {
            InitializeComponent();
            InitializecomboBox1();
        }

        private void InitializecomboBox1()
        {
            // Clear this because it was showing duplicates
            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(new string[] {"XS", "S", "M", "L", "XL", "XXL"});
            comboBox1.SelectedIndex = 0;
        }

        private void addToCartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string size = comboBox1.SelectedItem.ToString().ToUpper();
            int quantity = (int)numericUpDown1.Value;

            if (cart.ContainsKey(size))
            {
                cart[size] += quantity;
            }
            else
            {
                cart[size] = quantity;
            }

            MessageBox.Show("Added to cart");
        }

        /*
        private decimal CalculateTotalCost(string size, int quantity)
        {
            double totalCost = 0;

            foreach (var item in cart)
            {
                totalCost += prices[item.Key] * item.Value;
            }

            return (decimal)totalCost;
        }
        */

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //
        }

        private void displayOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBoxOrder.Items.Clear();

            if (cart.Count == 0)
            {
                listBoxOrder.Items.Add("Cart is empty");
                return;
            }

            double totalOrderCost = 0;

            foreach (var item in cart)
            {
                if (prices.ContainsKey(item.Key))
                {
                    double itemCost = prices[item.Key] * item.Value;
                    totalOrderCost += itemCost;
                    listBoxOrder.Items.Add($"{item.Key}: {item.Value} x ${prices[item.Key]} = ${itemCost}");
                }

                else
                {
                    listBoxOrder.Items.Add($"Invalid size: {item.Key}");
                }
            }

            listBoxOrder.Items.Add($"Total Cost: ${totalOrderCost}");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // quit
            Application.Exit();
        }

        // Help menu
        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You are able to select multiple sizes on a single order");
        }
    }
}
