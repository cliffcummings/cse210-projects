using System;
using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (Entry e in _entries)
        {
            e.Display();
        }
    }

    public void SaveToFile(string file)
    {
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry e in _entries)
            {
               outputFile.WriteLine($"{e._date}::{e._promptText}::{e._entryText}");
            }
        }
    }

    public void LoadFromFile(string file)
    {
        _entries = new List<Entry>();   // Re-initialize the _entries List
        string [] lines = System.IO.File.ReadAllLines(file);

        foreach (string line in lines)
        {
            // Console.WriteLine(line);         // For debugging
            string[] parts = line.Split("::");  // slit using "::" as split-separator

            Entry e = new Entry();
            e._date       = parts[0];
            e._promptText = parts[1];
            e._entryText  = parts[2];

            _entries.Add(e);
        }
    }
}
