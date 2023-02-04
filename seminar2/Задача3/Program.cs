// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет
Console.WriteLine("Введите номер дня");
int num = Convert.ToInt32(Console.ReadLine());
if (num>0&&num<8){
    if(num == 6 || num ==7){
    Console.WriteLine("Да");
}
else {
     Console.WriteLine("Нет");
}

}
else{
    Console.WriteLine ("Такого дня нет");
}
