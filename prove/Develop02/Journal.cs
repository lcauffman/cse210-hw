using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    public List<Entry> _entries;
    public PromptGenerator promptGenerator;
    
    
    
    public Journal()
    {
        _entries = new List<Entry>();
        promptGenerator = new PromptGenerator();
    }
    
    
    //ADD ENTRY HERE !!!!
    public void AddEntry(Entry newEntry)
    {
        string promptText = PromptGenerator.GetRandomPrompt();
        Console.WriteLine($"Prompt: {promptText}");

        Console.WriteLine("Enter your thoughts:");
        Console.Write(">  ");
        string response = Console.ReadLine();

        newEntry._entryText = response;
        newEntry._date = DateTime.Now.ToShortDateString();
        newEntry._promptText = promptText;

        _entries.Add(newEntry);

        Console.WriteLine($"Entry added {DateTime.Now.ToShortDateString()}");
    }
    
    
    //DISPLAY HERE !
    public void DisplayAll()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("No entries to display.");
            return;
        }

        Console.WriteLine("Past Journal Entries:");

        foreach (Entry newEntry in _entries)
        {
            newEntry.Display();
        }
}
    
    //SAVE FILE HERE !!!!!
    public void SaveToFile()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("No entries to save.");
            return;
        }

        Console.WriteLine("What do you want to name this file? (add '.txt' at the end)");
        string fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(fileName, true))
        {
            foreach (Entry newEntry in _entries)
            {
                outputFile.WriteLine($"{newEntry._date} -- Prompt: {newEntry._promptText}");
                outputFile.WriteLine($"Entry: {newEntry._entryText}");
                outputFile.WriteLine();
            }
        }

    Console.WriteLine("Entries saved successfully.");
    }
    
    //LOAD FROM FILE !!!!!
    public void LoadFromFile(string file)
    {
        string[] lines = System.IO.File.ReadAllLines(file);
        foreach (string line in lines)
        {
            string[] parts = line.Split(',');
            if (parts.Length >= 3)
            {
                string date = parts[0].Trim();
                string promptText = parts[1].Trim();
                string entryText = parts[2].Trim();

                Entry newEntry = new Entry
                {
                    _date = date,
                    _promptText = promptText,
                    _entryText = entryText
                };

                _entries.Add(newEntry);
            }
        }
    }
}
