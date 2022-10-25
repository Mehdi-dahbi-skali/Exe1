
class Prg
{
    public static void Main()
    {
        string nbr;
        int N;
        bool P = true;
        nbr = Console.ReadLine();
        while (!(int.TryParse(nbr, out N)))
        {
            nbr = Console.ReadLine();
        };
        for (int i = 2; i < N - 1 && P; i++)
        {
            if (N % i == 0)
            {
                P = false;
            }
        }
        if (P)
        {
            Console.WriteLine("nbr premier");
        }
        else
        {
            Console.WriteLine("nbr non premier");
        }
    }
}