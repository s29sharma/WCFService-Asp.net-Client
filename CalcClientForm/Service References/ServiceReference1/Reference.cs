﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CalcClientForm.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/getDownPayment", ReplyAction="http://tempuri.org/IService1/getDownPaymentResponse")]
        double getDownPayment(double PurchasePrice, int PercentDown);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/getDownPayment", ReplyAction="http://tempuri.org/IService1/getDownPaymentResponse")]
        System.Threading.Tasks.Task<double> getDownPaymentAsync(double PurchasePrice, int PercentDown);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/getRemainingMortgage", ReplyAction="http://tempuri.org/IService1/getRemainingMortgageResponse")]
        double getRemainingMortgage(double PurchasePrice, int PercentDown);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/getRemainingMortgage", ReplyAction="http://tempuri.org/IService1/getRemainingMortgageResponse")]
        System.Threading.Tasks.Task<double> getRemainingMortgageAsync(double PurchasePrice, int PercentDown);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/MonthlyMortgage", ReplyAction="http://tempuri.org/IService1/MonthlyMortgageResponse")]
        double MonthlyMortgage(double PurchasePrice, int PercentDown, double Amortization);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/MonthlyMortgage", ReplyAction="http://tempuri.org/IService1/MonthlyMortgageResponse")]
        System.Threading.Tasks.Task<double> MonthlyMortgageAsync(double PurchasePrice, int PercentDown, double Amortization);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/getMonthlyInterest", ReplyAction="http://tempuri.org/IService1/getMonthlyInterestResponse")]
        double getMonthlyInterest(double PurchasePrice, int PercentDown, double Amortization, double Interest);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/getMonthlyInterest", ReplyAction="http://tempuri.org/IService1/getMonthlyInterestResponse")]
        System.Threading.Tasks.Task<double> getMonthlyInterestAsync(double PurchasePrice, int PercentDown, double Amortization, double Interest);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : CalcClientForm.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<CalcClientForm.ServiceReference1.IService1>, CalcClientForm.ServiceReference1.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public double getDownPayment(double PurchasePrice, int PercentDown) {
            return base.Channel.getDownPayment(PurchasePrice, PercentDown);
        }
        
        public System.Threading.Tasks.Task<double> getDownPaymentAsync(double PurchasePrice, int PercentDown) {
            return base.Channel.getDownPaymentAsync(PurchasePrice, PercentDown);
        }
        
        public double getRemainingMortgage(double PurchasePrice, int PercentDown) {
            return base.Channel.getRemainingMortgage(PurchasePrice, PercentDown);
        }
        
        public System.Threading.Tasks.Task<double> getRemainingMortgageAsync(double PurchasePrice, int PercentDown) {
            return base.Channel.getRemainingMortgageAsync(PurchasePrice, PercentDown);
        }
        
        public double MonthlyMortgage(double PurchasePrice, int PercentDown, double Amortization) {
            return base.Channel.MonthlyMortgage(PurchasePrice, PercentDown, Amortization);
        }
        
        public System.Threading.Tasks.Task<double> MonthlyMortgageAsync(double PurchasePrice, int PercentDown, double Amortization) {
            return base.Channel.MonthlyMortgageAsync(PurchasePrice, PercentDown, Amortization);
        }
        
        public double getMonthlyInterest(double PurchasePrice, int PercentDown, double Amortization, double Interest) {
            return base.Channel.getMonthlyInterest(PurchasePrice, PercentDown, Amortization, Interest);
        }
        
        public System.Threading.Tasks.Task<double> getMonthlyInterestAsync(double PurchasePrice, int PercentDown, double Amortization, double Interest) {
            return base.Channel.getMonthlyInterestAsync(PurchasePrice, PercentDown, Amortization, Interest);
        }
    }
}