using System.Text;

namespace _11729_hanoi;

class Program
{
    static void Main(string[] args)
    {
        int input = int.Parse(Console.ReadLine());
        var result = hanoi(input, 1, 3, 2, new List<string>());
        StringBuilder sb = new StringBuilder();
        sb.Append(result.Count);
        sb.Append("\n");
        for(int i = 0; i < result.Count; i++)
        {
            if(i == result.Count - 1)
            {
                sb.Append(result[i]);
            }
            else
            {
                sb.Append(result[i]);
                sb.Append("\n");
            }
        }
        Console.WriteLine(sb.ToString());
        Console.Read();
    }

    public static List<string> hanoi(int count, int start, int to, int temp, List<string> strs)
    {
        if (count == 0)
            return null;
        hanoi(count - 1, start, temp, to, strs);
        strs.Add($"{start} {to}");
        hanoi(count - 1, temp, to, start, strs);
        return strs;
    }
}

