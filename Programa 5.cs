namespace nombre
{
    class Program 
    {
        static void Main(string[] args)
        {
            string nombre;
            string apellido;

            Console.Write(" Escribe un nombre: ");
            nombre = Console.ReadLine();
            Console.Write(" Escribe un Apellido: ");
            apellido = Console.ReadLine();

            nombre = nombre.ToUpper();
            apellido = apellido.ToUpper();

           

            StringBuilder nombrecompleto  = new StringBuilder();
            nombrecompleto.Append(nombre);
            nombrecompleto.Append(" ");
            nombrecompleto.Append(apellido);

            Console.WriteLine(nombrecompleto);

            Console.ReadKey();
}
}
}