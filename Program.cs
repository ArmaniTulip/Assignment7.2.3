namespace Assignment7._2._3
{
    internal class Program
    {
        //Are the words an Anagram?
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your first word");
            string s = Console.ReadLine();
            Console.WriteLine("Enter your second word");
            string t = Console.ReadLine();

            bool result = IsAnAnagram(s, t);

            Console.WriteLine($"Is {s} and {t} an anagram? {result}");
        }

        static bool IsAnAnagram(string s, string t)
        {
            //if lengths are different then it will return false
            if (s.Length != t.Length)
            {
                return false;
            }


            //convert strings to arrays and sort
            char[] charsS = s.ToCharArray();
            char[] charsT = t.ToCharArray();
            Array.Sort(charsS);
            Array.Sort(charsT);


            //compare the sorted arrays
            for (int i = 0; i < charsS.Length; i++)
            {
                if (charsS[i] != charsT[i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
