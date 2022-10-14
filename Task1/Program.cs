/*Программа 
считает квадрат целого числа
*/

Console.Write("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());

int sqrnumber = number * number;

Console.WriteLine("Квадрат Вашего числа = " + sqrnumber);

/*Можно сделать так

  Console.WriteLine($"Квадрат Вашего числа = {sqrnumber}");
*/  
