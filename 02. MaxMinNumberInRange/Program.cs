int[] numbers = Console.ReadLine().
                Split(' ').
                Select(int.Parse).
                ToArray();

int startIndex = int.Parse(Console.ReadLine());
int endIndex = int.Parse(Console.ReadLine());

int min  = numbers.Min();
int max = numbers.Max();

for (int i = startIndex; i < endIndex; i++) 
{
if (numbers[i] < min) 
    {  
        min = numbers[i]; 
    }
if (numbers[i] > max) 
    {
        max = numbers[i]; 
    }
}
int sum = min + max;
Console.WriteLine(sum);