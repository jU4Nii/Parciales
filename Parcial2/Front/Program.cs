namespace Front
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido a ");
            string eleccion = IngresarString("Elija una opción:\n1.\n2.\n3.\n4.\n5.\n6.\n7.\n8.\n9.");


            Console.Clear();

            switch (eleccion)
            {
                case "1":
                    
                    Console.WriteLine("\nPresione una tecla para continuar...");
                    Console.ReadKey();
                    break;

                case "2":

                    Console.WriteLine("\nPresione una tecla para continuar...");
                    Console.ReadKey();
                    break;

                case "3":

                    Console.WriteLine("\nPresione una tecla para continuar...");
                    Console.ReadKey();
                    break;

                case "4":

                    Console.WriteLine("\nPresione una tecla para continuar...");
                    Console.ReadKey();
                    break;

                case "5":

                    Console.WriteLine("\nPresione una tecla para continuar...");
                    Console.ReadKey();
                    break;

                case "6":

                    Console.WriteLine("\nPresione una tecla para continuar...");
                    Console.ReadKey();
                    break;

                default:
                    Console.WriteLine("Opción inexistente");
                    Console.WriteLine("\nPresione una tecla para volver a elegir...");
                    Console.ReadKey();
                    break;

            }

            Console.Clear();

        }

        public static int PedirEntero(string mensaje)
        {

            int num;
            Console.WriteLine(mensaje);
            while (int.TryParse(Console.ReadLine(), out num) == false)
            {

                Console.WriteLine("Valor incorrecto, ingreselo nuevamente:");

            }

            return num;

        }

        public static DateTime PedirFecha(string mensaje)
        {
            DateTime fecha;
            Console.WriteLine(mensaje);
            string input = Console.ReadLine();

            while (DateTime.TryParseExact(input, "dd/MM/yyyy", null,
                    System.Globalization.DateTimeStyles.None, out fecha) == false)
            {
                Console.WriteLine("Fecha inválida, ingrese nuevamente (dd/MM/yyyy):");
                input = Console.ReadLine();
            }

            return fecha;
        }

        //Se usa: DateTime fechaViaje = PedirFecha("Ingrese la fecha del viaje (dd/MM/yyyy):");
        //Console.WriteLine("Fecha ingresada: " + fechaViaje.ToShortDateString());
        ////DateTime fechaPrestamo = DateTime.Now.Date;
        

        public static string IngresarString(string mensaje)
        {

            Console.WriteLine(mensaje);
            string palabra = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(palabra) == true)
            {

                Console.WriteLine("Valor incorrecto, ingreselo nuevamente:");
                palabra = Console.ReadLine();

            }

            return palabra;

        }

        /*
         public static void ValidarDuplicacion(Publicacion LibroAValidar)
        {

            bool duplicado = false;

            for (int i = 0; i < Publicacion.ListaPublicaciones.Count; i++)
            {

                if (Publicacion.ListaPublicaciones[i].Titulo == LibroAValidar.Titulo)
                {

                    duplicado = true;
                    break;

                }

            }

            if (duplicado) Console.WriteLine("La publicación ya existe en la base de datos");
            else
            {
                Publicacion.AñadirPublicacion(LibroAValidar);
                Console.WriteLine("¡Publicacion añadida exitosamente!");

            }

                

        }
      
        */
    }
}
