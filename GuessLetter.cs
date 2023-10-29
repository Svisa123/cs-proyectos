using System.Security.Cryptography.X509Certificates;

namespace ChatApp
{

  class GuessLetter
  {

    public static string GuessLetterHandler(char letter, string hiddenWord)
    {
      string newGuessWord = "";
      bool badTry = false;
      for (int i = 0; i < hiddenWord.Length; i++)
      {

        if (letter == hiddenWord[i])
        {
          newGuessWord += letter;
          badTry = true;
        }
        else
        {
          newGuessWord += '_';
        }


      }

      return newGuessWord;
    }



  }

}

