namespace Nombre;
class Class
{


   class Nbr
    {
        private int N;
        private bool P = true;
        public bool IsPremier(string nbr)
        {
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
                return true;
            }
            else
            {
                return false;
            }

        }
    }

    public static void Main()
    {
        Nbr nbr = new Nbr();
        
        string nombr;
        Console.WriteLine("Entrez un nombre");
        nombr = Console.ReadLine();
        if (nbr.IsPremier(nombr))
        {
            Console.WriteLine("nbr premier");
        }
        else
        {
            Console.WriteLine("nbr non premier");
        }

    }    
}


