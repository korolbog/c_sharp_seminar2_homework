/*
Напишите программу,
которая принимает на вход цифру, обозначающую день недели,
и проверяет, является ли этот день выходным:
6 -> да
7 -> да
1 -> нет
*/

Console.Write("Введите номер дня недели: ");
int numberOfDay = Convert.ToInt32(Console.ReadLine());
string[] week = new string[] {"понедельник", "вторник", "среда", "четверг", "пятница", "суббота", "воскресенье"};
int index = numberOfDay - 1;

if (index < 0)
{
        Console.WriteLine("Неверное указано число!");
}
else
{
    if (index >-1 && index<4)
    {
        Console.WriteLine(week[index] + " не выходной :(");
    }
    else
    {
        if (index < 5)
        {
            Console.WriteLine(week[index] + " не выходной, хотя если с утра выпил, то весь день свободен :)");
        }
        else
        {
            Console.WriteLine(week[index] + " - это выходной :)");
        } 
    }
}
Console.Write("Нажмите любую клавишу для завершени программы.");
Console.ReadKey();