namespace LivLineWeb.Services;
public class SimplificationService : ISimplificationService
{
    private readonly Dictionary<string, string> _wordDictionary = new Dictionary<string, string>
    {
        { "complicated", "simple" },
        { "difficult", "hard" },
        { "utilize", "use" }
    };

    public string Simplify(string input)
    {
        var words = input.Split(' ');
        for (int i = 0; i < words.Length; i++)
        {
            if (_wordDictionary.ContainsKey(words[i].ToLower()))
            {
                words[i] = _wordDictionary[words[i].ToLower()];
            }
        }
        return string.Join(" ", words);
    }
}
