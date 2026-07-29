int age = 42;
double monthlyIncome = 72000;

// Else-if ladder to categorize based on age and monthly income
if (age >= 25 && age <= 35 && monthlyIncome > 50000)
{
    Console.WriteLine("Category: Young Professional");
}
else if (age >= 36 && age <= 55 && monthlyIncome > 70000)
{
    Console.WriteLine("Category: Middle-Aged Professional");
}
else if (age >= 56 && monthlyIncome < 30000)
{
    Console.WriteLine("Category: Senior Citizen");
}
else
{
    Console.WriteLine("Category: Other");
}
