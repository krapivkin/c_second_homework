// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.WriteLine("This Program displays second digi of three-digit number. Enjoy.");
int number = 0;

while (number.ToString().Length < 3 || number.ToString().Length > 3)
{
    Console.WriteLine("Enter three-digit number:  ");
    try
    {
        number= Math.Abs(Convert.ToInt32(Console.ReadLine()));
    }
    catch (System.FormatException)
   {
        Console.WriteLine("Unknown error.");
        break;
    }
    if (number.ToString().Length < 3 || number.ToString().Length > 3)
    {
        Console.WriteLine("Please enter three-digit number.");
    }
    else
    {
        int num2 = 0;
        while (number.ToString().Length >= 2)
        {
            num2 = number % 10;
            number = number / 10;
        }
        Console.WriteLine($"Secound digit of the number: {num2}");
        break;
    }
}
 