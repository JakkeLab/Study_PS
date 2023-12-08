string input = Console.ReadLine();

//ASCII 배열을 이용하여 알파벳 리스트 생성
char start = 'a';
List<char> chars = new List<char>();
for(int i = 0; i < 26; i++)
{
    chars.Add((char)((int)start+i));
}

string result = string.Empty;
for(int i = 0; i < chars.Count; i++)
{
    if(i < chars.Count - 1)
    {
        result += (input.IndexOf(chars[i]).ToString() + " ");
    }
    else
    {
        result += input.IndexOf(chars[i]).ToString();
    }
    
}
Console.WriteLine(result);