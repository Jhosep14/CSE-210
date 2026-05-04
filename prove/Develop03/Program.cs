using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to scripture memorizer!");
        Console.WriteLine("------------------------------------");
        int user_choice;
        string user_action="";
        int scripture_choice;
        Reference reference = new Reference();
        Word word = new Word();
        string scripture_text;
        do
        {
            Console.Write("Type 1 to display available scriptures or 2 to generate randomly a scripture: ");
            user_choice = int.Parse(Console.ReadLine());

            if(user_choice == 1)
            {
                reference.DisplayReferences();
                Console.Write("Please choose a scripture. Type the number associated with the scripture: ");
                scripture_choice = int.Parse(Console.ReadLine());
                scripture_text = reference.DisplayReferenceText(scripture_choice).Text;
                while(true)
                {
                    Console.Clear();
                    Console.WriteLine('\n');
                    Console.WriteLine(scripture_text);
                    Console.Write("Press Tab to hide words, or type 'quit' to exit: ");
                    user_action = Console.ReadLine();
                    if(user_action == "quit")
                    {
                        break;
                    }
                    if(word.AllWordsHidden(scripture_text))
                    {
                        user_action = "quit";
                        break;
                    }
                    scripture_text = word.HideRandomWords(scripture_text, user_action);
                }
            }
            else if (user_choice == 2)
            {
                scripture_text = reference.GetRandomScripture().Text;
                while (true)
                {
                    Console.Clear();
                    Console.WriteLine('\n');
                    Console.WriteLine(scripture_text);
                    Console.Write("Press Tab to hide words, or type 'quit' to exit: ");
                    user_action = Console.ReadLine();
                    if(user_action == "quit")
                    {
                        break;
                    }
                    if(word.AllWordsHidden(scripture_text))
                    { 
                        break;
                    }
                    scripture_text = word.HideRandomWords(scripture_text, user_action);
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please try again.");
            }

        }while(user_action != "quit");
    }
}