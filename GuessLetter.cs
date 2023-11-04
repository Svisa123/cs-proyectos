using System.Security.Cryptography.X509Certificates;

namespace ChatApp
{

  class GuessLetter
  {

    public static string GuessLetterHandler(List<char> letters, string hiddenWord)
    {

      string newGuessWord = "";
      bool badTry = false;
      for (int i = 0; i < hiddenWord.Length; i++)
      {

        for (int j = 0; j < letters.Count(); j++)
        {
          if (letters[j] == hiddenWord[i])
          {
            newGuessWord += letters[j];
            badTry = true;
          }
          else
          {
            badTry = false;
          }

        }

        if (!badTry) newGuessWord += '_';

      }

      return newGuessWord;
    }



  }

}

