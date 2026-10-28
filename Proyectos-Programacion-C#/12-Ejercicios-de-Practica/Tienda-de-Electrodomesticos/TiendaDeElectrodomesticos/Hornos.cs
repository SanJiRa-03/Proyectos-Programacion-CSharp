using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaDeElectrodomesticos
{
    public class Hornos : Electrodomésticos
    {
        //Atributos        
        private int autolimpiado;
        //Constructores
        //Constructor vacío
        public Hornos() { }
        //Constructor parametrizado
        public Hornos(string marca, string modelo, int año, string energia, bool fabricado, int autolimpiado) : base(marca, modelo, año, energia, fabricado)
        {
            this.autolimpiado = autolimpiado;
        }
        //Mutadores y accesores
        public void SetAutolimpiado(int autolimpiado)
        {
            this.autolimpiado = autolimpiado;
        }
        public int GetAutolimpiado()
        {
            return autolimpiado;
        }
        //Métodos
        public string UltGeneracion(string energia, int autolimpiado, int año)
        {
            string generacion;
            if (energia == "s" && autolimpiado == 1 && año >= 2019)
            {
                generacion = "sí";
            }
            else
            {
                generacion = "no";
            }
            return generacion;
        }
        public override void PedirInfo()
        {
            base.PedirInfo();
            Console.WriteLine("¿Tiene autolimpiado? (1- Sí 2- No)");
            int autolimpiado = int.Parse(Console.ReadLine());

            this.autolimpiado = autolimpiado;
        }
        public override void MostrarInfo()
        {
            Console.WriteLine("| Hornos |");
            base.MostrarInfo();
            Console.WriteLine("Número de programas: " + GetAutolimpiado());
            Console.WriteLine("Última generación: " + UltGeneracion(energia, autolimpiado, año));
        }
    }
}
