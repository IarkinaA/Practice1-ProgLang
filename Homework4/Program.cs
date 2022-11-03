// Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите число");
int n = Convert.ToInt32(Console.ReadLine());

int iter = 1;

while (iter<=n)
{
    if(iter%2 == 0) {
        Console.WriteLine(iter);
    }
    iter++;
}
