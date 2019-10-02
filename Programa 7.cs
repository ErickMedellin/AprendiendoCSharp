namespace Tablas
{
    class Program
    {
        static void Main(string[] args)
        {
            int res = 0;

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Tabla del " + i);

                for (int e = 1; e <= 10; e++)
                {
                    res = i * e;
                    Console.WriteLine(i + " x " + e + " = " + res);
                }

                Console.WriteLine(" ");
            }

            Console.ReadKey();
        }
}
}