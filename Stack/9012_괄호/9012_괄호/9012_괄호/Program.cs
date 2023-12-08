//케이스 개수 입력
int n = int.Parse(Console.ReadLine());

//케이스들 입력
List<string> testCases = new List<string>();
for (int i = 0; i < n; i++)
{
    testCases.Add(Console.ReadLine());
}

//결과 저장용 변수
string result = string.Empty;

//케이스 돌리기
foreach (string testCase in testCases)
{
    //스택 만들기
    Stack<string> stack = new Stack<string>();
    var arr = testCase.ToCharArray();
    bool isVPS = true;

    //C#에선 빈상태로 Pop하면 예외가 뜨는것을 이용하여
    //마지막 문자열까지 Pop하는 과정에서 예외가 뜨면 VPS가 아닌 것
    try
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == '(')
            {
                stack.Push("a");
            }
            else
            {
                stack.Pop();
            }
        }

        //마지막까지 멀쩡하게 Push, Pop 하고나서도 Peek가 가능하면 VPS가 아님
        string finalStr;
        if(stack.TryPeek(out finalStr))
        {
            isVPS = false;
        }
    }
    catch (Exception)
    {
        isVPS = false;
    }
    finally
    {
        if (isVPS)
        {
            result += "YES\n";
        }
        else
        {
            result += "NO\n";
        }
    }
}

Console.Write(result);