using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.psybergate.assessment.dsnprg001.AluwaniNethavhakone.Models
{
    public class Account
    {
        public long Id { get; set; }
        public long AccountNum { get; set; }
        public int Balance { get; set; }

        public Account(long id, long accountNum, int balance)
        {
            Id = id;
            AccountNum = accountNum;
            Balance = balance;
        }
    }
}
