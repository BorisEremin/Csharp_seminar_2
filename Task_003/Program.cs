//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет

System.Console.Write("Введите день недели(число): ");
int day = Convert.ToInt32(Console.ReadLine());

if(day >= 1 && day <=5)
{
    System.Console.WriteLine("Рабочий день.");
}
else if(day == 6 || day == 7)
{
    System.Console.WriteLine("Выходной день.");
}
else
{
    System.Console.WriteLine("Нет такого дня недели.");
}