namespace secondConsoleApp;

public class LapoCustomer
{
    public string Name { get; set; }
    public string AccountNumber { get; set; }
    public DateTime CreatedAt { get; private set; }

    public LapoCustomer(string name, string accountNumber)
    {
        Name = name;
        AccountNumber = accountNumber;
        CreatedAt = DateTime.Now;
    }
    
}
// CRUD => C- Create , R- Read , U- Update , D- Delete