// сколько чисел больше 0 ввёл пользователь
Console.WriteLine("Введите количество цифр: ");
int n = int.Parse (Console.ReadLine());
int [] number = new int[n];
int i = 0;
for(int j = 1; j <= n; j++)
{
    Console.WriteLine($"Введите число {j}: ");
    number[i] = int.Parse (Console.ReadLine());
    i++;
} 

int count = 0;
for(i = 0; i < n; i++)
{
    if(number[i] > 0) count++;
}
Console.WriteLine(count);