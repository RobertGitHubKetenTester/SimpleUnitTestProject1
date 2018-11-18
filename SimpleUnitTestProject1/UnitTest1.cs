using System;
using NUnit.Framework;



namespace SimpleUnitTestProject1
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void SpeelDeBank()
        {
            BankRekening oorsprong = new BankRekening();
            oorsprong.Stort(100);

            BankRekening bestemming = new BankRekening();
            bestemming.Stort(50);

            oorsprong.MaakOver(bestemming, 20);

            Assert.AreEqual(80, oorsprong.GeefSaldo());
            Assert.AreEqual(70, bestemming.GeefSaldo());
            
        }
    }
}
