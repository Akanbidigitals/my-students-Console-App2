// See https://aka.ms/new-console-template for more information

// we want to create an student object from our student class ;

using secondConsoleApp;

/*var student1 = new Student();  // declaring the object class and saving it in student1

student1.Name = "lakan";
student1.Age = 20;
student1.MatricNumber = "st/nd/fo9/1445";

Console.WriteLine(student1.Name);
Console.WriteLine(student1.Age);
Console.WriteLine(student1.MatricNumber);*/


// For class Car 

/*
var car1 = new Car();


/// First way 
car1.Model = "Nissan";
car1.Color = "Red";
car1.Year = 2000;

Console.WriteLine(car1.Model);
Console.WriteLine(car1.Color);
Console.WriteLine(car1.Year);
*/

// Second way 
/*var car2 = new Car() {Model = "Toyota", Color = "Green" , Year = 2002};

Console.WriteLine(car2.Model);
Console.WriteLine(car2.Color);
Console.WriteLine(car2.Year);*/

/*using secondConsoleApp;

var calc1 = new Calculator(); */// create object

//calc1.Greet(); // we call greet method from our calculator class

/*
var addresult = calc1.AddNumbers();  // calling the method add number from the calculator class
Console.WriteLine(addresult);
*/

/*var name = calc1.MethodName();
Console.WriteLine($"welcome {name} from calculator class");*/

// Calling our calc1 object with methods that has parameters 

/*
string[] students = {"Barakat", "Fatimah", "Jumah"};

foreach (var student in students)
{
    calc1.WelcomeMsg($"{student}");
}*/

/*
var additionResult = calc1.AddnumberwithParam(10 , 20);

Console.WriteLine(additionResult);*/



var customer1 = new Customer(); // object for customer

Console.WriteLine("-----------------------------");
Console.WriteLine("====>Welcome to Lapo Bank<====");
Console.WriteLine("-----------------------------");
Console.Write("Enter your firstname :  ");

customer1.FirstName = Console.ReadLine();

Console.WriteLine("-----------------------------");
Console.WriteLine("-----------------------------");
Console.Write("Enter your Lastname :  ");
customer1.LastName = Console.ReadLine();

Console.WriteLine("-----------------------------");
Console.WriteLine("-----------------------------");
Console.Write("Enter your Email : ");
customer1.Email = Console.ReadLine();

// calling method that generates account number
customer1.GenerateAccountNumber();

Console.WriteLine("-----------------------------");
Console.WriteLine("====>Customer Profile <====");
Console.WriteLine($"First name: {customer1.FirstName}");
Console.WriteLine($"Last name: {customer1.LastName}");
Console.WriteLine($"Email: {customer1.Email}");
Console.WriteLine($"Account number: {customer1.AccountNumber}");
Console.WriteLine($"Account created time and date : {customer1.CreatedAt}");



Console.WriteLine("-----------------------------");
