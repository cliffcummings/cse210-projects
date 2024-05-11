public class Assignment
{
    // We were suppose to make these private but making them protected
    // would remove the need for the trival getter methods.
    private string _studentName;
    private string _topic;

    public Assignment (string name, string topic)
    {
        _studentName = name;
        _topic       = topic;
    }

    public string GetSummary()
    {
        return $"The student's name is {_studentName} and the topic is {_topic}";
    }

    public string GetName()
    {
        return _studentName;
    }

    public string GetTopic()
    {
        return _topic;
    }
}