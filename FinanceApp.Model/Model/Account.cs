namespace FinanceApp.Model;

public abstract class Account
{
    //Private balance variable. Can't be set from outside the class
    private decimal _balance;

    //Public property representing Account name
    public string Name { get; private set; }

    public Account(string name)
    {
        Name = name;
        _balance = 0m;
    }

    /*
    * Returns the current balance of the account
    */
    public decimal GetCurrentBalance()
    {
        return _balance < 0m ? 0m : _balance;
    }

    /*
    * Sets the current balance of the account
    */
    public void SetCurrentBalance(decimal balance)
    {
        _balance = balance < 0 ? 0 : balance;
    }

}