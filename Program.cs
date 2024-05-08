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

