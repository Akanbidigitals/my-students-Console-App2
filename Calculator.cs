namespace secondConsoleApp;

public class Calculator
{
    public int AddNumbers()
    {
        int a = 10;
        int b = 2;

        var result = a + b;
        
        return result;
    }

    public void Greet()
    {
        Console.WriteLine("Hello Students, I am greeting you from the calculator class");
    }

    public string MethodName()
    {
        return "Lakan"; 
    }

    public double acctbalance()
    {
        var balance = 33.86;
        return balance;
    }
    
    // Adding methods with parameters 

    public int AddnumberwithParam(int a , int b )
    {
        return a + b;
    }
    public int SubtractnumberwithParam(int a , int b)
    {
        return a - b;
    }

    public void WelcomeMsg(string name)
    {
        Console.WriteLine($"Thank for joining this clas {name} , you are highly regarded");
    }
    
}



//Methods 
// A method is block of code inside a class that performs an action;



