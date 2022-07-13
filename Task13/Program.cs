/* Задача 13: Напишите программу,
которая с помощью деления выводит третью цифру заданного числа
или сообщает, что третьей цифры нет.
*/
Console.WriteLine("Введите целое положительное число:");
int number = Convert.ToInt32(Console.ReadLine());
string result = "";
if (number < 0)
{
    Console.WriteLine("Неверное число! Завершите сеанс нажатием любой клавиши.");
    Console.ReadKey();
    return;
}
else
{
    if (number / 100 > 0)
{
    result = Convert.ToString(number);
    Console.WriteLine("Третья цифра введенного числа:");
    Console.WriteLine(result[2]);
}
else
{
    Console.WriteLine("Веденое число не имеет третьего знака");
}
}
Console.Write("Нажмите любую клавишу для завершения программы");
Console.ReadKey();