internal class Program
{
    static void Main(string[] args)
    {
        bool run = true;

        while (run)
        {
            double straalNum = GetInput("straal");
            double hoogteNum = GetInput("hoogte");
            double PI = 3.14159;
       
            double straalKwadraat = straalNum * straalNum;
            double PiKeerStraalKwadraat = straalKwadraat * PI;
            double volumeCM = PiKeerStraalKwadraat * hoogteNum;
            double inhoudL = volumeCM / 1000;

            Console.Clear();
            Console.WriteLine($"De inhoud van de maatbeker is {inhoudL:F4} L\n");
            Console.WriteLine($"Druk op X om af te sluiten of een andere toets om door te gaan\n");

            string input = Console.ReadLine();

            if (input?.ToLower() == "x")
            {
                run = false;
            }
        }
    }

    static double GetInput(string dimension)
    {
        double result;

        while (true)
        {
            
            Console.WriteLine($"\nGeef {dimension} in centimeters");
            string input = Console.ReadLine();

            if (double.TryParse(input, out result))
            {
                return result;
            }

            Console.WriteLine("Ongeldige invoer!");
            Console.ReadLine();
        }
    }
}
