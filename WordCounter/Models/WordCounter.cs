namespace WordMaster
{
  public class WordCounter
  {
    public string UserInput = "cat";

    public bool MatchesWord(string word)
    {
      return word == UserInput;
    }
  }
}