int a = int.Parse(Console.ReadLine());
for (int i = 0; i < a; i++)
{
    string line = string.Empty;
    for (int p = 0; p < i+1; p++)
    {
        line += "*";
    }
    Console.WriteLine(line);
}
Console.Read();
