namespace _1932_정수삼각형;

class Program
{
    static void Main(string[] args)
    {
        var lineCnt = int.Parse(Console.ReadLine());
        int[][] stair = new int[lineCnt][];
        for(int i = 0; i < lineCnt; i++)
        {
            stair[i] = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
        }
        int maxDist = 0;
        
        for(int i = 0; i < stair.Length - 1; i++)
        {
            
            var currentFloor = stair[i];
            var nextFloor = stair[i + 1];
            MaxRoute(currentFloor, nextFloor);
            if (i == stair.Length - 2)
            {
                maxDist = nextFloor.Max();
            }
        }

        //길이가 1인 계단은 별도로 처리
        if (stair.Length == 1)
            maxDist = stair[0][0];
        Console.WriteLine(maxDist);
    }

    public static void MaxRoute(int[] currentFloor, int[] nextFloor)
    {
        for(int i = 0; i < currentFloor.Length; i++)
        {
            if(i == 0)
            {
                //좌측 끝은 무조건 좌측 끝으로만 이동 가능
                nextFloor[i] = currentFloor[i] + nextFloor[i];
            }
            else
            {
                //현재층의 나머지 값들은 2개의 경로를 가지므로, 둘 중 큰 값을 다음층의 같은 열에 넣어주기
                nextFloor[i] = Math.Max(currentFloor[i-1] + nextFloor[i], currentFloor[i] + nextFloor[i]);
            }
        }
        //다음 층의 맨 우측값도 좌측처럼 우측 값으로만 이동 가능
        nextFloor[currentFloor.Length] = currentFloor.Last() + nextFloor.Last();
    }
}

