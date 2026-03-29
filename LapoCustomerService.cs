namespace secondConsoleApp;

public static class LapoCustomerService
{
   private static List<LapoCustomer> _customers = new List<LapoCustomer>();

   public static void CreateCustumer(string name)
   {
      string acctNo = GenerateAccountNumer(); // Acct number generation
      var lapocustumer = new LapoCustomer(name, acctNo ); // adding values the constructor to the constructor
      _customers.Add(lapocustumer); // Added the customer 
      Console.WriteLine("-------New Customer Alert------");
      Console.WriteLine($"Name : {lapocustumer.Name}. \nAccountNumber : {lapocustumer.AccountNumber}.\nDateCreated : {lapocustumer.CreatedAt}");
   }

   public static void ViewCustomers()
   {
      if (_customers.Count == 0)
      {
         Console.WriteLine("No customer found");
      }

      foreach (var customer in _customers)
      {
         Console.WriteLine("-------Get Customer Alert------");
         Console.WriteLine($"Name : {customer.Name}. \nAccountNumber : {customer.AccountNumber}.\nDateCreated : {customer.CreatedAt}");
      }
   }
   
   
   public static string GenerateAccountNumer()
   {
      Random rand = new Random();
      return rand.Next(9999, int.MaxValue).ToString();
   }
}
//Crud