// Usuarios
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorDeContenidos
{
    class Catalogo
    {
        private List<Contenido> contenidos;
        private List<Usuario> usuarios;
        private Usuario usuario; // Este usuario es el que esta interactuando con el catalogo ahora mismo
        Pelicula pelicula; Serie serie; Podcast podcast; Episodio episodio;

        public Catalogo()
        {
            contenidos = new List<Contenido>();
            usuarios = new List<Usuario>();
            usuario = new Usuario();
        }

        // Accesores y mutadores
        public List<Contenido> Contenidos { get => contenidos; set => contenidos = value; }
        public List<Usuario> Usuarios { get => usuarios; set => usuarios = value; }
        public Usuario Usuario { get => usuario; set => usuario = value; }

        /* Funciones de lectura y escritura en el fichero de usuarios */
        public bool LeerFicheroUsuarios(FileStream fs)
        {
            bool ok = true;
            string lectura, nombre, contraseña;
            try
            {
                StreamReader entrada = new StreamReader(fs);
                
                while (entrada.Peek() > 1)
                {
                    lectura = entrada.ReadLine();
                    string[] division = lectura.Split('|');

                    nombre = division[0];
                    contraseña = division[1];
                    usuario = new Usuario(nombre, contraseña);

                    usuarios.Add(usuario);
                }
            }
            catch (Exception e)
            {
                Console.Clear();
                Console.WriteLine("Excepcion: " + e.Message);
                ok = false;
            }
            return ok;
        }
        public bool LeerFicheroContenidos(FileStream fs)
        {
            bool ok = true;
            string lectura, lecturaEpisodio;
            try
            {
                StreamReader entrada = new StreamReader(fs);

                while (entrada.Peek() > 1) // Si la cadena tiene menos de un caracter, dejara de leer -> señala el fin de ka ejecucion
                {
                    lectura = entrada.ReadLine();
                    string[] division = lectura.Split('|');

                    if (division[0] == "Película")
                    {
                        pelicula = new Pelicula();
                        pelicula = (Pelicula)LeerGenerico(division, "Película");

                        string director, distribuidora; int añoEstreno, duracion;

                        director = division[9]; pelicula.Set_Director(director);
                        distribuidora = division[10]; pelicula.Set_Distribuidora(distribuidora);
                        añoEstreno = int.Parse(division[11]); pelicula.Set_AñoEstreno(añoEstreno);
                        duracion = int.Parse(division[12]); pelicula.Set_Duracion(duracion);

                        contenidos.Add(pelicula);
                    }
                    else if (division[0] == "Serie")
                    {
                        serie = new Serie();
                        serie = (Serie)LeerGenerico(division, "Serie");

                        serie.Set_NumeroTemporadas(int.Parse(division[9]));
                        serie.Set_Estado(ComprobarEstado(division[10]));

                        lecturaEpisodio = entrada.ReadLine();

                        string[] division2 = lecturaEpisodio.Split('|');

                        episodio = LeerEpisodio(division2);
                        episodio.TipoAlmacenado = serie;

                        serie.Episodios.Add(episodio);

                        contenidos.Add(serie);

                    }
                    else if (division[0] == "Podcast")
                    {
                        podcast = new Podcast();
                        podcast = (Podcast)LeerGenerico(division, "Podcast");
                        episodio = new Episodio();

                        podcast.Set_Tipo(ObtenerTipo(division[9]));
                        podcast.Set_FechaCaducidad(ObtenerCaducidad(division[10]));

                        lecturaEpisodio = entrada.ReadLine();

                        string[] division2 = lecturaEpisodio.Split('|');

                        episodio = LeerEpisodio(division2);
                        episodio.TipoAlmacenado = podcast;
                        podcast.Episodios.Add(episodio);

                        contenidos.Add(podcast);
                    }
                }
            }
            catch (Exception e)
            {
                Console.Clear();
                Console.WriteLine("Excepcion: " + e.Message);
                ok = false;
            }
            return ok;
        }
        private Contenido LeerGenerico(string[] datosContenido, string tipo)
        {
            Contenido contenido = new Contenido();
            string titulo, plataforma, descripcion, genero, url; Usuario usuario; int calificacion, likes; int contadorEncontrados = 0;
            usuario = new Usuario();

            titulo = datosContenido[1];
            plataforma = datosContenido[2];
            descripcion = datosContenido[3];
            genero = datosContenido[4];
            url = datosContenido[5];

            // Función para saber quien es el usuario y si lo tenemos en el archivo o no
            foreach (Usuario user in usuarios)
            {
                if (datosContenido[6].ToLower() == user.Get_Nombre().ToLower())
                {
                    usuario = user; contadorEncontrados++;
                }
            }
            if (contadorEncontrados == 0)
            {
                usuario.Set_Nombre(datosContenido[6]); usuario.Set_Contraseña("0"); // Si es un usuario que no aparece en la lista entonces lo crearemos con una contraseña vacia
            }
            calificacion = int.Parse(datosContenido[7]);
            likes = int.Parse(datosContenido[8]);

            if(tipo == "Película")
                contenido = new Pelicula(titulo, plataforma, descripcion, genero, url, usuario, calificacion, likes);
            else if (tipo == "Serie")
                contenido = new Serie(titulo, plataforma, descripcion, genero, url, usuario, calificacion, likes);
            else if(tipo == "Podcast")
                contenido = new Podcast(titulo, plataforma, descripcion, genero, url, usuario, calificacion, likes);


            return contenido;
        }
        private Episodio LeerEpisodio(string[] datosEpisodio)
        {
            episodio = new Episodio();

            episodio.Set_Titulo(datosEpisodio[0]);
            episodio.Set_Temporada(int.Parse(datosEpisodio[1]));
            episodio.Set_EpisodioTemporada(int.Parse(datosEpisodio[2]));
            return episodio;
        }

        public bool ExportarFicheroUsuarios(FileStream fs)
        {
            bool ok = true;
            try
            {
                
                StreamWriter salida = new StreamWriter(fs);
                fs.Seek(0, SeekOrigin.Begin);

                foreach (Usuario usuario in Usuarios)
                {                  
                    salida.WriteLine(usuario.Get_Nombre() + "|" + usuario.Get_Contraseña());
                }
                salida.Flush();
            }
            catch (Exception e)
            {
                Console.Clear();
                Console.WriteLine("Excepcion: " + e.Message);
                ok = false;
            }
            return ok;
        }
        public bool ExportarFicheroContenidos(FileStream fs)
        {
            bool ok = true;
            try
            {
                StreamWriter salida = new StreamWriter(fs);
                fs.Seek(0, SeekOrigin.Begin);

                foreach (Contenido contenido in Contenidos)
                {
                    string tipo = ComprobarTipo(contenido);
                    salida.Write(tipo + "|"); contenido.ExportarContenidos(salida);
                }

                salida.Flush(); // Volcamos todo el contenido y limpiamos la memoria
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                ok = false;
            }
            return ok;
        }
        
       

        /* Funciones para el tratamiento de la información de los usuarios */
        public bool Login()
        {
            string nombre, contraseña;
            bool log = false; // Boleano que indicará si se ha producido el inico de sesion o no

            bool errorPswrd = true; bool nonError = false; bool esc = false; // esc es un comando por si no quiere seguir intentando la contraseña

            int contEncontrados = 0; // Si no se encuentra ningun usuario con los datos que ha introducido, este contador seguirá a 0
            
            Console.WriteLine("Introduzca su nombre de usuario: "); nombre = Console.ReadLine().ToLower();

            while (!nonError)
            {
                foreach (Usuario user in Usuarios)
                {
                    if (nombre == user.Get_Nombre().ToLower())
                    {
                        contEncontrados++;
                        // Si se encuentra  un usuario que coincida con el nombre que se ha introducido por consola
                        Console.WriteLine("Introduzca su contraseña: (escriba '0' si no dispone de una)");
                        do
                        {
                            try
                            {
                                contraseña = Console.ReadLine();

                                if (contraseña == user.Get_Contraseña())
                                {
                                    errorPswrd = false;
                                    log = true;
                                    Usuario = user; // Guardamos el usuario para saber quien está realizando las acciones
                                    Console.WriteLine("Usuario con credenciales correctas, presione cualquier tecla para acceder al menu del catálogo");
                                    Console.ReadKey();

                                }
                                else if (contraseña.ToLower() == "esc")
                                {
                                    esc = true;
                                }
                                else if (contraseña != user.Get_Contraseña())
                                {
                                    Console.WriteLine("Contraseña erronea vuelva a intentarlo.");
                                    Console.WriteLine("\nIntroduzca su contraseña o escriba 'esc' para volver al menú: ");
                                }
                            }
                            catch (Exception ex) { Console.WriteLine(ex.Message + "Presione cualquier tecla para volver a intentarlo."); Console.ReadKey(); Console.Clear(); errorPswrd = true; esc = false; } // Para seguir intentandolo

                        } while (errorPswrd && !esc);
                        nonError = true;
                    }
                }
                if (contEncontrados == 0)
                {
                    Console.WriteLine("No se ha encontrado ningun usuario con ese nombre, si desea añadirlo hagalo desde el menu");
                    nonError = true;
                }
            }
           Console.Clear();
            return log;
        }
        public bool Registro()
        {
            bool log = false;

            string nombre, contraseña;

            bool error = true;
            while (error)
            {
                try
                {
                    Console.WriteLine("Introduzca su nuevo nombre de usuario: ");
                    do
                    {
                        nombre = Console.ReadLine();
                    } while (ComprobarNombreUsuario(nombre)); // Comprobamos si existe algun nombre de usuario con el mismo nick

                    Console.WriteLine("Introduzca su nueva contraseña (al menos 8 caracteres): ");
                    do
                    {
                        contraseña = Console.ReadLine();
                    } while (!ComprobarContraseña(contraseña));

                    usuario = new Usuario(nombre, contraseña);
                    Usuarios.Add(usuario);

                    // Guardamos el usuario para saber quien está realizando las acciones
                    Usuario = usuario;

                    Console.WriteLine("Usuario Añadido correctamente, presione cualquier tecla para acceder al menu del catálogo");
                    Console.ReadKey(); Console.Clear();
                    log = true;
                    error = false;
                }
                catch (Exception ex) { Console.WriteLine(ex.Message + "Presione cualquier tecla para volver a intentarlo."); Console.ReadKey(); Console.Clear(); }
            }
            return log;
        }


        /* Funciones para el tratamiento de la información de los contenidos */

        // Añadir contenidos
        public bool AñadirPelicula(string titulo, string plataforma, string descripcion, string genero, string url, int calificacion, int likes)
        {
            bool ok = false;
            while (!ok)
            {
                try
                {
                    int añoEstreno, duracion; string director, distribuidora;
                    Console.WriteLine("Año de estreno: ");
                    do
                    {
                        añoEstreno = int.Parse(Console.ReadLine());
                    } while (!ComprobarAñoValido(añoEstreno));
                    Console.WriteLine("Duracion (en minutos): "); duracion = int.Parse(Console.ReadLine());
                    Console.WriteLine("Director: "); director = Console.ReadLine();
                    Console.WriteLine("Distribuidora: "); distribuidora = Console.ReadLine();

                    // El usuario que introducimos es el que habiamos guardado previamente para poder llevar a cabo la funcionalidad requerida
                    pelicula = new Pelicula(titulo, plataforma, descripcion, genero, url, Usuario, calificacion, likes, añoEstreno, duracion, director, distribuidora);
                    Contenidos.Add(pelicula);
                    ok = true;
                }
                catch (Exception e) { Console.WriteLine(e.Message + "\nVuelva a intentarlo"); }
            }
            return ok;
        }
        public bool AñadirSerie(string titulo, string plataforma, string descripcion, string genero, string url, int calificacion, int likes)
        {
            bool ok = false;
            while (!ok)
            {
                try
                {
                    int numeroTemporadas, estado;
                    Console.WriteLine("Numero de temporadas: "); numeroTemporadas = int.Parse(Console.ReadLine());
                    Console.WriteLine("Estado (1 - En emision 2- Finalizado) : ");
                    do
                    {
                        estado = int.Parse(Console.ReadLine());
                    } while (!ComprobarOpcion2(estado));

                    serie = new Serie(titulo, plataforma, descripcion, genero, url, Usuario, calificacion, likes, numeroTemporadas, estado);

                    serie.Episodios.Add(AñadirEpisodio(numeroTemporadas));
                    // Guardamos el tipo de contenido del que tiene datos el episodio 
                    episodio.TipoAlmacenado = serie;
                    Contenidos.Add(serie);
                    ok = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message + "\nVuelva a intentarlo");
                }
            }
            return ok;
        }
        public bool AñadirPodcast(string titulo, string plataforma, string descripcion, string genero, string url, int calificacion, int likes)
        {
            bool ok = false;
            while (!ok)
            {
                try
                {
                    int tipo, fechaCaducidad;
                    Console.WriteLine("Tipo de podcast (1 - Audio 2 - Video): "); do
                    {
                        tipo = int.Parse(Console.ReadLine());

                    } while (!ComprobarOpcion2(tipo));
                    Console.WriteLine("Fecha de caducidad (0 si no caduca) : ");
                    do
                    {
                        fechaCaducidad = int.Parse(Console.ReadLine());
                    } while (!ComprobarCaducidadValida(fechaCaducidad));

                    podcast = new Podcast(titulo, plataforma, descripcion, genero, url, Usuario, calificacion, likes, tipo, fechaCaducidad);

                    int numeroTemporadas = -1; // Como es indefinido indicamos a -1 para la compronbacion                                             

                    podcast.Episodios.Add(AñadirEpisodio(numeroTemporadas));
                    // Guardamos el tipo de contenido del que tiene datos el episodio         
                    episodio.TipoAlmacenado = podcast;
                    Contenidos.Add(podcast);
                    ok = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message + "\nVuelva a intentarlo");
                }
            }
            return ok;

        }
        public Episodio AñadirEpisodio(int numeroTemporadas)
        {
            bool ok = false;
            while (!ok)
            {
                try
                {
                    Console.Clear(); int temporada, episodiotemporada; string tituloEpi;
                    Console.WriteLine("Introduce tambien los datos del episodio: ");
                    Console.WriteLine("Título del episodio: "); tituloEpi = Console.ReadLine();
                    Console.WriteLine("Temporada: ");
                    do
                    {
                        temporada = int.Parse(Console.ReadLine());
                    } while (!ComprobarTemporada(numeroTemporadas, temporada)); // Comprobamos que no haya introducido una temporada que no exista en la serie                                                        
                    Console.WriteLine("Numero del episodio en esta temporada: "); episodiotemporada = int.Parse(Console.ReadLine());

                    episodio = new Episodio(tituloEpi, temporada, episodiotemporada);
                    ok = true;
                    Console.WriteLine("Añadido Correctamente");
                }
                catch (Exception e) { Console.WriteLine(e.Message + "\nVuelva a intentarlo."); }
            }
            return episodio;
        }

        // Funciones para mostrar por pantalla los datos solicitados
        public void MostrarBusqueda()
        {
            try
                {
                int contB = 0; string tituloB;

                Console.WriteLine("Introduce el título del contenido: "); tituloB = Console.ReadLine().ToLower();

                foreach (Contenido content in Contenidos)
                {
                    if (tituloB == content.Get_Titulo().ToLower())
                    {
                        string tipoObjeto = ComprobarTipo(content);
                        Console.WriteLine("\nTipo de contenido: " + tipoObjeto);
                        content.MostrarContenidos();
                        contB++;
                    }
                }
                if (contB == 0)
                    Console.WriteLine("No se ha encontrado ningun contenido con dicho título");

            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }

            Console.WriteLine("Presione cualquier tecla para continuar..."); Console.ReadKey(); Console.Clear();               
        }
        public void Mostrar()
        {
            try
            {
                if (Contenidos != null)
                {
                    Console.WriteLine("Gestor de contenidos: \n");
                    foreach (Contenido content in Contenidos)
                    {
                        string tipoObjeto = ComprobarTipo(content);
                        Console.WriteLine("Tipo de contenido: " + tipoObjeto);

                        content.MostrarContenidos();
                    }
                }
                else
                    Console.WriteLine("Lista vacía.\n");
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }

            Console.WriteLine("Presione cualquier tecla para continuar..."); Console.ReadKey(); Console.Clear();
        }
        public void MostrarPorTipo(int tipoAmostrar)
        {
            Type d; // Variable donde guardaremos cada tipo dependiendo de lo que seleccione el usuario

            if (tipoAmostrar == 1)
            {
                d = typeof(Pelicula); // Con esta funcion, obtenemos el tipo de un objeto y lo almacenamos en la variable que hemos creado antes
                Console.WriteLine("Mostrando contenidos del tipo: Pelicula" + "\n");
                MostrarPorContenido(d);
            }
            else if (tipoAmostrar == 2)
            {
                d = typeof(Serie);
                Console.WriteLine("Mostrando contenidos del tipo: Serie" + "\n");
                MostrarPorContenido(d);
            }
            else if (tipoAmostrar == 3)
            {
                d = typeof(Podcast);
                Console.WriteLine("Mostrando contenidos del tipo: Podcast" + "\n");
                MostrarPorContenido(d);
            }
            else
                Console.WriteLine("Volviendo al menu principal");
        }
        public void MostrarPorLikes()
        {
            try
            {
                if (Contenidos.Count != 0)
                {
                    Contenido mayor = new Contenido();

                    mayor = MayorNumeroDeLikes();

                    Console.WriteLine("Contenido con mayor número de likes: \n");
                    mayor.MostrarContenidos();
                }
                else
                {
                    Console.WriteLine("Lista de contenidos vacía, introduzca contenidos para poder disponer de estas funcionalidades.");
                }

            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }

            Console.WriteLine("Presione cualquier tecla para continuar..."); Console.ReadKey(); Console.Clear();
        }
        public void MostrarPorContenido(Type d)
        {
            int cont = 0;
            if (Contenidos != null)
            {
                foreach (Contenido content in Contenidos)
                {
                    if (content.GetType() == d)
                    {
                        content.MostrarContenidos();
                        cont++;
                    }
                }
                if (cont == 0)
                    Console.WriteLine("No existe ningún contenido de ese tipo guardado.");
            }
            else
                Console.WriteLine("Lista vacía");
        }

        // Fncion para valorar  una publicación
        public void Valorar()
        {
            try
            {
                int aux = -1; // Guardaremos en esta variable auxiliar la posicion del elemento que se quiere valorar

                // Minetras haya algun elemento en la lista
                if (Contenidos.Count != 0)
                {

                    int i = 1;
                    foreach (Contenido content in Contenidos)
                    {
                        Console.WriteLine(i + ". " + ComprobarTipo(content) + ": " + content.Get_Titulo());
                        i++;
                    }
                    Console.WriteLine("Introduzca el número del contenido que desee dar un like (0 para salir): ");
                    bool ok = false;
                    do
                    {
                        try
                        {
                            aux = int.Parse(Console.ReadLine());

                            if (aux > 0 && aux <= Contenidos.Count) // Miramos si esta dentro del ranfo
                                ok = ComprobarUsuarioValorando(Usuario, Contenidos[aux - 1].Usuario);
                            else if (aux == 0)
                                ok = true;
                            else
                                Console.WriteLine("\nValor fuera de rango, introduzaca una opción válida (0 para salir): ");
                        }
                        catch(Exception e) { Console.WriteLine("\n" + e.Message + "\nIntroduzca una opción entre las disponibles: "); }                        

                    } while (!ok);

                    // Mientras que no se quiera salir del programa o se produzca algun error se valorara el contenido solicitado
                    if (aux > 0)
                    {
                        aux -= 1; // Disminuimos porque la lista empieza por el 0
                        int valor = Contenidos[aux].Get_NumeroLikes() + 1;

                        Contenidos[aux].Set_NumeroLikes(valor);

                        Console.WriteLine("Valorado correctamente, presione cualquier tecla para continuar...");
                    }
                    else
                        Console.WriteLine("Volviendo al menú principal, presione cualquier tecla para continuar...");

                }
                else
                    Console.WriteLine("Lista de contenidos vacía, presione cualquier tecla para continuar...");
            }
            catch (Exception ex) { Console.WriteLine(ex.Message + "\nPresione cualquier tecla para volver al menú");}

            Console.ReadKey(); Console.Clear();
            
        }
        // Funcion para calcular cual es el elemento con mayor numero de likes
        private  Contenido MayorNumeroDeLikes()
        {
            Contenido aux = new Contenido();

            if (Contenidos != null)
            {
                // Ordenamos la lista de mayor a menor y guardamos el Contenido con más likes, si coinciden varios mostramos el ultimo que encuentre en la lista -> el más reciente
                for (int i = 0; i < Contenidos.Count; i++)
                {
                    // Buscamos el mayor
                    if (Contenidos[i].Get_NumeroLikes() > aux.Get_NumeroLikes())
                    {
                        aux = Contenidos[i];
                    }                    
                }
            }
            else
                Console.WriteLine("Lista de contenidos vacía");

            return aux;
        }

        // Funciones de comprobación
        // Esta función comprueba el tipo de contenido y lo devuleve como cadena de texto para poder mostrarlo
        private string ComprobarTipo(Contenido content)
        {
            string tipo = "";
            if (content is Pelicula)
                tipo = "Película";
            else if (content is Serie)
                tipo = "Serie";
            else if (content is Podcast)
                tipo = "Podcast";
            return tipo;
        }
        // Comprobamos que la temporada introducida sea una de las posibles
        private static bool ComprobarTemporada(int temporadas, int temporadaEpisodio)
        {
            bool ok = true;

            if (temporadas != -1 && temporadas < temporadaEpisodio) // SI la temporada esta fuera de rango y no es el valor de temporadas nula(para podcast -1)
            {
                ok = false;
                Console.WriteLine("No existe dicha temporadas para esta serie, introduce otra vez la temporada: ");
            }
            return ok;
        }
        // Comprobamos que el año introducido sea coherente
        private static bool ComprobarAñoValido(int año)
        {
            bool valido = true;
            if (año < 1895 || año > 2022)
            { // Si el año es menor que 1895 (año de la primera película estrenada) o mayor que el año actual
                Console.WriteLine("Año no valido, vuelva a introducirlo.");
                valido = false;
            }
            return valido;

        }
        // Función para comprobar que las opciones introducidas son validas
        private static bool ComprobarOpcion2(int valor)
        {
            bool valido = true;
            if (valor < 1 || valor > 2)
            {
                Console.WriteLine("Por favor, elija una opción entre las disponibles.");
                valido = false;
            }
            return valido;
        }
        // Funcion que se encarga de mirar si la fecha introducida para la caducidad es coherente o no
        private static bool ComprobarCaducidadValida(int año)
        {
            bool valido = true;
            // Si no introduce el valor de salida que es el 0, entonces comprueba que el año sea válido
            if (año != 0)
            { // Si el año es menor que 1895 (año de la primera película estrenada) o mayor que el año actual
                if (año < 2022 || año > 2040)
                {
                    Console.WriteLine("Año no valido, vuelva a introducirlo.");
                    valido = false;
                }
            }
            return valido;

        }
        // Comprobamos si el usuario que esta valorando contenido quiere valorar el contenido que el mismo incorporó
        private static bool ComprobarUsuarioValorando(Usuario u1, Usuario u2)
        {
            bool ok = true;
            if (u1 == u2)
            {
                Console.WriteLine("No puedes valorar el contenido que tú mismo has introducido. Vuelve a seleccionar una opción: ");
                ok = false;
            }
            return ok;
        }
        // Introducir una contraseña valida
        private bool ComprobarContraseña(string contraseña)
        {
            bool ok = true;

            if (contraseña.ToLower() == "esc")
            {
                Console.WriteLine("La contraseña introducida no puede ser una palabra reservada para una funcionalidad ('esc no válida')\nVuelva a intentarlo");
                ok = false;
            }
            else if (contraseña.Length < 8)
            {
                Console.WriteLine("La contraseña introducida tiene que tener mínimo 8 caracteres, vuelva a intentarlo");
                ok = false;
            }
            return ok;
        }
        // Comprobamos que no haya ningun usuario con el nombre que se quiere introducir
        private bool ComprobarNombreUsuario(string nombre)
        {
            bool ex = false;
            foreach (Usuario user in Usuarios)
            {
                if (nombre.ToLower() == user.Get_Nombre().ToLower())
                {
                    ex = true;
                    Console.WriteLine("Ya existe un usuario registrado con ese nombre, por favor introduzca uno nuevo.");
                }
            }
            return ex;
        }
        // Función para invertir el valor guardado en información que sea facil de entender por el usuario
        private int ComprobarEstado(string estado)
        {
            int est = 2;

            if (estado == "En emision")
                est = 1;

            return est;
        }
        // Funciones para invertir el valor guardado en información que sea facil de entender por el usuario
        private int ObtenerTipo(string tipos)
        {
            int tipo = 1;

            if (tipos == "Video")
                tipo = 2;

            return tipo;
        }
        private int ObtenerCaducidad(string caducidad)
        {
            int cad;

            if (caducidad == "Sin fecha límite")
                cad = 0;
            else
                cad = int.Parse(caducidad);

            return cad;
        }
    }

}
