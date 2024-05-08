int InputArraySize()
{
    Console.Write("Input the number of strings array: ");
    return Convert.ToInt32(Console.ReadLine());
}

string[] InputConsoleStrings(int InputArray)
{
    string[] strings = new string[InputArray];
    for (int i = 0; i < InputArray; i++)
    {
        Console.Write($"Input string {i + 1}: ");
        strings[i] = Console.ReadLine();
    }
    return strings;
}

string[] CheckingStringsSize(string[] inputStrings)
{
    int suitedCount = CountSuitedStrings(inputStrings);
    string[] suitedStrings = new string[suitedCount];
    int index = 0;
    foreach (string str in inputStrings)
    {
        if (str.Length <= 3)
        {
            suitedStrings[index] = str;
            index++;
        }
    }
    return suitedStrings;
}

int CountSuitedStrings(string[] strings)
{
    int count = 0;
    foreach (string str in strings)
    {
        if (str.Length <= 3)
            count++;
    }
    return count;
}

void PrintArray(string[] inputStrings, string[] suitedStrings)
{
    Console.WriteLine("Original strings arrays:");
    foreach (string str in inputStrings)
    {
        Console.WriteLine(str);
    }

    Console.WriteLine("New count of strings array (strings array length less than 3):");
    foreach (string str in suitedStrings)
    {
        Console.WriteLine(str);
    }
}

