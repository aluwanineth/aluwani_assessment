using com.psybergate.assessment.dsnprg001.AluwaniNethavhakone.Businesses;

namespace com.psybergate.assessment.dsnprg001.AluwaniNethavhakone.Contracts;

public interface IWithdrawalService
{
    void WithdrawFromCurrent(CurrentAccount currentAccount, int amountToWithdraw);
    void WithdrawFromSavings(SavingsAccount savingsAccount, int amountToWithdraw);
}
