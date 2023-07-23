Console.Write("Enter a number: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number == 1)
{
    Console.Write($"The {number} corresponds to Monday");
} 
else if (number == 2) 
{
    Console.Write($"The {number} corresponds to Tuesday");
}
else if (number == 3) 
{
    Console.Write($"The {number} corresponds to Wednesday");
}
else if (number == 4) 
{
    Console.Write($"The {number} corresponds to Thursday");
}
else if (number == 5) 
{
    Console.Write($"The {number} corresponds to Friday");
}
else if (number == 6) 
{
    Console.Write($"The {number} corresponds to Saturday");
}
else if (number == 7) 
{
    Console.Write($"The {number} corresponds to Sunday");
}
else 
{
    Console.Write($"The {number} does not correspond to any day of week");
}