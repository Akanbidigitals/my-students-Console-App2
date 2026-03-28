namespace secondConsoleApp;

public class Car
{
    public string Model { get; set; } // get , set => active 
    public int Year { get;  set; } // get , set => active 
    public string Color { get; set; } // you can set but not get
    
    //public string ChasisNumner { get; set; }  //u can get but cant set , use default chasis.
}

// Private ==>  this is an access modifier where u can use the properties only in th same class