/*Программа 
считает квадрат целого числа
*/

Console.WriteLine("");
Console.Write("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("");

int sqrnumber = number * number;

Console.WriteLine("Квадрат Вашего числа = " + sqrnumber);
Console.WriteLine("");

/*Можно сделать так

  Console.WriteLine($"Квадрат Вашего числа = {sqrnumber}");
*/  
