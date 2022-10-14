/*Программа, которая принимает на вход 
трёхзначное число и на выходе показывает последнюю цифру 
этого числа
*/

Console.Clear();
Console.WriteLine("Введите трехзначное число");
Console.WriteLine();

string stringN = Convert.ToString(Console.ReadLine());

if (stringN.Length < 3) Console.WriteLine("Число должно быть трехзначным");

/* Можно так:

int N = Convert.ToInt32(Console.ReadLine());
string stringN = Convert.ToString(N);

*/

Console.WriteLine();
Console.WriteLine("Последняя цифра этого числа: " + stringN[2]);
Console.WriteLine();