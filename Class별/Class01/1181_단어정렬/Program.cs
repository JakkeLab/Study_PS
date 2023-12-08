int a = int.Parse(Console.ReadLine());

var words = new List<string>();
for(int i = 0; i < a; i++)
{
    words.Add(Console.ReadLine());
}
var orderedWords = words.Distinct().OrderBy(w => w.Length).ThenBy(w => w).ToList();
orderedWords.ForEach(w => Console.WriteLine(w));

Console.Read();