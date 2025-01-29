// See https://aka.ms/new-console-template for more information
using oopPro;

Console.WriteLine("Hello, World!");
Console.WriteLine("Day One!");

Console.WriteLine("--------Day Two Task-------------");
Console.WriteLine("--------Day Two Task Bank Account-------------");
BankAccount account1 = new BankAccount();
account1.AccountName = "John Doe";
account1.AccountNumber = "1234567890";

BankAccount account2 = new BankAccount();
account2.AccountName = "Jane Doe";
account2.AccountNumber = "0987654321";
account2.Deposit(500);

account1.Deposit(1000);
account1.Withdrawals(500);
account1.Transfer(account2, 200);
Console.WriteLine(account1.balance);

Console.WriteLine("--------Day Two Task Credit Card-------------");
CreditCard card1 = new CreditCard();
card1.CardHolderName = "John Doe";  

card1.Withdraw(20000);
card1.PayBill(20000);
Console.WriteLine(card1.CurrentBalance);
