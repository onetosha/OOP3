using OOP3;
using System.Diagnostics;

Container <int> container = new Container<int>();
int n = 10000; //количество иттераций
Random random = new Random();
int t1, t2;
Stopwatch stopwatch = new Stopwatch();


Console.WriteLine("Заполнение контейнера:\n");
for(int i = 0; i < n; i++)
{
    container.Add(random.Next(0, 100));
}


Console.WriteLine("\nОперации над контейнером:\n");
stopwatch.Start();
for (int i = 0; i < n; i++)
{
    switch (random.Next(0, 7))
    {
        case 0:
            container.Remove(random.Next(0, 100));
            break;
        case 1:
            container.Insert(random.Next(0, 100), random.Next(0, container.Count));
            break;
        case 2:
            container.RemoveByIndex(random.Next(0, container.Count - 1));
            break;
        case 3:
            container.Add(random.Next(0, 100));
            break;
        case 4:
            container.AddFirst(random.Next(0, 100));
            break;
        case 5:
            container.Contains(random.Next(0, 100));
            break;
        case 6:
            container.GetByIndex(random.Next(0, container.Count - 1));
            break;
        case 7:
            container.GetIndex(random.Next(0, 100));
            break;
    }
}
stopwatch.Stop();
Console.WriteLine("\nСодержимое контейнера:\n");
for(int i = 0; i < container.Count; i++)
{
    Console.WriteLine($"{i}: {container.GetByIndex(i)}");
}

Console.WriteLine($"Время выполнения операций: {stopwatch.Elapsed.TotalMilliseconds} миллисекунд");
