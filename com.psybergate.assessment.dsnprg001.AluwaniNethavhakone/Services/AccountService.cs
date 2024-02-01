using com.psybergate.assessment.dsnprg001.AluwaniNethavhakone.Businesses;
using com.psybergate.assessment.dsnprg001.AluwaniNethavhakone.Contracts;
using com.psybergate.assessment.dsnprg001.AluwaniNethavhakone.Database;

namespace com.psybergate.assessment.dsnprg001.AluwaniNethavhakone.Services;

public class AccountService : IAccountService
{
    private readonly IWithdrawalService _withdrawalService;
    public AccountService(IWithdrawalService withdrawalService)
    {
        _withdrawalService = withdrawalService;
    }
    public void Withdraw(long accountNum, int amountToWithdraw)
    {
        var account = SystemDB.Instance.Accounts.Find(acc => acc.AccountNum == accountNum);

        if (account != null)
        {
            if (account is SavingsAccount)
            {
                _withdrawalService.WithdrawFromSavings((SavingsAccount)account, amountToWithdraw);
            }
            else if (account is CurrentAccount)
            {
                _withdrawalService.WithdrawFromCurrent((CurrentAccount)account, amountToWithdraw);
            }
        }
        else
        {
            Console.WriteLine("Account not found!");
        }
    }
}
