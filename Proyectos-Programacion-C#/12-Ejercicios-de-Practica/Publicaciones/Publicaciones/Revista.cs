using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Publicaciones
{
    public class Revista : Publicacion
    {
        //Atributos
        private int tipo, tirada;        
        //Constructores
        //Constructor vacío
        public Revista() { }
        //Constructor parametrizado
        public Revista(string titulo, string editorial, int paginas, int tipo, int tirada) : base(titulo, editorial, paginas)
        {
            this.tipo = tipo;
            this.tirada = tirada;
        }
        //Mutadoers y accesores
        public void SetTipo(int tipo)
        {
            this.tipo = tipo;
        }
        public int GetTipo()
        {
            return tipo;
        }
        public void SetTirada(int tirada)
        {
            this.tirada = tirada;
        }
        public int GetTirada()
        {
            return tirada;
        }
        //Métodos
        public override void PedirInfo()
        {
            //Variables
            int tipo;
            Console.WriteLine("Insertando revista...\n");
            base.PedirInfo();
            do
            {
                Console.WriteLine("Inserta el tipo de revista: ");
                Console.WriteLine("1. Noticias\n2. Estilo de vida\n3. Interés general\n4. Especializada\n5. Científica");
                tipo = int.Parse(Console.ReadLine());
                if (tipo != 1 && tipo != 2 && tipo != 3 && tipo != 4 && tipo != 5)
                {
                    Console.WriteLine("Inserta un valor válido [1-5]");
                }
            } while (tipo != 1 && tipo != 2 && tipo != 3 && tipo != 4 && tipo != 5);           
            Console.WriteLine("Inserta la tirada de la revista: ");
            int tirada = int.Parse(Console.ReadLine());

            this.tipo = tipo;
            this.tirada = tirada;
        }
        public override void MostrarInfo()
        {
            Console.WriteLine("|REVISTAS|");
            base.MostrarInfo();            
            Console.WriteLine("- Tipo de revista: " + Tipo(tipo));
            Console.WriteLine("- Tirada: " + GetTirada() + "\n");
        }
        public string Tipo(int tipo)
        {
            string respuesta = "";
            switch (tipo)
            {
                case 1:
                    respuesta = "Noticias";
                    break;
                case 2:
                    respuesta = "Estilo de vida";
                    break;
                case 3:
                    respuesta = "Interés general";
                    break;
                case 4:
                    respuesta = "Especializada";
                    break;
                case 5:
                    respuesta = "Científica";
                    break;
            }
            return respuesta;
        }
    }
}
