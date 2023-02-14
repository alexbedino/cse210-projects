public class ATMApp
{
    private UserAccount userAccount;

    public ATMApp()
    {
        int accountNumber = 5000000;
        int pin = 1234;
        double balance = 1000;
        userAccount = new UserAccount(accountNumber, pin, balance);
    }

    public void Run()
    {
        int cardNumber = Utility.GetCardNumber();
        int pin = Utility.GetPin();
        if (cardNumber != 5000000 || !userAccount.VerifyPin(pin))
        {
            AppScreen.ShowMessage("Invalid card number or PIN");
            return;
        }

        while (true)
        {
            int choice = AppScreen.GetMenuChoice();
            switch (choice)
            {
                case 1:
                    double depositAmount = AppScreen.GetAmount();
                    userAccount.Deposit(depositAmount);
                    AppScreen.ShowMessage("Deposit successful");
                    break;

                case 2:
                    double balance = userAccount.GetBalance();
                    AppScreen.ShowBalance(balance);
                    break;

                case 3:
                    double paymentAmount = AppScreen.GetAmount();
                    if (paymentAmount > userAccount.GetBalance())
                    {
                        AppScreen.ShowMessage("Insufficient funds");
                        break;
                    }
                    userAccount.PayBills(paymentAmount);
                    AppScreen.ShowMessage("Payment successful");
                    break;

                case 4:
                    AppScreen.ShowMessage("Exiting app");
                    return;

                default:
                    AppScreen.ShowMessage("Invalid choice");
                    break;
            }
        }
    }
}