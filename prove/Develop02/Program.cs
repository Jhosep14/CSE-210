using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to your Personal Journal");
        string choice = "";
        string response = "";
        string prompt = "";
        Entry newEntry = new Entry();
        string date_to_remove = "";
        do 
        {
            Console.WriteLine("------------------------------------------- ");
            Console.WriteLine("Please Select one of the following options:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display entries");
            Console.WriteLine("3. Save entries");
            Console.WriteLine("4. Remove entry");
            Console.WriteLine("5. Load old entries");
            Console.WriteLine("6. Exit");
            Console.Write("What would you like to do?: ");
            choice = Console.ReadLine();
            if (choice == "1")
            {
                Console.WriteLine("-------------------------------------------");
                Console.WriteLine("Answer the following prompt:");
                promptgenerator generator = new promptgenerator();
                prompt = generator.DisplayRandomPrompt();
                response = Console.ReadLine();
                newEntry.AddEntry(prompt, response);

            }
            else if (choice == "2")
            {
                Console.WriteLine("-------------------------------------------");
                Console.WriteLine("Entries:");
                newEntry.DisplayEntry(prompt, response);
            }
            else if (choice == "3")
            {
                Console.WriteLine("-------------------------------------------");
                Console.WriteLine("Saving Entries...");

                newEntry.SaveEntry(prompt, response);
                Console.WriteLine("Entry Saved!");
            }
            // I added the remove entry function 
            // This allows the user to remove an entry based on the date they provide in the prompt 
            // and then select the entry they want to remove. 
            else if (choice == "4")
            {
                Console.WriteLine("-------------------------------------------");
                Console.Write("Insert Journal Entry Date to Remove (dd/MM/yyyy): ");
                date_to_remove = Console.ReadLine();
                
                Console.WriteLine("-------------------------------------------");
                
                Journal journal = new Journal();
                journal.RemoveJournalEntry(date_to_remove); 
                
            }
            else if (choice == "5")
            {
                Console.WriteLine("Load Entries");
                Journal journal = new Journal();
                journal.DisplayJournal();
            }
            else if (choice == "6")
            {
                Console.WriteLine("-------------------------------------------");
                Console.WriteLine("Thanks! See you next time!");
            }
            else
            {
                Console.WriteLine("-------------------------------------------");
                Console.WriteLine("Invalid choice");
            }

        } while (choice != "6");
        Console.WriteLine("-------------------------------------------");
        
    }
}