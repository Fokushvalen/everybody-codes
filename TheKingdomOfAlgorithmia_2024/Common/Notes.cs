namespace Common;

public class Notes
{
    /// <summary>
    /// Reads a quest note from a .txt file given the quest number and part number.
    /// </summary>
    /// <param name="questNumber">The quest number</param>
    /// <param name="partNumber">The part number of the quest</param>
    /// <returns>The content of the quest note</returns>
    public static string ReadNoteFromFile(int questNumber, int partNumber)
    {
        string fileName = $"Quest{questNumber}_Part{partNumber}.txt";
        string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Notes", fileName);
        return File.ReadAllText(path);
    }
}
