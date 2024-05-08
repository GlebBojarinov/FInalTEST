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

