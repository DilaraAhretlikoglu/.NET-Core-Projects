class User
{
    public string Username{ get; private set;}
    public string Password{ get; private set;}
    public decimal Balance{ get; set;}

    public User(string username, string password, decimal balance)
    {
        Username = username;
        Password = password;
        Balance = balance;
    }
}