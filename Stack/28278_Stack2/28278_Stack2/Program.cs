//명령 입력부
using System.Text;

string cmdCount = Console.ReadLine();

int cnt = int.Parse(cmdCount);
//명령 실행
MyStack stack = new MyStack();
StringBuilder sb = new StringBuilder();
for (int i = 0; i < cnt; i++)
{
    string[] cmd = Console.ReadLine().Split();
    //명령 분기
    
    if (cmd[0] == "1")
    {
        stack.Push(int.Parse(cmd[1]));
    }
    else
    {
        switch (cmd[0])
        {
            case "2":
                sb.Append(stack.Pop() + "\n");
                break;
            case "3":
                sb.Append(stack.GetCount() + "\n");
                break;
            case "4":
                sb.Append(stack.IsEmpty() + "\n");
                break;
            case "5":
                sb.Append(stack.GetTop() + "\n");
                break;
        }
    }
}
Console.Write(sb);

//Stack 구현
public class Item
{
    public int Value { get; set; }
    public Item Next { get; set; }
    public Item(int n)
    {
        Value = n;
    }
}

public class MyStack
{
    public MyStack()
    {
        this.Top = new Item(0);
        this.Count = 0;
    }

    public Item Top { get; set; }
    public int Count { get; set; }
    public void Push(int n)
    {
        if(this.Count == 0)
        {
            Item item = new Item(n);
            item.Next = this.Top;
            this.Top = item;
            this.Count++;
        }
        else
        {
            Item item = new Item(n);
            item.Next = this.Top;
            this.Top = item;
            this.Count++;
        }
    }

    public int Pop()
    {
        if(this.Count != 0)
        {
            int a = this.Top.Value;
            this.Top = this.Top.Next;
            this.Count--;
            return a;
        }
        else
        {
            return -1;
        }
    }

    public int GetTop()
    {
        if (this.Count == 0)
            return -1;
        else
            return this.Top.Value;
    }

    public int GetCount()
    {
        return this.Count;
    }

    public int IsEmpty()
    {
        if (this.Count == 0)
            return 1;
        else
            return 0;
    }
}

