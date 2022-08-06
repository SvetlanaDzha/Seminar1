// Написать программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N

Console.Write("Введите случайное число N: ");
int N = Convert.ToInt32(Console.ReadLine());

int counter = -N;
while (counter <= N)
{
    Console.WriteLine(counter);
    counter++;
}