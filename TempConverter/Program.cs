// Store a Fahrenheit temperature

decimal fahrenheit = 94m;


// Convert it to Celsius

decimal celsius = (fahrenheit - 32) * 5 / 9;

// Display the result

Console.WriteLine($"{fahrenheit:F1}°F is {celsius:F1}°C");