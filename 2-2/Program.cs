// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет
Console.WriteLine("This Program displays third digi of three-digit number or reports that there is no third digit.Enjoy.");
int num= 0;

while (num.ToString().Length < 3)
{
    Console.WriteLine("Enter a number: ");
    try
    {
       num = Math.Abs(Convert.ToInt32(Console.ReadLine()));
    }
    catch (System.FormatException)
    {
        Console.WriteLine("Unknown error.");
        break;
    }
    if (num.ToString().Length < 3)
    {
        Console.WriteLine("Number does not have a third digit!");
    }
    else
    {
        int num1 = 0;
        while (num.ToString().Length >= 3)
        {
            num1 = num % 10;
            num = num / 10;
        }
        Console.WriteLine($"Third digit of your number: {num1}");
        break;
    }
}