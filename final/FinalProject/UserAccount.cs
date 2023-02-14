public class UserAccount
{
    private int accountNumber;
    private int pin;
    private double balance;

    public UserAccount(int accountNumber, int pin, double balance)
    {
        this.accountNumber = accountNumber;
        this.pin = pin;
        this.balance = balance;
    }

    public double GetBalance()
    {
        return balance;
    }

    public void Deposit(double amount)
    {
        balance += amount;
    }

    public void PayBills(double amount)
    {
        balance -= amount;
    }

    public bool VerifyPin(int pin)
    {
        return this.pin == pin;
    }
}