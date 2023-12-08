using System.Text;

namespace _2447_재귀별찍기;

class Program
{
    static void Main(string[] args)
    {
        int input = int.Parse(Console.ReadLine());
        var lines = GetStarLines(input);
        StringBuilder sb = new StringBuilder();
        for(int i = 0; i<lines.Count; i++)
        {
            if(i < lines.Count - 1)
            {
                sb.Append(lines[i]);
                sb.Append("\n");
            }
            else
            {
                sb.Append(lines[i]);
            }
        }
        Console.WriteLine(sb.ToString());
    }

    public static List<string> GetStarLines(int n)
    {
        var result = new List<string>();
        var space  = GetCenterSpace(n / 3);
        if (n == 3)
        {
            return new List<string>()
            {
                "***",
                "* *",
                "***"
            };
        }
        var former = GetStarLines(n / 3);

        //처음 n/3줄
        for(int i = 0; i < n / 3; i++)
        {
            var line = former[i] + former[i] + former[i];
            result.Add(line);
        }

        //중간 n/32
        for (int i = 0; i < n / 3; i++)
        {
            var line = former[i] + space + former[i];
            result.Add(line);
        }

        //마지막 n/3줄
        for (int i = 0; i < n / 3; i++)
        {
            var line = former[i] + former[i] + former[i];
            result.Add(line);
        }

        return result;
    }

    public static string GetCenterSpace(int n)
    {
        string result = string.Empty;
        for(int i = 0; i < n; i++)
        {
            result += " ";
        }
        return result;
    }
}