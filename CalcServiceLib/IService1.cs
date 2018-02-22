using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace CalcServiceLib
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {


        [OperationContract]
        double getDownPayment(double PurchasePrice, int PercentDown);
        [OperationContract]
        double getRemainingMortgage(double PurchasePrice, int PercentDown);
        [OperationContract]
        double MonthlyMortgage(double PurchasePrice, int PercentDown,double Amortization);
        [OperationContract]
        double getMonthlyInterest(double PurchasePrice, int PercentDown, double Amortization, double Interest);
    }
}
