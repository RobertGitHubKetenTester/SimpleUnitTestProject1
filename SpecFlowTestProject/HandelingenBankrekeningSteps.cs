using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowTestProject
{
    [Binding]
    public class HandelingenBankrekeningSteps
    {
        BankRekening oorsprong = new BankRekening();
        BankRekening bestemming = new BankRekening();
        int saldo_oorsprong=0;
        int saldo_bestemming=0;


        [Given(@"Ik stort (.*) op een eerste rekening")]
        public void GivenIkStortOpEenEersteRekening(int storting)
        {
            oorsprong.Stort(storting);
        }

        [Given(@"Ik stort (.*) op een tweede rekening")]
        public void GivenIkStortOpEenTweedeRekening(int storting)
        {
            bestemming.Stort(storting);
        }


        [When(@"ik vraag de respectieve saldi op")]
        public void WhenIkVraagDeSaldiOp()
        {
            saldo_oorsprong = oorsprong.GeefSaldo();
            saldo_bestemming = bestemming.GeefSaldo();
        }
        
        [Then(@"zijn deze saldi (.*) en (.*)")]
        public void ThenDeRespectieveSaldiZijnEn(int saldo1, int saldo2)
        {
            Assert.AreEqual(saldo1, saldo_oorsprong);
            Assert.AreEqual(saldo2, saldo_bestemming);
        }

        [When(@"Ik maak (.*) over tussen deze rekeningen")]
        public void WhenIkMaakOver(int overmaakbedrag)
        {
            oorsprong.MaakOver(bestemming, overmaakbedrag);
        }


    }
}
