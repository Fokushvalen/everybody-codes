namespace Common;

public static class Formatting
{
    /// <summary>
    /// Prints the start of start label for the given quest number, quest name, and part number of the quest, in a commonly formatted way.
    /// </summary>
    /// <param name="questNumber">The quest number</param>
    /// <param name="questName">The name of the quest</param>
    /// <param name="partNumber">The part number of the quest</param>
    public static void PrintStartQuest(int questNumber, string questName, int partNumber)
    {
        const int lineLength = 42;
        var questLine = AddTrailingSpaces(lineLength, $"Quest {questNumber}: {questName}");
        var partLine = AddTrailingSpaces(lineLength, $"Part {partNumber}");


        Console.BackgroundColor = ConsoleColor.DarkRed;
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("|~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~|");
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine(questLine);
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(partLine);
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("|~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~|");

        Console.BackgroundColor = ConsoleColor.Black;
        Console.ForegroundColor = ConsoleColor.White;
    }

    public static void PrintNote(string note)
    {
        Console.WriteLine();
        Console.WriteLine("Note:");
        Console.WriteLine(note);
        Console.WriteLine();
    }

    /// <summary>
    /// Pads the given text with spaces to the right so that the total length of the returned string is 
    /// equal to the specified totalLength. It also adds two leading spaces for formatting.
    /// </summary>
    /// <param name="totalLength">The total length of the returned string including the leading spaces</param>
    /// <param name="text">The text to be padded</param>
    /// <returns>The formatted string with trailing spaces and leading spaces</returns>
    private static string AddTrailingSpaces(int totalLength, string text)
    {
        return "  " + text.PadRight(totalLength);
    }
}
