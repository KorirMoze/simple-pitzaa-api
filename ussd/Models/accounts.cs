public class Account
{
    public int AccountID {get; set;}
    public int CustomerID {get; set;}
    public decimal Balance {get; set;}
}

public class Transaction
{
    public int TransactionId {get; set;}
    public in AccountID {get; set;}
    public int Amount {get; set;}
}