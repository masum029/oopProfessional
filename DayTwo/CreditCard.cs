namespace oopPro;

public class CreditCard
{
//Design a Credit Card class with a maximum limit of 500K. The class should allow cash withdrawals with a daily limit of 100K and a per-transaction limit of 20K. 

// For bill payments, there should be no limit as long as the total spending does not exceed the maximum limit of 500K.

private const double maxLimit = 500000;
private const double dailyLimit = 100000;
private const double transactionLimit = 20000;


    public string CardHolderName;
    public double CurrentBalance  = maxLimit;
    private double DailyWithdrawalTotal  = 0;
    private DateTime LastWithdrawalDate  = DateTime.MinValue;

    public void Withdraw(double amount)
    {
        if (amount < 0)
        {
            throw new Exception("Amount cannot be negative");
        }

        if (amount > transactionLimit)
        {
            throw new Exception("Amount exceeds transaction limit");
        }

        if (amount > dailyLimit)
        {
            throw new Exception("Amount exceeds daily limit");
        }

        if (amount > CurrentBalance)
        {
            throw new Exception("Insufficient funds");
        }

        if (DateTime.Today != LastWithdrawalDate)
        {
            DailyWithdrawalTotal = 0;
        }

        if (DailyWithdrawalTotal + amount > dailyLimit)
        {
            throw new Exception("Daily withdrawal limit exceeded");
        }

        CurrentBalance -= amount;
        DailyWithdrawalTotal += amount;
        LastWithdrawalDate = DateTime.Today;
    }

    public void PayBill(double amount)
    {
        if (amount < 0)
        {
            throw new Exception("Amount cannot be negative");
        }

        if (amount > CurrentBalance)
        {
            throw new Exception("Insufficient funds");
        }

        CurrentBalance -= amount;
    }

}
