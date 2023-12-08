int input = int.Parse(Console.ReadLine());
hanoi(input, 1, 3, 2);

public void hanoi(int count, int from, int to, int temp) 
{
    if(count == 0) return;
    hanoi(count - 1, from, temp, to);
    console.log(from, to);
    hanoi(count - 1, temp, to, from);
}