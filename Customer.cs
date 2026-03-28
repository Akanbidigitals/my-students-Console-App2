namespace secondConsoleApp;

public class Customer
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    
    public string AccountNumber { get; private set; }
    
    public DateTime CreatedAt { get; private set; } = DateTime.Now;

    public void GenerateAccountNumber()
    {
        Random random = new Random();
        // acct number = 7778888837746746746746746464
        // .Substring(7,10) => 3774674674
        //generate 10 digit number 
        AccountNumber = random.Next(1000000000, int.MaxValue).ToString().Substring(0, 10);
    }
}