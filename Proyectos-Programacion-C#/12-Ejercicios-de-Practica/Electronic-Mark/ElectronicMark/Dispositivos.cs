using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicMark
{
    public class Dispositivos
    {
        //Atributos
        protected string nombreDispositivo, modelo, nombreFabricante;
        protected int fecha, capacidad;
        //Constructores
        //Constructor vacío
        public Dispositivos() { }
        //Constructor parametrizado
        public Dispositivos(string nombreDispositivo, string modelo, string nombreFabricante, int fecha, int capacidad)
        {
            this.nombreDispositivo = nombreDispositivo;
            this.modelo = modelo;
            this.nombreFabricante = nombreFabricante;
            this.fecha = fecha;
            this.capacidad = capacidad;
        }
        //Mutadores y accesores
        public void SetNombreDispositivo(string nombreDispositivo)
        {
            this.nombreDispositivo = nombreDispositivo;
        }
        public string GetNombreDispositivo()
        {
            return nombreDispositivo;
        }
        public void SetModelo(string modelo)
        {
            this.modelo = modelo;
        }
        public string GetModelo()
        {
            return modelo;
        }
        public void SetNombreFabricante(string nombreFabricante)
        {
            this.nombreFabricante = nombreFabricante;
        }
        public string GetNombreFabricante()
        {
            return nombreFabricante;
        }
        public void SetFecha(int fecha)
        {
            this.fecha = fecha;
        }
        public int GetFecha()
        {
            return fecha;
        }
        public void SetCapacidad(int capacidad)
        {
            this.capacidad = capacidad;
        }
        public int GetCapacidad() 
        { 
            return capacidad;
        }
        //Métodos
        public virtual void PedirInfo()
        {

        }
        public virtual void MostrarInfo()
        {

        }
    }
}
