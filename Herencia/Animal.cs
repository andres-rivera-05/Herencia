using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    internal class Animal
    {
        public string? nombre;
        public string? color;
        public string? tamanio;
        public string? familia;

        //Metodo para imprimir datos
        public void imprimir()
        {
            if (validar())
            {
                Console.WriteLine("Nombre: " + nombre);
                Console.WriteLine("Color: " + color);
                Console.WriteLine("Tamañio: " + tamanio);
                Console.WriteLine("Familia: " + familia);
            }
            else {
                Console.WriteLine("Los campos no estan completos");
            }
        }

        //Metodos para validar los datos
        public bool validar() {
            if (nombre != null && color != null && tamanio != null && familia != null)
            {
                return true;
            }
            else {
                return false;
            }
        }  
    }
}
