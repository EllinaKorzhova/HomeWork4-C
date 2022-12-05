/*Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33] */

void Array(){
    int[] a = new int[8];
    int i = 0;
    int num = 0;

    while(i < 8){
        Console.Write($"Введите элемент с индексом {i}: ");
        num = Convert.ToInt32(Console.ReadLine());
        a[i] = num;
        i++;
    }
    string ar = string.Join(", ", a);
    Console.WriteLine($"[{ar}]");
}
Array();