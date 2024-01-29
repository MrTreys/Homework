void WriteAllNumbers(int m, int n){
    if(m > n){
        Console.WriteLine("m не может быть больше n!");
    }
    else
    Console.Write($"{m} ");
    m++;
    if(m < n){
        WriteAllNumbers(m, n);
    }
    else
    Console.WriteLine();
}
Console.WriteLine("Введите m: ");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите n: ");
int n = int.Parse(Console.ReadLine()!);
WriteAllNumbers(m, n);