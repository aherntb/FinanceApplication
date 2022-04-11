namespace FinanceApp.Model;

public abstract class Account
{
    public string Name { get; private set; }

    private decimal _openingBalance;
    private decimal _closingBalance;

    public Account(string name)
    {
        Name = name;
    }

    public virtual void SetCurrentBalance(decimal balance)
    {
        _openingBalance = _closingBalance;
        _closingBalance = balance;
    }
}