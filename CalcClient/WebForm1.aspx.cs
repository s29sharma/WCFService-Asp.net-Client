using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CalcClient
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void InterestText_TextChanged(object sender, EventArgs e)
        {


        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ServiceReference1.Service1Client client = new ServiceReference1.Service1Client("BasicHttpBinding_IService1");

            double PurchasePrice = Double.Parse(purchaseText.Text);
            double InterestRate = Double.Parse(InterestText.Text);
            double amort = Double.Parse(amortization.SelectedValue);
            int perDown = Int32.Parse(percentDown.SelectedValue);

           downText.Text = Convert.ToString(client.getDownPayment(PurchasePrice, perDown));
           remText.Text = Convert.ToString(client.getRemainingMortgage(PurchasePrice, perDown));
           monthlyText.Text = Convert.ToString(client.MonthlyMortgage(PurchasePrice, perDown, amort));
           MiText.Text = Convert.ToString(client.getMonthlyInterest(PurchasePrice, perDown, amort,InterestRate));
        }
    }
}