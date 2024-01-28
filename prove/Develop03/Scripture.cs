using System;
using System.Collections.Generic;

public class Scriptures
{
    private string _reference;

    private List<Word> _words;
    
    public Scriptures(string referenceText, string text)
        {
            _reference = new Reference(referenceText);
            _words = new List<Word>();
 
            foreach (var word in text.Split(' '))
        {
            _words.Add(new Word(_words));
        }
    }

    public void HideRandomWords(int numberToHide)
    {

    }

    public string GetDisplayText()
    {
        return "";
    }

    public bool IsCompletelyHidden()
    {
        return true;
    }
}
