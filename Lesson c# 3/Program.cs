// Задача 24: Напишите программу, которая принимает 
// на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

// тип возвращающего значения + Название + () + {}

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());

int GetSum()
{
    int start = 1;
    int sum=0;
     
    while(start<= num)
    {
        sum += start;
     // sum = sum +start;
        start++;
    }
    return sum;
}

// int result= GetSum();
// System.Console.WriteLine(result);

System.Console.WriteLine(GetSum());