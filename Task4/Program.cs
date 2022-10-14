/*Программа, которая на вход принимает 
одно число (N), а на выходе показывает все целые 
числа в промежутке от -N до N.
*/

Console.WriteLine("ВВедите любое число ");

int N = Convert.ToInt32(Console.ReadLine());
int negativN = N * (-1);
while (negativN <= N) 
{
    Console.Write(negativN); Console.Write("   ");
    negativN++;
}
