// Declare variables
double principal, rate, time, interest;

// Get user input
Console.Write("Enter Principal amount: ");
principal = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter Rate of interest (%): ");
rate = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter Time (in years): ");
time = Convert.ToDouble(Console.ReadLine());

// Calculate simple interest
interest = (principal * rate * time) / 100;

// Display the result
Console.WriteLine("Simple Interest: " + interest);
