//Question : https://www.acmicpc.net/problem/1004
//풀이 : 몆가지 그려보면 답은 시작점을 품는 원의 개수 + 끝점을 품는 원의 개수가 된다.

int t = int.Parse(Console.ReadLine());
string result = string.Empty;
for(int i = 0; i < t; i++)
{
    int cnt = 0;
    string[] fromTo = Console.ReadLine().Split().ToArray();
    int circleNum = int.Parse(Console.ReadLine());
    for(int k = 0; k < circleNum; k++)
    {
        string[] circleArg = Console.ReadLine().Split();
        int x_c = int.Parse(circleArg[0]);
        int y_c = int.Parse(circleArg[1]);
        int r = int.Parse(circleArg[2]);
        int x_p1 = int.Parse(fromTo[0]);
        int y_p1 = int.Parse(fromTo[1]);
        int x_p2 = int.Parse(fromTo[2]);
        int y_p2 = int.Parse(fromTo[3]);

        bool testStart = IsContainPoint(x_p1, y_p1, x_c, y_c, r);
        bool testEnd = IsContainPoint(x_p2, y_p2, x_c, y_c, r);

        if ((testStart && testEnd) || (!testStart && !testEnd))
        {

        }
        else
        {
            cnt++;
        }
    }
    result += cnt.ToString() + "\n";
}
Console.WriteLine(result);

//점포함 여부 메소드
static bool IsContainPoint(int x_p, int y_p, int x_c, int y_c, int r)
{
    double ptToCenPow = Math.Pow(x_p - x_c, 2) + Math.Pow(y_p - y_c, 2);

    if (Math.Pow(r, 2) < ptToCenPow)
        return true;
    else
        return false;
}