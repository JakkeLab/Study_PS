using System.Collections.Generic;

var inputs = new List<int>();
for (int i = 0; i < 9; i++)
{
    inputs.Add(int.Parse(Console.ReadLine()));
}

int max = inputs.Max();
Console.WriteLine(max);
Console.WriteLine(inputs.IndexOf(max) + 1);
Console.Read();