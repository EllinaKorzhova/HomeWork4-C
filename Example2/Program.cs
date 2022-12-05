/*Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.*/

Console.Write("Введите число N: ");
int number = Convert.ToInt32(Console.ReadLine());

int sumOfNumber(int num)
{
    int result = 0;
    int finish = 0;
    while (num >= 10)
    {
        result = num % 10;
        finish += result;
        num = num / 10;
    } 
    finish += num;
    return finish;
}

int sumNumber = sumOfNumber(number);
Console.WriteLine("Сумма цифр в числе: " + sumNumber);
