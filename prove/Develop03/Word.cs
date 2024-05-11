using System;
using System.IO;

public class Word
{
    private string _text;
    private bool _isHidden;

    // Word consturctor
    public Word (string text)
    {
        _text = text;
        Show();
    }

    public string GetDisplayText()
    {
        if (_isHidden == false)
        {
            return _text;  // returns each unhidden word
        }
        else
        {
            // string _blanks = _text + ""; // DEBUG to test text with equivalent underscores
            string blanks = "";
            // Store underscore "_" for each character in the Word text
            foreach (char c in _text)
            {
                blanks = blanks + "_";
            }
            return blanks;
        }
    }

    public bool IsHidden()
    {
        return _isHidden;
    }

    public void Hide()
    {
        _isHidden = true;
    }

    private void Show()
    {
        _isHidden = false;
    }
}