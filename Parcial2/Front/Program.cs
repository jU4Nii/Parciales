using BibliotecaDeClases;

namespace Front
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido a ");
            string eleccion = IngresarString("Elija una opción:\n1. Registrar libro\n2. Registrar préstamo de un libro\n3. Mostrar información de un libro\n4. Mostrar todos los libros y estadísticas generales\n5. Salir");

            while (eleccion != "5")
            {

                Console.Clear();

                switch (eleccion)
                {
                    case "1":
                        string eleccionTipo = IngresarString("Elija el tipo de libro que desea registrar:\n1. Físico\n2. Digital");
                        while(eleccionTipo != "1" && eleccionTipo != "2")
                        {

                            eleccionTipo = IngresarString("Elija un tipo de libro válido:\n1. Físico\n2. Digital");

                        }
                        if(eleccionTipo == "1")
                        {

                            string tituloF = IngresarString("Ingrese el título del libro:");
                            string autorF = IngresarString("Ingrese el autor del libro:");
                            string Disponible = IngresarString("¿El libro se encuentra disponible?\n1. Si\n2. No");
                            while(Disponible != "1" && Disponible != "2")
                            {

                                Disponible = IngresarString("Ingrese una respuesta válida:\n1. Si\n2. No");

                            }
                            LibroFisico nuevoLibroFisico = new LibroFisico(tituloF, autorF);
                            if(Disponible == "1") nuevoLibroFisico.Disponible = true;
                            else if(Disponible == "2") nuevoLibroFisico.Disponible= false;
                            Console.WriteLine("¡Libro registrado con éxito!");
                            Libro.ListaLibros.Add(nuevoLibroFisico);
                        }
                        else if(eleccionTipo == "2")
                        {

                            string tituloD = IngresarString("Ingrese el título del libro:");
                            string autorD = IngresarString("Ingrese el autor del libro:");
                            LibroDigital nuevoLibroDigital = new LibroDigital(tituloD, autorD);
                            Console.WriteLine("¡Libro registrado con éxito!");
                            Libro.ListaLibros.Add(nuevoLibroDigital);

                        }
                        Console.WriteLine("\nPresione una tecla para continuar...");
                        Console.ReadKey();
                        break;

                    case "2":
                        int ingresoISBN = PedirEntero("Ingrese el ISBN del libro que necesita:");
                        bool LibroExistente = false;
                        Libro libroBuscado;
                        for (int i = 0; i < Libro.ListaLibros.Count; i++)
                        {

                            if (Libro.ListaLibros[i].ISBN == ingresoISBN)
                            {
                                LibroExistente = true;
                                libroBuscado = Libro.ListaLibros[i];
                                Console.WriteLine($"¡Libro encontrado!'{libroBuscado.Titulo}'");
                                if (libroBuscado is LibroFisico Lfisico)
                                {
                                    if(Lfisico.Disponible == true)
                                    {
                                        DateTime FechaPrestamo = DateTime.Now;
                                        string socio = IngresarString("Ingrese su nombre de socio:");
                                        int Duracion = PedirEntero("Ingrese la cantidad de días del préstamo");
                                        Prestamo nuevoPrestamo = new Prestamo(FechaPrestamo, socio , Duracion);
                                        Lfisico.ListaPrestamos.Add(nuevoPrestamo);
                                        Lfisico.Disponible = false;
                                    }
                                    else
                                    {

                                        Console.WriteLine("El libro que buscas no está disponible actualmente");

                                    }
                                }
                                else if(libroBuscado is LibroDigital)
                                {

                                    DateTime FechaPrestamo = DateTime.Now;
                                    string socio = IngresarString("Ingrese su nombre de socio:");
                                    int Duracion = PedirEntero("Ingrese la cantidad de días del préstamo");
                                    Prestamo nuevoPrestamo = new Prestamo(FechaPrestamo, socio, Duracion);
                                    libroBuscado.ListaPrestamos.Add(nuevoPrestamo);
                                }
                            }
                            else
                            {

                                Console.WriteLine("El libro que buscas no está registrado en el sistema");

                            }

                        }
                        Console.WriteLine("\nPresione una tecla para continuar...");
                        Console.ReadKey();
                        break;

                    case "3":
                        int ingresoISBNParaInfo = PedirEntero("Ingrese el ISBN del libro que desea conocer información:");
                        for (int i = 0; i < Libro.ListaLibros.Count; i++)
                        {

                            if(ingresoISBNParaInfo == Libro.ListaLibros[i].ISBN)
                            {
                                Libro libroInfo = Libro.ListaLibros[i];
                                Console.WriteLine($"Título: {libroInfo.Titulo}; Autor: {libroInfo.Autor}; Cantidad de préstamos: {libroInfo.CalcularTotalPrestamos()}");
                                if(libroInfo is LibroFisico lFisico)
                                {

                                    if (lFisico.Disponible == true)
                                    {
                                        Console.WriteLine("Disponibilidad: Disponible");

                                    }
                                    else
                                    {

                                        Console.WriteLine("Disponibilidad: No disponible");

                                    }
                                }

                            }

                        }
                        Console.WriteLine("\nPresione una tecla para continuar...");
                        Console.ReadKey();
                        break;

                    case "4":
                        Libro.MostrarLibrosYEstadisticas();
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
                eleccion = IngresarString("Elija una opción:\n1. Registrar libro\n2. Registrar préstamo de un libro\n3. Mostrar información de un libro\n4. Mostrar todos los libros y estadísticas generales\n5. Salir");


                Console.Clear();
            }

            Console.WriteLine("Usted salió del programa");

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

        
    }
}
