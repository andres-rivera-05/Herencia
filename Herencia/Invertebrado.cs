﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    internal class Invertebrado : Animal
    {
        public string? tipo;
        public bool? tienePatas;
        public bool? numeroPatas;
        public bool? tieneConcha;


        public void imprimir() { 

            Console.WriteLine("Nombre: " + nombre);
            Console.WriteLine("Color: " + color);
            Console.WriteLine("Tamaño: " + tamanio);
            Console.WriteLine("Familia: " + familia);
            Console.WriteLine("Tipo: " + tipo);
            Console.WriteLine("Tiene Patas: " + tienePatas);
            Console.WriteLine("Numero de patas: " + numeroPatas);
            Console.WriteLine("Tiene Concha: " + tieneConcha);

        }
    }
}
