// // 
// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6
Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
if (num > 1000)
{
    int num1=num; 
    while (num > 1000)
    {
      num /=10;  
    }
    Console.WriteLine($"третья цифра числа {num1} = {num % 10}");
}
else if (num >= 100&&num<1000 )
{
     Console.WriteLine($"третья цифра числа {num} = {num % 10}");
}
else{Console.WriteLine("третьей цифры нет");}
