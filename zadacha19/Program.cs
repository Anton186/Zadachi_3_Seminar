// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да


Console.WriteLine("Напишите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < -9999 && number > -100000)
{
    number *=-1;
}
if (number > 9999 && number < 100000)
{
    int number1 = number / 10000;
    int number5 = number %10;
    if (number1 == number5)
    {
        int number2 = number / 1000 %10;
        int number4 = number %100 /10;
        if (number2 == number4)
        {
            Console.WriteLine("Число является палиндромом");
        }
        else
        {
            Console.WriteLine("Число не является палиндромом");
        }
    }
    else
        {
            Console.WriteLine("Число не является палиндромом");
        }
}
else
{
    Console.WriteLine("Это не пятизначное число");
}