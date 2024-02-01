using com.psybergate.assessment.dsnprg001.AluwaniNethavhakone.Models;

namespace com.psybergate.assessment.dsnprg001.AluwaniNethavhakone.Businesses;

public class CurrentAccount : Account
{
    public int Overdraft { get; }

    public CurrentAccount(long id, long accountNum, int balance, int overdraft) : base(id, accountNum, balance)
    {
        Overdraft = overdraft;
    }
}
