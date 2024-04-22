namespace List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> chaine = new List<string>();
            chaine.Add("je suis siwar");
            chaine.Add("je suis en formation");
            chaine.Add("avec wild");
            chaine.RemoveAt(0);
            chaine.Remove("avec wild");
            chaine[0] = "Je suis en formation avec wild school";

            Console.WriteLine("affiche la liste : ");
            foreach (string ch in chaine)
            {
                Console.WriteLine(ch);
            }
        }
    }
}
