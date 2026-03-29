namespace secondConsoleApp;

public static class LapoCustomerService
{
   private static List<LapoCustomer> _customers = new List<LapoCustomer>();

   // Create Custumer
   public static void CreateCustumer(string name)
   {
      string acctNo = GenerateAccountNumber(); // Acct number generation
      var lapocustumer = new LapoCustomer(name, acctNo ); // adding values the constructor to the constructor
      _customers.Add(lapocustumer); // Added the customer 
      Console.WriteLine("-------New Customer Alert------");
      Console.WriteLine($"Name : {lapocustumer.Name}. \nAccountNumber : {lapocustumer.AccountNumber}.\nDateCreated : {lapocustumer.CreatedAt}");
   }

   // get customers
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
   // Update Custumer
   public static void UpdateCustomer(string acctno, string newname)
   {
      var getcustomer = _customers.FirstOrDefault(c => c.AccountNumber == acctno); //  chcek for account numer
      if (getcustomer == null)
      {
         Console.WriteLine("Customer not found");
      }

      getcustomer.Name = newname;
      
      Console.WriteLine("-------Update Customer Alert------");
      Console.WriteLine("Customer name updated successfully");

   }
   
   // Delete Custumer
   public static void DeleteCustomer(string acctno)
   {
      
      var getcustomer = _customers.FirstOrDefault(c => c.AccountNumber == acctno); //  chcek for account numer
      if (getcustomer == null)
      {
         Console.WriteLine("Customer not found");
      }
      
      _customers.Remove(getcustomer);
      Console.WriteLine("-------Delete Customer Alert------");
      Console.WriteLine("Customer deleted successfully");
   }
   
   
   private static string GenerateAccountNumber()
   {
      Random rand = new Random();
      return rand.Next(9999, int.MaxValue).ToString();
   }
}
//Crud