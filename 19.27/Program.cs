namespace _19._27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> a = new List<int>();
            List<int> b = new List<int>();
            string input;
            do
            {
                Console.Write("inserisci un numero(o premi invio per uscire): ");
                input = Console.ReadLine();
                int number;
                if (input == "")
                    break;
                else
                {
                    int.TryParse(input, out number);
                    a.Add(number);
                }

            } while (input != "");
            do
            {
                Console.Write("inserisci un numero(o premi invio per uscire): ");
                input = Console.ReadLine();
                int number;
                if (input == "")
                    break;
                else
                {
                    int.TryParse(input, out number);
                    b.Add(number);
                }

            } while (input != "");

            Stampa(a);
            Stampa(b);


            List<int> c = new List<int>();
            for (int i = 0; i < a.Count; i++)
            {
                if(!b.Contains(a[i]))
                {
                    c.Add(a[i]);
                }
            }

            for (int i = 0; i < b.Count; i++)
            {
                if (!a.Contains(b[i]))
                {
                    c.Add(b[i]);
                }
            }

            Stampa(c);


            static void Stampa(List<int> a)
            {
                foreach (var item in a)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine();
            }
        }
    }
}
