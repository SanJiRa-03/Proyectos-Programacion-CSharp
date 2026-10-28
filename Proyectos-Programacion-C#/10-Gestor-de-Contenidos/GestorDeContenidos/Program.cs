// Sandra Jiménez Ramiro, Pablo Ros Tejerina y Beatriz María de la Torre Cardó - Grupo C
// Programación Orientada a Objetos 2021 - 2022
using System;
using System.IO;

namespace GestorDeContenidos
{
    class Program
    {
        static void Main(string[] args)
        {
            Catalogo catalogo = new Catalogo();

            
            // Usuario usuario;

            bool fin = false; // Booleano con el que ejecutaremos todo el codigo, cuano fin sea cierto, se saldrá del programa entero.
            bool log = false; // Booleano con el que ejecutaremos todas las acciones que quiera desarrollar un usuario registrado, cuano log sea cierto, el programa ejecutara las acciones que el usuario quiera.

            // Para no tener problemas de escritura ni lectura, para los usuarios utilizamos el FileStream en vez del Reader y el wrtiter sobre el mismo archivo
            FileStream fsUsuarios = new FileStream("Usuarios.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            FileStream fsContenidos = new FileStream("Contenidos.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);

            // Lo primero que hacemos es intentar leer el fichero de usuarios, si da error y piede volverlo a intentar
            if (catalogo.LeerFicheroUsuarios(fsUsuarios) && catalogo.LeerFicheroContenidos(fsContenidos)) // 
            {
                while (!fin)
                {
                    try
                    {

                        // Si no hay un usuario activo en la sesión
                        if (!log)
                        {
                            int opLog = 0;
                            do
                            {
                                try
                                {
                                    opLog = MenuLogin();
                                }
                                catch (Exception ex) { Console.WriteLine(ex.Message + " Presione cualquier tecla para volver a intentarlo."); Console.ReadKey(); Console.Clear(); }
                            } while (opLog < 1 || opLog > 3);

                            Console.Clear(); 

                            // Mientras que la opción no sea la de salir 
                            if (opLog != 3)
                            {

                                // Opción 1: Login
                                if (opLog == 1)
                                {
                                    log = catalogo.Login();
                                }
                                else if (opLog == 2)
                                {
                                    log = catalogo.Registro();
                                }
                            }
                            else if (opLog == 3)
                            {
                                Console.Clear();
                                // Antes de salir exportamos los datos del catalogo y los datos de los usuarios registrados
                                if(Exportar(catalogo, fsUsuarios, fsContenidos))
                                    Console.WriteLine("Exportación exitosa");

                                Console.WriteLine("Hasta pronto! Presione cualquier tecla para cerrar el programa");
                                Console.ReadKey();
                                fin = true;
                            }                            
                        }
                        else
                        {
                            // Cuando el usuario ya esta identificado puede comenzar a realizar las opciones
                            Console.Clear();
                            int op = 0;
                            do { op = Menu(); } while (op < 1 || op > 7);

                            switch (op)
                            {
                                case 1: // Primero declaramos variables comunes para todos los tipos y otras variables necesarias. // Los likes comienzan en 0 hasta que algun usuario les de alguna puntuación
                                    int opContent = 0; string titulo = "", plataforma ="", descripcion="", genero="", url=""; int calificacion=0, likes = 0;

                                    Console.Clear();
                                    try
                                    {
                                        do { opContent = MenuContenido(); } while (!ComprobarOpcion4(opContent)); // A la comprobacion añadimos la opción de volver al menú

                                        bool end = false;
                                        while (!end && opContent != 4) // Si se produce alguna excepcion no regresará a la pantalla de inicio sino que retomará desde aquí
                                        {
                                            try
                                            {
                                                Console.Clear();
                                                bool existente; // Comprobamos el tipo que queremos añadir
                                                bool añadirEpisodio;


                                                // Pedimos los valores que son necesarios independientemente del tipo
                                                Console.WriteLine("Por favor introduzca: ");
                                                Console.WriteLine("Título: ");                                               
                                                do
                                                {
                                                    titulo = Console.ReadLine();
                                                    existente = ComprobarTitulo(titulo, catalogo, opContent);
                                                    añadirEpisodio = ComprobarSiSerieOPodcast(catalogo, titulo, opContent);
                                                } while (existente); // Comprobamos que ningun contenido disponga ya de ese título mientras sea una pelicula o informamos de que existe y añadirá un episodio a la serie

                                                if (!existente && !añadirEpisodio) // Si no existe ninun elemento con dicho título
                                                {
                                                    Console.WriteLine("Plataforma: "); plataforma = Console.ReadLine();
                                                    Console.WriteLine("Descripción: "); descripcion = Console.ReadLine();
                                                    Console.WriteLine("Género: "); genero = Console.ReadLine();
                                                    Console.WriteLine("Url: "); url = Console.ReadLine();
                                                    Console.WriteLine("Calificación por edad (indique le mínimo de edad recomendado): ");
                                                    do { calificacion = int.Parse(Console.ReadLine()); } while (!ComprobarEdad(calificacion));
                                                }

                                                // Añadimos dependiendo del contenido o de si ya existe una serie o podcast con dicho nombre
                                                if (opContent == 1)
                                                {

                                                    if (catalogo.AñadirPelicula(titulo, plataforma, descripcion, genero, url, calificacion, likes))
                                                        Console.WriteLine("Añadido correctamente, presione cualquier tecla para continuar.");

                                                }
                                                else if (opContent == 2)
                                                {
                                                    if (!existente && !añadirEpisodio)
                                                    {
                                                        if (catalogo.AñadirSerie(titulo, plataforma, descripcion, genero, url, calificacion, likes))
                                                            Console.WriteLine("Añadido correctamente, presione cualquier tecla para continuar.");
                                                        else
                                                            Console.WriteLine("Error al añadir, presione cualquier tecla para continuar.");
                                                    }
                                                    else
                                                    {
                                                        foreach (Contenido cont in catalogo.Contenidos)
                                                        {
                                                            if (cont is Serie serieLocal)
                                                            {
                                                                if (serieLocal.Get_Titulo().ToLower() == titulo.ToLower())
                                                                    serieLocal.Episodios.Add(catalogo.AñadirEpisodio(serieLocal.Get_NumeroTemporadas()));
                                                            }
                                                        }
                                                    }
                                                }
                                                else if (opContent == 3)
                                                {
                                                    if (!existente && !añadirEpisodio)
                                                    {
                                                        if (catalogo.AñadirPodcast(titulo, plataforma, descripcion, genero, url, calificacion, likes))
                                                            Console.WriteLine("Añadido correctamente, presione cualquier tecla para continuar.");
                                                        else
                                                            Console.WriteLine("Error al añadir, presione cualquier tecla para continuar.");
                                                    }
                                                    else
                                                    {
                                                        foreach (Contenido cont in catalogo.Contenidos)
                                                        {
                                                            if (cont is Podcast podcastLocal)
                                                            {
                                                                if (podcastLocal.Get_Titulo().ToLower() == titulo.ToLower())
                                                                    podcastLocal.Episodios.Add(catalogo.AñadirEpisodio(-1)); // El valor es -1 para poder reutilizar la funcion tanto para series como para podcast y que no afecte de forma negativa
                                                            }
                                                        }
                                                    }
                                                }
                                                else
                                                    Console.WriteLine("[ERROR]");
                                                end = true;
                                                Console.ReadKey(); Console.Clear();
                                            }
                                            catch (Exception e) { Console.WriteLine(e.Message + "\nPresione cualquier tecla para volver a intentarlo"); Console.ReadKey(); Console.Clear(); }
                                        }
                                        if (opContent == 4)
                                            Console.WriteLine("Presione cualquier tecla para volver al menú");
                                    }
                                    catch (Exception ex) { Console.WriteLine(ex.Message + "\nPresione cualquier tecla para volver al menú"); Console.ReadKey(); Console.Clear(); }
                                    break;

                                case 2: // Buscar contenido por titulo
                                    Console.Clear();
                                    catalogo.MostrarBusqueda();
                                    break;

                                case 3:  // Mostrar contenido
                                    Console.Clear();
                                    if(catalogo.Contenidos.Count != 0)
                                    {
                                        catalogo.Mostrar();
                                    }
                                    else
                                    {
                                        Console.WriteLine("Lista de contenidos vacia, introduzca alguno para mostrar.\nPresione cualquier tecla para continuar"); Console.ReadKey(); Console.Clear(); 
                                    }
                                    break;

                                case 4: // Mostrar contenido de un tipo determinado
                                    Console.Clear();
                                    try
                                    {
                                        int tipoAmostrar = 0;
                                        do { tipoAmostrar = MenuContenido(); } while (!ComprobarOpcion4(tipoAmostrar));

                                        Console.Clear();
                                        catalogo.MostrarPorTipo(tipoAmostrar);
                                    }
                                    catch (Exception ex) { Console.WriteLine(ex.Message); }

                                    Console.WriteLine("\nPresione cualquier tecla para continuar...");
                                    Console.ReadKey(); Console.Clear();
                                    break;

                                case 5: // Mostrar el contenido con mayor número de likes
                                    Console.Clear();
                                    catalogo.MostrarPorLikes();
                                    break;

                                case 6: // Dar like
                                    Console.Clear();
                                    catalogo.Valorar();
                                    break;

                                case 7: // Logout                                                                
                                    log = false; Console.Clear();
                                    break;

                                default:
                                    Console.WriteLine("Opción no válida, presione cualquier tecla y vuelva al menu.");
                                    Console.ReadKey(); Console.Clear();
                                    break;
                            }
                        }
                    }
                    catch (FormatException e) { Console.WriteLine(e.Message); }
                }
            }
            else
            {
                Console.WriteLine("\nEste error no permite continuar con la ejecucion normal del programa ya que no se puede abrir uno de los dos archivos requeridos, presione cualquier tecla para continuar.");
                Console.ReadKey();
            }            
        }
        // Métodos que aportan funcionalidad
        // Menu de opciones del catalogo
        private static int Menu()
        {
            int op;
            Console.WriteLine("Gestor de contenidos \n");
            Console.WriteLine("Menu de opciones: ");
            Console.WriteLine("1. Añadir nuevo contenido");
            Console.WriteLine("2. Buscar contenido por su titulo.");
            Console.WriteLine("3. Mostrar todos los contenidos (peliculas, series y podcast).");
            Console.WriteLine("4. Mostrar todos los contenidos de un tipo.");
            Console.WriteLine("5. Mostrar contenido con mayor número de likes.");
            Console.WriteLine("6. Valorar un contenido (dar like).");
            Console.WriteLine("7. Logout");
            Console.WriteLine("\nPor favor seleccione la operación que quiera realizar: ");
            op = int.Parse(Console.ReadLine());
            return op;
        }
        // Menu Log in
        private static int MenuLogin()
        {
            int op;
            Console.WriteLine("Bienvenido al programa de Gestion de Contenidos\n");
            Console.WriteLine("Opciones:");
            Console.WriteLine("1. Iniciar Sesion\n2. Registrarse como nuevo usuario\n3. Salir");
            Console.WriteLine("Introduzca la opcion que desee: ");
            op = int.Parse(Console.ReadLine());
            return op;
        }
        // Menu de contenido
        private static int MenuContenido()
        {
            int op;
            Console.WriteLine("Tipo de contenido: ");
            Console.WriteLine("1. Pelicula");
            Console.WriteLine("2. Serie");
            Console.WriteLine("3. Podcast");
            Console.WriteLine("4. Salir");
            op = int.Parse(Console.ReadLine());
            return op;
        }

        // Función para guardar en archivos .txt la información recogida en el programa
        private static bool Exportar(Catalogo catalogo, FileStream fsUsuarios, FileStream fsContenidos)
        {
            bool ok = false;

            // Primero guardamos el fichero de usuarios
            if (catalogo.ExportarFicheroUsuarios(fsUsuarios) && catalogo.ExportarFicheroContenidos(fsContenidos))
            {
                // Cerramos los archivos en el que estabamos actuando
                fsUsuarios.Close(); 
                fsContenidos.Close();
                ok = true;
            }       

            return ok;
        }

        // Métodos de comprobación
        // Comprobar opcion entre 4 disponibles
        private static bool ComprobarOpcion4(int valor)
        {
            bool valido = true;
            if (valor < 1 || valor > 4)
            {
                Console.WriteLine("Por favor, elija una opción entre las disponibles.");
                valido = false;
            }
            return valido;
        }

        // Comprobamos que no haya ningun contenido con el nombre que se quiere introducir
        private static bool ComprobarTitulo(string titulo, Catalogo cat, int tipoAintroducir)
        {
            bool error = false;  int cont = 0;

            foreach (Contenido c in cat.Contenidos)
            {
                if (c.Get_Titulo().ToLower() == titulo.ToLower() && tipoAintroducir == 1) // Comprobamos que no se repite el titulo en las películas              
                    cont++;
                else if (c.Get_Titulo().ToLower() == titulo.ToLower() && (tipoAintroducir == 2 || tipoAintroducir == 3))
                    cont = -1;

            }

            if(cont > 0)
            {
                Console.WriteLine("Ya dipones de un contenido con ese título, introduzca uno válido: ");
                error = true;
            }
            else if(cont == -1)
            {
                Console.WriteLine("Serie ya creada, presione cualquier tecla para añadir un episodio de dicha serie");
                Console.ReadKey(); Console.Clear();
            }
            return error;
        }
        private static bool ComprobarSiSerieOPodcast(Catalogo cat, string titulo, int tipoAintroducir)
        {
            bool ok = false;

            foreach (Contenido c in cat.Contenidos)
            {
                if (c.Get_Titulo().ToLower() == titulo.ToLower() && (tipoAintroducir == 2 || tipoAintroducir == 3))
                {
                    ok = true;
                }
            }

            return ok; 
        }
        // Funcion que comprueba que la edad introducida es coherente
        private static bool ComprobarEdad(int edad)
        {
            bool ok = true;
            if (edad < 0 || edad > 19) // No puede ser un individuo menor que 0 años y segun la normativa de calificacion de peliculas a nivel global, a partir de los 18 todo individuo puede ver todo tipo de contenido bajo su responsabilidad
            {
                ok = false;
                Console.WriteLine("Edad no valida para calificación, introduzca un valor entre 0 y 19: ");
            }
            return ok;
        }
    }
}
