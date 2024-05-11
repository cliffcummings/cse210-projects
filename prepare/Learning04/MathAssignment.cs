public class MathAssignment : Assignment
{
    private string _textbookSection;
    private string _problems;

    public MathAssignment (string name, string topic, string textbookSection, string problems)
        : base (name, topic)
    {
        _textbookSection = textbookSection;
        _problems        = problems;
    }
    public string GetHomeworkList()
    {
        string localName =  GetName();
        string localTopic = GetTopic();
        return $"{localName} - {localTopic}\nSection {_textbookSection} Problems {_problems}";
    }
}