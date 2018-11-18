using System;

namespace SimpleUnitTestProject1
{
    public class BankRekening
    {
        private int saldo;

        public void Stort(int bedrag)
        {
            saldo += bedrag;
        }

        public void NeemOp(int bedrag)
        {
            saldo -= bedrag;
        }

        public void MaakOver(BankRekening bestemming, int bedrag)
        {
            bestemming.Stort(bedrag);
            NeemOp(bedrag);
        }

        public int GeefSaldo()
        {
            return saldo; 
        }
    }
}
