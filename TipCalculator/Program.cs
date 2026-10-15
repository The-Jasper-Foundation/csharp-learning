/* // See https://aka.ms/new-console-template for more information
 
Console.WriteLine("Hello, Welcome This is what I have done thus far to learn C#");

// Collect the bill amount and tip percentage

Console.WriteLine("Enter your bill details:\n");
Console.Write("Bill amount:    ");
decimal billAmount = Convert.ToDecimal(Console.ReadLine());
Console.Write("Tip percentage: ");
decimal tipPercentage = Convert.ToDecimal(Console.ReadLine());

// Display the entered values

Console.WriteLine("\nBill details:");
Console.WriteLine($"  Bill amount:    {billAmount:C}");
Console.WriteLine($"  Tip percentage: {tipPercentage}%");

// Calculate the tip and total

decimal tipAmount = billAmount * (tipPercentage / 100);
decimal totalAmount = billAmount + tipAmount;

// Display the results

Console.WriteLine($"\nTip amount:   {tipAmount:C}");
Console.WriteLine($"Total amount: {totalAmount:C}");

/* different ways to present the numbers

decimal price = 1234.5m;

Console.WriteLine($"{price:C}");         // currency symbol comes from your Mac's region
Console.WriteLine($"${price:F2}");       // $1234.50
Console.WriteLine($"${price:N2}");       // $1,234.50
Console.WriteLine(price.ToString("F2")); // 1234.50, same idea without interpolation

This next one shows the importance of m as it ensures the code actually picks up the decimal !

Console.WriteLine(0.1 + 0.2 == 0.3);
Console.WriteLine(0.1m + 0.2m == 0.3m);

*/


decimal num1 = 42.75m;
decimal num2 = 39.10m;

decimal larger  = Math.Max(num1, num2);   // 42.75
decimal smaller = Math.Min(num1, num2);   // 39.10

Console.WriteLine(num1 > num2);    // True
Console.WriteLine(num1 <= num2);   // False
Console.WriteLine(num1 == num2);   // False