namespace oopPro;

public class DayTwoTask
{
public void Main()
{
    BankAccount account1 = new BankAccount();
    account1.AccountName = "John Doe";
    account1.AccountNumber = "1234567890";
    account1.Deposit(1000);
Console.WriteLine(account1.balance);
    
    
}

}
