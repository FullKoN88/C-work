// Задача 4: Напишите программу, которая на вход принимает натуральное число N, а на выходе показывает его цифры через запятую.

System.Console.WriteLine("Введите натуральное число N: ");
int N = Convert.ToInt32(Console.ReadLine());

if(N < 10)
{
    System.Console.WriteLine(N);
}

else
{
    while( N > 0)
    {
        int current = N % 10;
        N /= 10;
        if ( N > 0)
        {
            System.Console.Write(current + ",");
        }
        else
        {
            System.Console.Write(current);
        }
    }
}