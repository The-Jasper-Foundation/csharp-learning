// Store a Fahrenheit temperature

Console.WriteLine("Enter A tempreture: ");

Console.Write("Fahrenheit: ");

decimal fahrenheit = Convert.ToDecimal(Console.ReadLine());


// Convert it to Celsius

decimal celsius = (fahrenheit - 32) * 5 / 9;

// Display the result

Console.WriteLine($"{fahrenheit:F1}°F is {celsius:F1}°C");