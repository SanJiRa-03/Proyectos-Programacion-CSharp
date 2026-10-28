using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcesionariaVehiculos
{
    public class Camioneta : Vehículo
    {
        //Atributos
        private int tipoCaja;
        //Constructores
        //Constructor vacío
        public Camioneta() { }
        //Constructor parametrizado
        public Camioneta(string marca, string modelo, int año, int tipoCaja) : base(marca, modelo, año)
        {
            this.tipoCaja = tipoCaja;
        }
        public void SetTipoCaja(int tipoCaja)
        {
            this.tipoCaja = tipoCaja;
        }
        public int GetTipoCaja()
        {
            return this.tipoCaja;
        }
        public override void MostrarVehiculo()
        {
            Console.WriteLine("\n| CAMIONETAS |");          
            base.MostrarVehiculo();
            string nombreCaja = "";
            switch (GetTipoCaja())
            {
                case 1:
                    nombreCaja = "Caja abierta";
                    break;
                case 2:
                    nombreCaja = "Caja cerrada";
                    break;
                case 3:
                    nombreCaja = "Caja volquete";
                    break;
                case 4:
                    nombreCaja = "Caja refrigerada";
                    break;
                case 5:
                    nombreCaja = "Caja portacontenedores";
                    break;
            }
            Console.WriteLine("Tipo de caja: " + nombreCaja);
        }
        public override void AgregarVehiculo()
        {
            base.AgregarVehiculo();
            do
            {
                Console.WriteLine("Inserte el tipo de caja de la camioneta [1-5]: ");
                Console.WriteLine(" 1- Caja abierta\n 2- Caja cerrada\n 3- Caja volquete\n 4- Caja refrigerada\n 5- Caja portacontenedores");
                int tipoCaja = int.Parse(Console.ReadLine());
                this.tipoCaja = tipoCaja;
            } while (tipoCaja != 1 && tipoCaja != 2 && tipoCaja != 3 && tipoCaja != 4 && tipoCaja != 5);            
        }
    }
}
