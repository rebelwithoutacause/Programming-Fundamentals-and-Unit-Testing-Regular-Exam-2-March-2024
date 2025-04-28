string text = Console.ReadLine();

int upperCaseCount  = 0;
int lowerCaseCount = 0;
int spaceCount = 0;

foreach(char ch in text) 
{
    if (char.IsUpper(ch)) 
    {  
        upperCaseCount++; 
    }
    else if (char.IsLower(ch)) 
    { 
        lowerCaseCount++; 
    }
    else if (char.IsWhiteSpace(ch)) 
    {
    spaceCount++;
    }
}
Console.WriteLine(upperCaseCount);
Console.WriteLine(lowerCaseCount);
Console.WriteLine(spaceCount);