//Является ли первое число квадратом второго

Console.WriteLine("Введите число1 ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число2 ");
int number2 = Convert.ToInt32(Console.ReadLine());


int sqrnumber2 = number2 * number2;

if (number1 == sqrnumber2)
{
    Console.WriteLine("Первое число является квадратом Вашего второго числа");
}
else
{
    Console.WriteLine("Первое число не является квадратом Вашего второго числа");
}