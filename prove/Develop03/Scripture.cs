using System;
using System.Collections.Generic;

public class Scriptures
{
    private Reference _reference;
    private List<Word> _words;

    public Scriptures(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();
        
        string[] words = text.Split(' ');

        foreach (var word in words)
        {
            _words.Add(new Word(word));
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        for (int i = 0; i < numberToHide; i++)
        {
           int index = random.Next(0, _words.Count);
           _words[index].Hide();
        }
    }

    public string GetDisplayText()
    {
        string displayText =  " ";
        foreach (Word word in _words)
        {
            displayText += word.GetDisplayText() + " ";

        }
        return displayText;
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
}
