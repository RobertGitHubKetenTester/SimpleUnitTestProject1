using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowTestProject
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
