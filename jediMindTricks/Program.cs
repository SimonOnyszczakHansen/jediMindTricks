namespace jediMindTricks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> people = new Dictionary<string, int>() { { "Patrick", 17 } };
            people.Add("Tue", 18);
            people.Remove("Tue");
            foreach (KeyValuePair<string, int> pair in people)
            {
                Console.WriteLine(pair.Key);
            }
        }
    }
}