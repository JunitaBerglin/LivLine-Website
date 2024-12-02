namespace LivLineWeb.Services
{
    public class SimplificationService : ISimplificationService
    {
        private readonly Dictionary<string, string> _wordDictionary = new()
        {
    { "complicated", "simple" },
    { "difficult", "hard" },
    { "utilize", "use" },
    { "demonstrate", "show" },
    { "comprehend", "understand" },
    { "assist", "help" },
    { "commence", "start" },
    { "terminate", "end" },
    { "subsequent", "next" },
    { "prior", "before" },
    { "approximately", "about" },
    { "endeavor", "try" },
    { "contemplate", "think" },
    { "obtain", "get" },
    { "communique", "message" },
    { "modify", "change" },
    { "facilitate", "make easier" },
    { "initiate", "begin" },
    { "proceed", "go" },
    { "sufficient", "enough" },
    { "indicate", "show" },
    { "discontinue", "stop" },
    { "advantageous", "helpful" },
    { "magnitude", "size" },
    { "prohibit", "ban" },
    { "ascertain", "find out" },
    { "inquire", "ask" },
    { "inform", "tell" },
    { "observe", "see" },
    { "perceive", "notice" },
    { "authorize", "allow" },
    { "eliminate", "remove" },
    { "commensurate", "equal" },
    { "adequate", "enough" },
    { "disseminate", "spread" },
    { "necessitate", "need" },
    { "endeavored", "tried" },
    { "articulate", "express" },
    { "exhibit", "show" },
    { "evaluate", "judge" },
    { "scrutinize", "examine" },
    { "acquire", "get" },
    { "categorize", "classify" },
    { "implement", "apply" },
    { "collaborate", "work together" }
        };
        public string Simplify(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                throw new ArgumentException("Input cannot be null or whitespace.", nameof(input));
            }

            var words = input.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                var word = words[i].ToLower();
                if (_wordDictionary.ContainsKey(word))
                {
                    words[i] = _wordDictionary[word];
                }
            }
            return string.Join(' ', words);
        }
    }
}