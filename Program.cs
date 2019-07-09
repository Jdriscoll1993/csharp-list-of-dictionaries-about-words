using System;
using System.Collections.Generic;

namespace list_dictionaries_about_words
{
  class Program
  {
    static void Main(string[] args)
    {
      // Make a new list
      List<Dictionary<string, string>> dictionaryOfWords = new List<Dictionary<string, string>>();

      // Create dictionary to represent a few words
      Dictionary<string, string> excitedWord = new Dictionary<string, string>();
      // Add each of the 4 bits of data about the word to the Dictionary
      excitedWord.Add("word", "excited");
      excitedWord.Add("definition", "having, showing, or characterized by a heightened state of energy, enthusiasm, eagerness");
      excitedWord.Add("part of speech", "adjective");
      excitedWord.Add("example sentence", "I am excited to learn C#!");

      // Add Dictionary to your `dictionaryOfWords` list
      dictionaryOfWords.Add(excitedWord);


      // create another Dictionary and add that to the list
      Dictionary<string, string> happyWord = new Dictionary<string, string>();
      happyWord.Add("word", "happy");
      happyWord.Add("definition", "a state of being content, bright, and positive.");
      happyWord.Add("part of speech", "adjective");
      happyWord.Add("example sentence", "I am as happy as a clam!");

      dictionaryOfWords.Add(happyWord);

      // Iterate the List of Dictionaries
      foreach (Dictionary<string, string> dictWord in dictionaryOfWords)
      {
        // Iterate the KeyValuePairs of the Dictionary
        foreach (KeyValuePair<string, string> kvp in dictWord)
        {
          string word = kvp.Key;
          string definition = kvp.Value;
          Console.WriteLine($"{word}: {definition}");
        }
      }
    }
  }
}

// LINQ method of foreach from above for future ref.

/* foreach (Dictionary<string, string> dictWord in dictionaryOfWords)
      {
        foreach (var (word, definition) in
        // Iterate the KeyValuePairs of the Dictionary
        from KeyValuePair<string, string> kvp in dictWord
        let word = kvp.Key
        let definition = kvp.Value
        select (word, definition))
        {
          Console.WriteLine($"{word}: {definition}");
        }
      }
*/
