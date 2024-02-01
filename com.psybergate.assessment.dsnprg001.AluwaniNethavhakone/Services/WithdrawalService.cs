using com.psybergate.assessment.dsnprg001.AluwaniNethavhakone.Businesses;
using com.psybergate.assessment.dsnprg001.AluwaniNethavhakone.Contracts;

namespace com.psybergate.assessment.dsnprg001.AluwaniNethavhakone.Services;

public class WithdrawalService : IWithdrawalService
{
    public void WithdrawFromSavings(SavingsAccount savingsAccount, int amountToWithdraw)
    {
        if (savingsAccount.Balance - amountToWithdraw >= 1000)
        {
            savingsAccount.Balance -= amountToWithdraw;
            Console.WriteLine($"Withdrawal of {amountToWithdraw} successful. New balance: {savingsAccount.Balance}");
        }
        else
        {
            Console.WriteLine("Withdrawal failed. Minimum balance of 1000 not maintained.");
        }
    }

    public  void WithdrawFromCurrent(CurrentAccount currentAccount, int amountToWithdraw)
    {
        int availableFunds = currentAccount.Balance + currentAccount.Overdraft;

        if (amountToWithdraw <= availableFunds)
        {
            currentAccount.Balance -= amountToWithdraw;
            Console.WriteLine($"Withdrawal of {amountToWithdraw} successful. New balance: {currentAccount.Balance}");
        }
        else
        {
            Console.WriteLine("Withdrawal failed. Insufficient funds.");
        }
    }
}
