using com.psybergate.assessment.dsnprg001.AluwaniNethavhakone.Businesses;
using com.psybergate.assessment.dsnprg001.AluwaniNethavhakone.Services;

namespace com.psybergate.assessment.dsnprg001.AluwaniNethavhakone.Tests
{
    [TestClass]
    public class AccountServiceTests
    {
        [TestMethod]
        public void WithdrawFromSavings_WithValidAmount_ShouldDecreaseBalance()
        {
            // Arrange
            var savingsAccount = new SavingsAccount(101, 1, 2000);
            var withdrawalService = new WithdrawalService();

            // Act
            withdrawalService.WithdrawFromSavings(savingsAccount, 500);

            // Assert
            Assert.AreEqual(1500, savingsAccount.Balance);
        }

        [TestMethod]
        public void WithdrawFromSavings_WithInvalidAmount_ShouldNotDecreaseBalance()
        {
            // Arrange
            var savingsAccount = new SavingsAccount(102, 2, 5000);
            var withdrawalService = new WithdrawalService();

            // Act
            withdrawalService.WithdrawFromSavings(savingsAccount, 5500);

            // Assert
            Assert.AreEqual(5000, savingsAccount.Balance);
        }

        [TestMethod]
        public void WithdrawFromCurrent_WithValidAmount_ShouldDecreaseBalance()
        {
            // Arrange
            var currentAccount = new CurrentAccount(103, 3, 1000, 10000);
            var withdrawalService = new WithdrawalService();

            // Act
            withdrawalService.WithdrawFromCurrent(currentAccount, 2000);

            // Assert
            Assert.AreEqual(-1000, currentAccount.Balance);
        }

        [TestMethod]
        public void WithdrawFromCurrent_WithInvalidAmount_ShouldNotDecreaseBalance()
        {
            // Arrange
            var currentAccount = new CurrentAccount(104, 4, -5000, 20000);
            var withdrawalService = new WithdrawalService();

            // Act
            withdrawalService.WithdrawFromCurrent(currentAccount, 25000);

            // Assert
            Assert.AreEqual(-5000, currentAccount.Balance);
        }

        [TestMethod]
        public void Withdraw_WithInvalidAccountNum_ShouldPrintErrorMessage()
        {
            // Arrange
            var withdrawalService = new WithdrawalService();
            var accountService = new AccountService(withdrawalService);

            // Act
            accountService.Withdraw(999, 1000);

            // Assert
            Assert.AreEqual("Account not found!", ConsoleOut.ToString().Trim());
        }

        // Helper class to redirect Console.WriteLine
        private class ConsoleOut
        {
            private static readonly StringWriter sw = new StringWriter();
            public static string ToString() => sw.ToString();
            public static void WriteLine(string line) => sw.WriteLine(line);
        }
    }
}