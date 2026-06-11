namespace HackaThon__1_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string phrase = "To be or not to be";
            var lowerphrase = phrase.ToLower();
            string[] words = lowerphrase.Split(' ');

            Dictionary<string, int> wordCount = new Dictionary<string, int>();

            foreach (var word in words)
            {
                if (wordCount.ContainsKey(word))
                {
                    wordCount[word] += 1;
                }
                else
                {
                    wordCount.Add(word, 1);
                }
                    
            }
            foreach (var pair in wordCount)
            {
                Console.WriteLine($"{pair.Key}出現{pair.Value}次");
            }
            
        }
    }
}
