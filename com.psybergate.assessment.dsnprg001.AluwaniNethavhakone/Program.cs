using com.psybergate.assessment.dsnprg001.AluwaniNethavhakone.Contracts;
using com.psybergate.assessment.dsnprg001.AluwaniNethavhakone.Database;
using com.psybergate.assessment.dsnprg001.AluwaniNethavhakone.Services;
using Microsoft.Extensions.DependencyInjection;
using System;

var services = new ServiceCollection();
services.AddScoped<IAccountService, AccountService>();
services.AddScoped<IWithdrawalService, WithdrawalService>();
services.AddSingleton<SystemDB>();

var serviceProvider = services.BuildServiceProvider();

var accountService = serviceProvider.GetRequiredService<IAccountService>();

// Choose account type (1 for Savings, 2 for Current)
Console.WriteLine("Enter account type (1 for Savings, 2 for Current): ");
int accountType = int.Parse(Console.ReadLine());

// Enter account number
Console.WriteLine("Enter account number: ");
long accountNum = long.Parse(Console.ReadLine());

// Enter withdrawal amount
Console.WriteLine("Enter amount to withdraw: ");
int amountToWithdraw = int.Parse(Console.ReadLine());

if (accountType == 1)
{
    accountService.Withdraw(accountNum, amountToWithdraw);
}
else if (accountType == 2)
{
    accountService.Withdraw(accountNum, amountToWithdraw);
}
else
{
    Console.WriteLine("Invalid account type.");
}

