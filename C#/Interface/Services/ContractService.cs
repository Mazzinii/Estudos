using System;
using System.Diagnostics;
using Interface.Entities;
namespace Interface.Services
{
     class ContractService
    {
        private IOnlinePaymentService _onlinePaymentService;

        public ContractService(IOnlinePaymentService onlinePaymentService){
            _onlinePaymentService = onlinePaymentService;
        }

        public void ProcessContract(Contract contract, int months){
            double basicQuota = contract.TotalValue / months;
            for(int i = 1; i <= months; i++){
                DateTime date = contract.Date.AddMonths(i);
                double updateQuota = basicQuota + _onlinePaymentService.Interest(basicQuota, i);
                double finalQuota = updateQuota + _onlinePaymentService.PaymentFee(updateQuota);
                contract.AddInstallment(new Installment(date, finalQuota));
            }

        }

    }
}