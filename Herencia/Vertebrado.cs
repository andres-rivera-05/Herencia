﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    internal class Vertebrado : Animal
    {
        public string? tipo;
        public bool? tienePatas;
        public bool? esDomestico;
        public bool? esHevivoro;
        public bool? esCarnivoro;

        public void imprimir()
        {
                Console.WriteLine("Nombre: " + nombre);
                Console.WriteLine("Color: " + color);
                Console.WriteLine("Tamañio: " + tamanio);
                Console.WriteLine("Familia: " + familia);
                Console.WriteLine("Tipo: " + tipo);
                Console.WriteLine("Tiene Patas: " + tienePatas);
                Console.WriteLine("Es Hervivoro: " + esHevivoro);
                Console.WriteLine("Es Domestico: " + esDomestico);
                Console.WriteLine("Es Carnicoro: " + esCarnivoro);
        }
    }
}
