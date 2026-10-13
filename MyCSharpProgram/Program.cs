// See https://aka.ms/new-console-template for more information


int x; //declaration

x = 123; //initialisation

int y = 321;

int z = x * y;

Console.WriteLine(x);
Console.WriteLine(z);

int age = 21; 

char symbol = '@';
String name = "John";

Console.WriteLine("hello " + name);
    
Console.WriteLine("Your age is " + age);

Console.WriteLine("Hello, World!");
Console.WriteLine("This is a sample C# program picked up from Bro Code using MAC");


String userName = symbol + name;
Console.WriteLine("Hello " + userName);

// above are the variables now we move on to constants
// for example pi is a constant (it never changes!)

// now type casting 
Console.WriteLine("Now moving on to type casting");
double a = 3.14;
int b = Convert.ToInt32(a);

Console.WriteLine($"The data type for a is:{a.GetType().Name}");
Console.WriteLine($"The  data type for b is:{b.GetType().Name}");

Console.WriteLine($"B is: {b}");


