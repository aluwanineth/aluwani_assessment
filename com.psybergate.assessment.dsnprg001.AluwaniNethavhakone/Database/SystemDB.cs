using com.psybergate.assessment.dsnprg001.AluwaniNethavhakone.Businesses;
using com.psybergate.assessment.dsnprg001.AluwaniNethavhakone.Models;

namespace com.psybergate.assessment.dsnprg001.AluwaniNethavhakone.Database;

public class SystemDB
{
    private static SystemDB instance;
    private readonly List<Account> accounts;

    private SystemDB()
    {
        accounts = new List<Account>();
    }

    public static SystemDB Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new SystemDB();
                instance.Initialize(); // Initialize with hardcoded accounts
            }
            return instance;
        }
    }

    public List<Account> Accounts => accounts;

    private void Initialize()
    {
        accounts.Add(new SavingsAccount(101, 1, 2000));
        accounts.Add(new SavingsAccount(102, 2, 5000));
        accounts.Add(new CurrentAccount(103, 3, 1000, 10000));
        accounts.Add(new CurrentAccount(104, 4, -5000, 20000));
    }
}
