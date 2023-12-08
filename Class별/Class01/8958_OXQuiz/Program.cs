int problemCaseNum = int.Parse(Console.ReadLine());

var problemCases = new List<string>();
for (int i = 0; i < problemCaseNum; i++)
{
    problemCases.Add(Console.ReadLine());
}

foreach (string problemCase in problemCases)
{
    var arr = problemCase.ToCharArray();

    int score = 1;
    int sum = 0;
    foreach (char c in arr)
    {
        if (c == 'O')
        {
            sum += score++;
        }
        else
        {
            score = 1;
        }
    }
    Console.WriteLine(sum);
}