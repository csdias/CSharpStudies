using NUnit.Framework;
using BankAccount;

namespace BankAccountTest
{
    [TestFixture]
    public class BankAccount
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            //Assert.Pass();
        
            Account source = new Account();
            source.Deposit(200m);

            Account destination = new Account();
            destination.Deposit(150m);

            source.TransferFunds(destination, 100m);

            Assert.AreEqual(250m, destination.Balance);
            Assert.AreEqual(100m, source.Balance);
        
        }
    }
}