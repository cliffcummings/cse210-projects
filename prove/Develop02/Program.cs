// EXCEEDING REQUIREMENTS
// Sometimes you may not want to repond to the current random prompt
// and you would like to ask for a different randome prompt.
// This modified code askes the user to enter <space><Enter> to get
// a new random prompt. There is no guarantee that the new prompt
// will be different but it is simple to keep hitting <space><Enter>
// to generate a new random prompt.
// See lines 74 - 91.

using System;
using System.Security.Cryptography.X509Certificates;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Journal theJournal = new Journal();
        PromptGenerator pg = new PromptGenerator();

        string response;
        int value;
        string file;

        pg.SetPrompts();
        // pg.ShowPrompts();    // Uncomment for debugging

        do
        {
            MainMenu(); // calls a method to display the main menu - located at the bottom of this file.
            value = int.Parse(Console.ReadLine());  // Read input and convert it to an int type.

            // switch statement is more concise and easier to read than if / else-if / else-if ...
            // Each case item calls a simple method at the bottom of this file. This makes the
            // switch statement more concise and easier to read. 
            switch (value)
            {
                case 1:
                    WriteEntry();
                    break;
                case 2:
                    DisplayEntries();
                    break;
                case 3:
                    LoadFile();
                    break;
                case 4:
                    SaveFile();
                    break;
                default:
                    break;
            }
        } while (value != 5);

        void MainMenu()
        {      
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
        }

        void WriteEntry()
        {
            DateTime eDate;
            string dateText;
            string randPrompt;

            Entry anEntry = new Entry();        // Create new Entry object

            // EXCEEDING REQUIREMENTS
            // Sometimes you may not want to repond to the current random prompt
            // and you would like to ask for a different randome prompt.
            // This modified code askes the user to enter <space><Enter> to get
            // a new random prompt. There is no guarantee that the new prompt
            // will be different but it is simple to keep hitting <space><Enter>
            // to generate a new random prompt.
            response = " ";
            while (response == " ")
            {         
                randPrompt = pg.GetRandomPrompt();
                Console.Write($"{randPrompt}\n> ");
                anEntry._promptText = randPrompt;   // Save the random prompt

                Console.WriteLine("For a new prompt, enter <space><Enter>");
                
                response = Console.ReadLine();
            }

            anEntry._entryText = response;      // Save user's response

            eDate = DateTime.Now;
            dateText = eDate.ToShortDateString();
            anEntry._date = dateText;           // Save entry date

            theJournal.AddEntry(anEntry);       // Store the entry in the Journal
        }

        void DisplayEntries()
        {
            theJournal.DisplayAll();
        }

        void SaveFile()
        {
            Console.WriteLine("What is the filename?");
            file = Console.ReadLine();

            theJournal.SaveToFile(file);
        }

        void LoadFile()
        {
            Console.WriteLine("What is the filename?");
            file = Console.ReadLine();

            theJournal.LoadFromFile(file);
        }
    }

}