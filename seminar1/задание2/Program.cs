// See https://aka.ms/new-console-template for more information

// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22
Console.Write("Введите первое число -> ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число -> ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число -> ");
int d = Convert.ToInt32(Console.ReadLine());
if (a > b && a > d) {
    Console.WriteLine($"Максимальное чило из трёх чисел = {a}");
}
if (b > a && b > d){
     Console.WriteLine($"Максимальное чило из трёх чисел = {b}");
}
if (d > a && d > b) {
     Console.WriteLine($"Максимальное чило из трёх чисел = {d}");
}