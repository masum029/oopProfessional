namespace oopPro;

#region Task BankAccount
// Create a BankAccount class that includes properties for account number, account name, and balance. 

// The class should have methods for withdrawing, depositing, and transferring funds between accounts. 

// Ensure that withdrawals or transfers do not result in a negative balance.
#endregion

public class BankAccount
{
public string AccountName;
public string AccountNumber;
public double balance;


public void Deposit(double amount)
{
    if (amount < 0){
        throw new Exception("Amount cannot be negative");
    }
        balance += amount;
    }


    public void Withdrawals(double amount)
{
    if (amount < 0){
        throw new Exception("Amount cannot be negative");
    }

    if(amount > balance){
        throw new Exception("Insufficient funds");
    }

        balance -= amount;
    }


    public double Transfer(BankAccount destinationAccount, double amount){
        if (amount < 0){
        throw new Exception("Amount cannot be negative");
    }   
    
    
    if(amount > balance){
        throw new Exception("Insufficient funds");
    }
        balance -= amount;
        destinationAccount.Deposit(amount);
        return balance;
    }
        

}









