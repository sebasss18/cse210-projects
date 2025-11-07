//For the creativity requirement, I let the user choose the type of file to save their entries CSV, TXT, etc... I also included the exact hour each entry is written
//and added some basic error handling for the file loading process.

using System.Net.Quic;
using System.Security.Cryptography.X509Certificates;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry()
    {
        string opt = "";
        while (opt != "5")
        {
            Console.WriteLine("\nMenu");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            opt = Console.ReadLine();

            if (opt == "1")
            {
                var _randomPrompt = new PromptGenerator();
                string prompt = _randomPrompt.GetRandomPrompt();
                Console.WriteLine(prompt);
                string userEntry = Console.ReadLine();
                Entry newEntry = new Entry();
                newEntry._promptText = prompt;
                newEntry._entryText = userEntry;
                string dateOfEntry = DateTime.Now.ToString("yyy-MM-dd");
                string hourOfEntry = DateTime.Now.ToString("HH:mm tt");
                newEntry._date = $"{dateOfEntry} {hourOfEntry}";
                _entries.Add(newEntry);
            }
            else if (opt == "2")
            {
                DisplayAll();
            }
            else if (opt == "3")
            {
                Console.Write("What is the filename? ");
                string filename = Console.ReadLine();
                LoadFromFile(filename);
            }
            else if (opt == "4")
            {
                Console.Write("What is the filename? ");
                string filename = Console.ReadLine();
                SaveToFile(filename);
            }
            else
            {
                Console.WriteLine("Thats not an option.\n");
            }
        }
    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            Console.WriteLine($"Date: {entry._date} - Prompt: {entry._promptText}");
            Console.WriteLine(entry._entryText);
            Console.WriteLine();
        }
    }

    public void SaveToFile(string file)
    {
        using (StreamWriter outputFile = new StreamWriter(file))
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date},{entry._promptText},{entry._entryText}");
            }
        Console.WriteLine("File saved succesfully!");
    }
    
    public void LoadFromFile(string file)
    {
        try
        {
            Console.WriteLine("Reading list form file...");
            string[] lines = System.IO.File.ReadAllLines(file);
            foreach (string line in lines)
            {
                string[] parts = line.Split(',');
                Entry entry = new Entry();
                entry._date = parts[0];
                entry._promptText = parts[1];
                entry._entryText = parts[2];
                _entries.Add(entry);
            }
            Console.WriteLine("File Loaded succesfully!");
        }
        catch (Exception)
        {
            Console.WriteLine("File not found.");
        }
    }
}