/* Программу, которая будет выдавать 
название дня недели по заданному номеру;
*/

Console.WriteLine("");
Console.Write("Введите номер дня недели (от 1 до 7) ");

int number = Convert.ToInt32(Console.ReadLine());

if (number > 7 || number < 1)
{
    Console.WriteLine("Дней недели всего 7, введите число от 1 до 7 ");
}

else
{

if (number == 1) 
{
    Console.WriteLine("Это понедельник");
}
if (number == 2) 
{
    Console.WriteLine("Это вторник");
}
if (number == 3) 
{
    Console.WriteLine("Это среда");
}
if (number == 4) 
{
    Console.WriteLine("Это четверг");
}
if (number == 5) 
{
    Console.WriteLine("Это пятница");
}
if (number == 6) 
{
    Console.WriteLine("Это суббота");
}
if (number == 7) 
{
    Console.WriteLine("Это воскресенье");
}
}