
Using System ;
Using System.Collections.Generic ;

Public class WordFinder
{
    Public static List<string> FindWords(List<string> words, string scrambledWord)
    {
        Var foundWords = new List<string>() ;
        Foreach (var word in words)
        {
            If (IsAnagram(word, scrambledWord))
            {
                foundWords.Add(word) ;
            }
        }
        Return foundWords ;
    }

    Private static bool IsAnagram(string word1, string word2)
    {
        If (word1.Length != word2.Length)
        {
            Return false ;
        }

        Var charCount = new Dictionary<char, int>() ;
        Foreach (var c in word1)
        {
            If ( !charCount.ContainsKey©)
            {
                charCount[c] = 0 ;
            }
            charCount[c]++ ;
        }

        Foreach (var c in word2)
        {
            If ( !charCount.ContainsKey© || charCount[c] == 0)
            {
                Return false ;
            }
            charCount[c]-- ;
        }

        Return true ;
    }

    Public static void Main(string[] args)
    {
        Var words = new List<string> { « omre », « teac », « tiodi », « xse » } ;
        Var scrambledWord = « teac » ;
        Var foundWords = FindWords(words, scrambledWord) ;

        If (foundWords.Count > 0)
        {
            Console.WriteLine(« Found words : ») ;
            Foreach (var word in foundWords)
            {
                Console.WriteLine(word) ;
            }
        }
        Else
        {
            Console.WriteLine(« No words found. ») ;
        }
    }
}
