using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;


public class Word()
{    

    public string HideRandomWords(string scripture_text, string user_action)
    {
        if (user_action == "")
        {
            string[] words = scripture_text.Split(' ');
            Random rng = new Random();
            
            int hidden_this_round = 0;
            int words_to_hide = 4;
            int unhidden_words = 0;
            foreach (string word in words)
            {
                if (word != "____")
                {
                    unhidden_words++;
                }
            }

            while (hidden_this_round < words_to_hide && unhidden_words > 0)
            {
                int random_word = rng.Next(words.Length);
                if (words[random_word] != "____")
                {
                    words[random_word] = "____";
                    hidden_this_round++;
                    unhidden_words--;
                }
            }
            scripture_text = string.Join(" ", words);
        } 
        return scripture_text;
    }

    public bool AllWordsHidden(string scripture_text)
    {
        string[] words = scripture_text.Split(' ');
        foreach (string word in words)
        {
            if (word != "____")
            {
                return false;
            }
        }
        Console.WriteLine("------------------------------------" + '\n');
        Console.WriteLine("Thank you for using scripture memorizer!");
        return true;
    }
}
