using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

//-------------------------------------------------------------------
// STRETCH CHALLENGE - Added to the Scripture class:
// Check the random word indexed by "number".
// If it is already hidden, loop until a random number does not 
// correspond to a hidden word. This guarantees that each scripture
// will hide 3 additional random words each time Enter is pressed. 
// This was easily accomplished using the 4-line while loop below.
//-------------------------------------------------------------------
public class Scripture
{
    // Reference _reference = new Reference("book", 1, 1);
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    // Scripture constructor
    public Scripture (string refInput, string text)
    {
        string[] refText = refInput.Split(' ',':', '-');  // Split on these characters: space :  -
        string _book = refText[0];
        int _chapter = int.Parse(refText[1]);
        int _verse = int.Parse(refText[2]);
        int _endVerse = int.Parse(refText[3]);
        // Console.WriteLine(_book);        // For Debugging
        // Console.WriteLine(_chapter);
        // Console.WriteLine(_verse);
        // Console.WriteLine(_endVerse);

        if (refText[3] != null)
        {
            _reference = new Reference(_book, _chapter, _verse, _endVerse);
        }
        else
        {
            _reference = new Reference(_book, _chapter, _verse);
        }
        
        string[] fullText = text.Split();

        foreach (string item in fullText)
        {
            Word oneWord = new Word(item);
            _words.Add(oneWord);
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        int number;
        int max = _words.Count();

        for (int i  = 0; i < numberToHide; i++)
        {
            Random randGen = new Random();

            number = randGen.Next(0, max);
            //-------------------------------------------------------------------
            // STRETCH CHALLENGE - Added to the Scripture class:
            // Check the random word indexed by "number".
            // If it is already hidden, loop until a random number does not 
            // correspond to a hidden word. This guarantees that each scripture
            // will hide 3 additional random words each time Enter is pressed. 
            // This was easily accomplished using the 4-line while loop below.
            //-------------------------------------------------------------------
            while (_words[number].IsHidden() == true)
            {
                number = randGen.Next(0, max);
            }
            _words[number].Hide();
        }
    }

    public string GetDisplayText()
    {
        string text = "";
        text = _reference.GetDisplayText();

        foreach (Word item in _words)
        {
            text = text + " " + item.GetDisplayText();
        }
        return text;
    }

    public bool IsCompletelyHidden()
    {
        bool _complete = true;

        foreach (Word item in _words)
        {
            if (item.IsHidden() == false)
            {
                // Console.WriteLine("Not completely hidden yet"); // DEBUG message
                return false;
            }
        }
        return _complete;
    }
}