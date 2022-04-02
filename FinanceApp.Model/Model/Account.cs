namespace FinanceApp.Model;

public abstract class Account
{
    //Private balance variable. Can't be set from outside the class
    private decimal _balance;

    // Private transaction collection
    private IList<Transaction> _transacions;

    //Public property representing Account name
    public string Name { get; private set; }

    public Account(string name)
    {
        Name = name;
        _balance = 0m;
        _transacions = new List<Transaction>();
    }

    /*
    * Returns the current balance of the account
    */
    public decimal GetCurrentBalance()
    {
        return _balance < 0m ? 0m : _balance;
    }

    /*
    * Get a collection of transactions that were processed for the account
    * virtual: can be overriden in derived classes to provide specific implementations related to specific accounts
    */

    public virtual IList<Transaction> GetAllTransactions()
    {
        return _transacions;
    }
}