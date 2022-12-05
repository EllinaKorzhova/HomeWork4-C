

/*Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.*/
//получение числа с консоли
int GetNumber(string message)
{
    bool isCorrect = false;
    int result = 0;

    while (!isCorrect)
    {
        Console.WriteLine(message);
        if (int.TryParse(Console.ReadLine(), out result)){
            isCorrect = true;
        } else {
            Console.WriteLine("Ввели не число");
        }
    } 
return result;
    }



    int GetSumm(int numberA, int numberB){
        int result = 1;
        for(int i = 1; i <= numberB; i++){
        result = result * numberA;
  }
 return result;
    }

    int numberA = GetNumber("Введите число A");
    int numberB = GetNumber("Введите число B");
   int result = GetSumm(numberA, numberB);
    Console.WriteLine($"Результатом возвдения {numberA} в степень {numberB} = {result}");