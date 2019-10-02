using System;

namespace Entrada
{
    class Program
    {
        static void Main(string[] args)
        {
            //Primero se declara la variable a usar
            string valor;
            //Posteriormente se pide la variable
            Console.Write("\n\n\tEscribe algo: ");
            //A continuacion se lee y se guarda en la variable declarada
            valor = Console.ReadLine();
            //Se hace un try catch que es mas facil de usar y con menos problemas que con el if else
            try
            {
                int x = int.Parse(valor);
                Console.WriteLine("\n\tDato entero {0} es correcto.", valor);
            }
            catch
            {
                Console.WriteLine("\n\tDato no es entero. Intentar de nuevo.");
            }
            //Y finalmente se acaba el programa
            Console.WriteLine("\n\tPresiona enter para continuar....");
            //Se hace un ReadKey ya que sin el no se veria el programa solo correria sin pausarse
            Console.ReadKey();
        }
    }
}
