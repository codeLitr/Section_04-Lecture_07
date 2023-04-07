// Какие могут быть проблемы с рекурсией (обратная сторона ее использования) на примере расчета чисел Фибоначчи.

decimal fRec = 0;
decimal fIte = 0;

decimal FibonacciRecursion(int n)
{
    fRec++;
    return n == 0 || n == 1 ? 1 : FibonacciRecursion(n - 1) + FibonacciRecursion (n - 2);
}

decimal FibonacciIteration(int n)
{
    fIte++;
    decimal result = 1;
    decimal f0 = 1;
    decimal f1 = 1;
    for (int i = 2; i <= n; i++)    
    {
        result = f0 + f1;

        f0 = f1;
        f1 = result;
        fIte++;
    }
    return result;
}

Console.ReadLine(); // Пишется, чтобы расчет начинался по нажатию Enter.
DateTime dt = DateTime.Now; // Покажет время до начала подсчета.
for (int n = 10; n < 40; n++) // Расчет чисел от 10 до 40.
{
    System.Console.WriteLine($"FibonacciIteration({n}) = {FibonacciIteration(n)} fIte = {fIte.ToString("### ### ###"), -15}");
    fIte = 0; // Обнуляет переменную, после того подсчиталось.
}
System.Console.WriteLine((DateTime.Now - dt).TotalMilliseconds); // Покажет сколько времени занял расчет.

System.Console.WriteLine();
Console.ReadLine();
dt = DateTime.Now;
for (int n = 10; n < 40; n++)
{
    System.Console.WriteLine($"FibonacciRecursion({n}) = {FibonacciRecursion(n)} fRec = {fRec.ToString("### ### ###"), -15}");
    fRec = 0;
}
System.Console.WriteLine((DateTime.Now - dt).TotalMilliseconds);


