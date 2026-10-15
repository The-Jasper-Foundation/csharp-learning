// Store a Fahrenheit temperature

Console.WriteLine("Enter a temperature: ");

Console.Write("In Fahrenheit: ");

if (decimal.TryParse(Console.ReadLine(), out decimal fahrenheit))
{
    // Convert it to Celsius
    decimal celsius = (fahrenheit - 32) * 5 / 9;
    // Display the result
    Console.WriteLine($"{fahrenheit:F1}°F is {celsius:F1}°C");
}
else
{
    Console.WriteLine("Invalid input, enter a number! ");
};
