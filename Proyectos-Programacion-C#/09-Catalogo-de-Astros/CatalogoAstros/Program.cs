using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CatalogoAstros;
//FALTAN LOS CASOS DE ERROR.
namespace CatalogoAstros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Creamos tres listas para cada uno de los astros.
            List<Estrella> es = new List<Estrella>();
            List<Cometa> co = new List<Cometa>();
            List<Planeta> pl = new List<Planeta>();
            //Definimos cuáles son las variables.
             int salida = 0;
             string opcion;
             string opcion2 = " ";
             string nombre;
             float diametro;
             float X;
             float Y;
             float Z;
        //------------------------------------
            int planetas;
             float temperatura = 0;
             string busca;
             int anio;
             string nombreestrella;
             int periodo;
             float inclinacion;
             bool habitable;
             //El menú lo creamos usando un while en el que mientras salida sea = 0, se ejecute.             
                while (salida == 0)
                {
                //Creamos un menú con las distintas opciones para elegir.                    
                    Console.WriteLine();
                    Console.WriteLine("Elige una opcion: \n* * * Estrellas --> (estrellas) * * *\n* * * Cometas   --> (cometas) * * *\n* * * Planetas  --> (planetas) * * *\n-Salir --> (salir)");
                    opcion = Console.ReadLine();
                //Si la opción elegida es distinta de salir, se ejecutarán las clases a continuación.
                    if (opcion != "salir")
                    {
                        Console.WriteLine("\nElige una clase:\n-Crear(crear)\n-Mostrar(mostrar)\n-Buscar(buscar)\n-Salir(salir)");
                        opcion2 = Console.ReadLine();

                    if (opcion2 != "salir")
                    {
                //Como hemos mencionado anteriormente, si la opción es distinta de "salir", se ejecutan los diferentes casos posibles (estrellas --> caso 1,
                //cometas --> caso 2 y planetas --> caso 3.)
                        Console.Clear();
                        switch (opcion)
                        {
                            case "estrellas":
                                {
                                //Opción "crear" para generar un nuevo astro.
                                    if (opcion2 == "crear")
                                    {
                                //Le preguntamos los datos del astro al usuario que se muestran por consola.
                                //Las variables de tipo string tendrán la estructura: x = Console.WriteLine("");. Mientras que las de tipo int/float serán:
                                //x = float.Parse(Console.ReadLine()); ya que transformamos la variable a int/float según corresponda.
                                        Console.WriteLine("Escriba el nombre: ");
                                        nombre = Console.ReadLine();
                                        Console.WriteLine("Escriba el diametro: ");
                                        diametro = float.Parse(Console.ReadLine());
                                        Console.WriteLine("Escriba la posicion (X, Y, Z): ");
                                        X = float.Parse(Console.ReadLine());
                                        Y = float.Parse(Console.ReadLine());
                                        Z = float.Parse(Console.ReadLine());
                                        Console.WriteLine("Escriba el numero de planetas que le orbitan: ");
                                        planetas = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Escriba la temperatura: ");
                                        temperatura = float.Parse(Console.ReadLine());
                                //El siguiente comando lo que hace es añadir una nueva estrella a la lista con los atributos que corresponden (planetas que
                                //orbitan, temperatura de la estrella, nombre, diámetro, y la posición marcada en X,Y y Z.)
                                        es.Add(new Estrella(planetas, temperatura, nombre, diametro, X, Y, Z));
                                        Console.Clear();
                                    }
                                //Opción "mostrar" para enseñarle al usuario todos los astros creados con anterioridad.
                                    else if (opcion2 == "mostrar")
                                    {
                                //El comando foreach sirve para recuperar la informacion de colecciones, arrays o listas, es decir objetos que pueden contener mas
                                //de un valor almacenado.
                                        foreach (Estrella estrella in es)
                                        {
                                //Imprimimos los datos indicando por código dónde se encuentra cada uno.
                                            Console.WriteLine($"-------------------------\n\n Nombre: {estrella.Nombre}\n Diametro: {estrella.Diametro}\n (Posicion X, Y, Z): ({estrella.X}, {estrella.Y}, {estrella.Z})\n Planetas: {estrella.Planetas}\n Tipo segun temperatura: {estrella.tipo_de_estrella(estrella.Temperatura)}\n");
                                        }
                                        Console.WriteLine("-------------------------\n");

                                    }
                                //Lo mismo ocurre con "buscar",que "rastrea" el astro según el nombre que se introduzca.
                                    else if (opcion2 == "buscar")
                                    {
                                        Console.WriteLine("Escriba el nombre del astro que quiere buscar.");
                                        busca = Console.ReadLine();
                                        foreach (Estrella estrella in es)
                                        {
                                            if (busca == estrella.Nombre)
                                            {
                                                Console.WriteLine($"-------------------------\n\n Nombre: {estrella.Nombre}\n Diametro: {estrella.Diametro}\n (Posicion X, Y, Z): ({estrella.X}, {estrella.Y}, {estrella.Z})\n Planetas: {estrella.Planetas}\n Tipo segun temperatura: {estrella.tipo_de_estrella(estrella.Temperatura)} {estrella.Temperatura}º\n\n------------------------- ");
                                            }
                                        }
                                    }
                                    else
                                //Si la opción intriducida no coincide con ninguna de las anteriores el programa imprime en pantalla lo siguiente:
                                        Console.WriteLine("Opcion no valida\n");
                                    break;
                                }
                                //Lo mismo ocurre con el resto de astros.
                            case "cometas":
                                {
                                    if (opcion2 == "crear")
                                    {
                                        Console.WriteLine("Escriba el nombre: ");
                                        nombre = Console.ReadLine();
                                        Console.WriteLine("Escriba el diametro: ");
                                        diametro = float.Parse(Console.ReadLine());
                                        Console.WriteLine("Escriba la posicion (X, Y, Z): ");
                                        X = float.Parse(Console.ReadLine());
                                        Y = float.Parse(Console.ReadLine());
                                        Z = float.Parse(Console.ReadLine());
                                        Console.WriteLine("Escriba el año de avistamiento: ");
                                        anio = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Escriba el nombre de la estrella que orbita: ");
                                        nombreestrella = Console.ReadLine();
                                        Console.WriteLine("Escriba el periodo orbital del astro: ");
                                        periodo = int.Parse(Console.ReadLine());

                                        co.Add(new Cometa(anio, nombreestrella, nombre, periodo, diametro, X, Y, Z));
                                        Console.Clear();
                                    }
                                    else if (opcion2 == "mostrar")
                                    {
                                        foreach (Cometa cometa in co)
                                        {

                                            Console.WriteLine($"-------------------------\n\n Nombre: {cometa.Nombre}\n Diametro: {cometa.Diametro}\n (Posicion X, Y, Z): ({cometa.X}, {cometa.Y}, {cometa.Z})\n Anio de avistamiento: {cometa.Anio}\n Nombre de estrella a la que orbita: {cometa.Nombreestrella}\n Periodo: {cometa.Periodo}\n");
                                        }
                                        Console.WriteLine("-------------------------\n");

                                    }
                                    else if (opcion2 == "buscar")
                                    {
                                        Console.WriteLine("Escriba el nombre del astro que quiere buscar.");
                                        busca = Console.ReadLine();
                                        foreach (Cometa cometa in co)
                                        {
                                            if (busca == cometa.Nombre)
                                            {
                                                Console.WriteLine($"-------------------------\n\n Nombre: {cometa.Nombre}\n Diametro: {cometa.Diametro}\n (Posicion X, Y, Z): ({cometa.X}, {cometa.Y}, {cometa.Z})\n Anio de avistamiento: {cometa.Anio}\n Nombre de estrella a la que orbita: {cometa.Nombreestrella}\n Periodo: {cometa.Periodo}\n\n------------------------- ");
                                            }
                                        }
                                    }
                                    else
                                        Console.WriteLine("Opcion no valida\n");
                                    break;
                                }
                            case "planetas":
                                {
                                //Creamos la variable de tipo string hab (habitable), si es "si" o "no".
                                    string hab;
                                    if (opcion2 == "crear")
                                    {
                                        Console.WriteLine("Escriba el nombre: ");
                                        nombre = Console.ReadLine();
                                        Console.WriteLine("Escriba el diametro: ");
                                        diametro = float.Parse(Console.ReadLine());
                                        Console.WriteLine("Escriba la posicion (X, Y, Z): ");
                                        X = float.Parse(Console.ReadLine());
                                        Y = float.Parse(Console.ReadLine());
                                        Z = float.Parse(Console.ReadLine());
                                        Console.WriteLine("Escriba el periodo de rotacion (en horas): ");
                                        periodo = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Escriba la inclinacion en grados (entre 0 y 180): ");
                                        inclinacion = float.Parse(Console.ReadLine());
                                //La inclinación debe cumplir las siguientes condiciones: 
                                //Debe de estar entre oº y 180º, si se pasa de ese rango, se imprime 0 o 180 de cualquier manera (forzando a que se encuentre
                                //en el rango establecido).
                                        if (inclinacion < 0)
                                        {
                                            inclinacion = 0;
                                        }
                                        else if (inclinacion > 180)
                                        {
                                            inclinacion = 180;
                                        }
                                        Console.WriteLine("¿Es habitable? (si/no)");
                                        hab = Console.ReadLine();
                                //Si la respuesta del usuario es "si", habitable, que es de tipo bool, será true, si por el contrario es "no", será false.
                                        if (hab == "si")
                                        {
                                            habitable = true;
                                        }
                                        else
                                        {
                                            habitable = false;
                                        }
                                        pl.Add(new Planeta(periodo, inclinacion, habitable, nombre, diametro, X, Y, Z));
                                //Console.Clear(); --> Para eliminar todo el contenido anterior y "limpiar" la consola.
                                        Console.Clear();
                                    }
                                    else if (opcion2 == "mostrar")
                                    {
                                        foreach (Planeta planeta in pl)
                                        {

                                            Console.WriteLine($"-------------------------\n\n Nombre: {planeta.Nombre}\n Diametro: {planeta.Diametro}\n (Posicion X, Y, Z): ({planeta.X}, {planeta.Y}, {planeta.Z})\n Periodo de rotacion(en horas): {planeta.Periodo}\n Inclinacion en grados(entre 0 y 180): {planeta.Inclinacion}\n Habitable: {planeta.Hab(planeta.Habitable)}\n");
                                        }
                                        Console.WriteLine("-------------------------\n");

                                    }
                                    else if (opcion2 == "buscar")
                                    {
                                        Console.WriteLine("Escriba el nombre del astro que quiere buscar.");
                                        busca = Console.ReadLine();
                                        foreach (Planeta planeta in pl)
                                        {
                                            if (busca == planeta.Nombre)
                                            {
                                                Console.WriteLine($"-------------------------\n\n Nombre: {planeta.Nombre}\n Diametro: {planeta.Diametro}\n (Posicion X, Y, Z): ({planeta.X}, {planeta.Y}, {planeta.Z})\n Periodo de rotacion(en horas): {planeta.Periodo}\n Inclinacion en grados(entre 0 y 180): {planeta.Inclinacion}\n Habitable: {planeta.Hab(planeta.Habitable)}\n\n------------------------- ");
                                            }
                                        }
                                    }
                                    else
                                        Console.WriteLine("Opcion no valida\n");
                                    break;
                                }
                            case "salir":
                                {
                                    salida = 1;
                                    break;
                                }
                            default:
                                {
                                    Console.WriteLine("Opcion no valida\n");
                                    break;
                                }
                        }
                    }
                   }
                    else
                        salida = 1;
                }
            }
        }
    }
