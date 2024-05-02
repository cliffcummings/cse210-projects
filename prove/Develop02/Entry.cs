public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;
    public string _eDate;       // Useful for debugging and for assempling the WriteLine strings
    public string _ePrompt;     // Useful for debugging and for assempling the WriteLine strings

    // Display is used to show the contents of this Journal entry
    public void Display()
    {
        _eDate   = "Date: " + _date;
        _ePrompt = " - Prompt: " + _promptText + "\n";
        // Console.WriteLine(_eDate);   // DEBUG - check formatting
        // Console.WriteLine(_ePrompt); // DEBUG - check formatting
        Console.WriteLine($"{_eDate}{_ePrompt}{_entryText}\n");
    }
}