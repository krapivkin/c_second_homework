//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine ("This Program Help you find out if this day is a day off");
int num1 = 0;
Console.WriteLine("Enter weekday number: ");
int num = Convert.ToInt32(Console.ReadLine());

    if (num == 6||num == 7)
{
    Console.WriteLine("Day off.");
}
    else if (num <1||num >5)
{
    Console.WriteLine("Enter number from 1 to 7");
}
    else  
{
    Console.WriteLine("Working day.");
}