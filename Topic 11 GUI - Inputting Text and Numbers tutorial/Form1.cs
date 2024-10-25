using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Topic_11_GUI___Inputting_Text_and_Numbers_tutorial
{
    public partial class FormInput : Form
    {
        public FormInput()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnCalculatePrice_Click(object sender, EventArgs e)
        {
            string item;
            int quantity;
            double price, totalPrice;
            item = txtItem.Text;
            price = Convert.ToDouble(txtPrice.Text);
            quantity = Convert.ToInt32(txtQuantity.Text);

            totalPrice = price * quantity;

            lblTotalPrice.Text = "Final Price for " + quantity + " " + item + "(s) is: " + totalPrice.ToString("C");
        }
    }
}
