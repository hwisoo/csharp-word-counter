namespace WordMaster
{
  public class WordCounter
  {
    public string UserInputWord = "cat";
    public string UserInputSentence = "The cat house";

    public bool CreateWordArray(string sentence)
    {
      string[] Arr = UserInputSentence.Split(" ");
      string[] Arr2 = sentence.Split(" ");
      return Arr.Length == Arr2.Length;
    }

    public bool MatchesWord(string word)
    {
      return word == UserInput;
    }
  }
}