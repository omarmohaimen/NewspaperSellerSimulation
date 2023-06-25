using NewspaperSellerModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewspaperSellerSimulation
{
    public partial class showPerformance : Form
    {
        
        public showPerformance()
        {
            InitializeComponent();

        }


        public decimal TSales, TNetProfit, TScrup, TLost, TCost;

        private void button1_Click(object sender, EventArgs e)
        {
            if (ExDemand > UnSold)
            {
                MessageBox.Show("you need to increase the number of papers", "Status");
            }
            else if (UnSold > ExDemand)
            {
                MessageBox.Show("you need to decrease the number of papers", "Status");
            }
            else
            {
               
                MessageBox.Show("No Action needed", "Status");
               
            }
        }

        public int ExDemand,UnSold;

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label2.Text = TCost.ToString();
            label3.Text = TSales.ToString();
            label6.Text = TLost.ToString();
            label8.Text = TScrup.ToString();
            label12.Text = TNetProfit.ToString();
            label13.Text = ExDemand.ToString();
            label14.Text = UnSold.ToString();
        }
    }
}
