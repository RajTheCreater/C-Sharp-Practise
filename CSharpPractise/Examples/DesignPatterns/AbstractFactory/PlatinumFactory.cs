﻿namespace CSharpPractise.DesignPatterns.AbstractFactory
{
    public class PlatinumFactory : CardFactory
    {
        private int _creditLimit;
        private int _annualCharge;

        public PlatinumFactory(int creditLimit, int annualCharge)
        {
            _creditLimit = creditLimit;
            _annualCharge = annualCharge;
        }
        public override CreditCard GetCreditCard()
        {
            return new PlatinumCreditCard(_creditLimit, _annualCharge);
        }
    }
}
