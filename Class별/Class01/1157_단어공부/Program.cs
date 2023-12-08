using System.Linq;

string word = Console.ReadLine().ToUpper();
var letters = word.ToCharArray();
var uniqueAlpabet = letters.Distinct().ToArray();

Dictionary<char, int> letterCounts = new Dictionary<char, int>();
foreach (var alphabet in uniqueAlpabet)
{
    int cnt = letters.Where(c => c == alphabet).Count();
    letterCounts.Add(alphabet, cnt);
}

int letterCountMax = letterCounts.Values.Max();

if (letterCounts.Values.Where(x => x == letterCountMax).Count() != 1)
{
    Console.Write("?");
}
else
{
    Console.Write(letterCounts.OrderByDescending(kv => kv.Value).First().Key);
}