using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace CalcServiceLib
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Service1 : IService1
{
        //private double PurchasePrice;
        //private double InterestRate;
        //private double Amortization;
        //private int PerecentDown;

            //not using a method inside another method just for experimentation
        public double getDownPayment(double PurchasePrice,int PercentDown)
        {
            return((PurchasePrice * PercentDown)/100);
        }

        public double MonthlyMortgage(double PurchasePrice,int PercentDown,double Amortization )
        {
            return ((PurchasePrice-((PurchasePrice * PercentDown)/100))/Amortization);
        }

        public double getRemainingMortgage(double PurchasePrice, int PercentDown)
        {
            return (PurchasePrice-((PurchasePrice * PercentDown)/100));

        }

        public double getMonthlyInterest(double PurchasePrice, int PercentDown, double Amortization, double Interest)
        {
            return ((((PurchasePrice - ((PurchasePrice * PercentDown) / 100)) / Amortization)*Interest)/100);
        }
    }
}
