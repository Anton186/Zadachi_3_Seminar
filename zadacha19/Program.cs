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
    
}
else
{
    Console.WriteLine("Это не пятизначное число");
}