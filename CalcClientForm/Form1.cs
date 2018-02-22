using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcClientForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ServiceReference1.Service1Client client = new ServiceReference1.Service1Client("NetTcpBinding_IService1");

            double PurchasePrice = Double.Parse(purchaseText.Text);
            double InterestRate = Double.Parse(InterestText.Text);
            double amort = Double.Parse(amortization.Text);
            int perDown = Int32.Parse(percentDown.Text);

            downText.Text = Convert.ToString(client.getDownPayment(PurchasePrice, perDown));
            remText.Text = Convert.ToString(client.getRemainingMortgage(PurchasePrice, perDown));
            monthlyText.Text = Convert.ToString(client.MonthlyMortgage(PurchasePrice, perDown, amort));
            MiText.Text = Convert.ToString(client.getMonthlyInterest(PurchasePrice, perDown, amort, InterestRate));
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
