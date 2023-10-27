
using Herencia;

//instacia de objeto
Vertebrado vertebrado = new Vertebrado();
Vertebrado vertebradoDos = new Vertebrado();
Invertebrado invertebrado = new Invertebrado();
Invertebrado invertebradoDos = new Invertebrado();


vertebrado.nombre = "Gato";
vertebrado.color = "negro";
vertebrado.tamanio = "1 centimetro";
vertebrado.familia = "Aguacatero";
vertebrado.tipo = "mamifero";
vertebrado.tienePatas = true;   
vertebrado.esDomestico = true;
vertebrado.esHevivoro = false;  
vertebrado.esCarnivoro = true;

vertebrado.imprimir();

Console.WriteLine();

vertebrado.nombre = "Perro";
vertebradoDos.color = "cafe";
vertebradoDos.tamanio = "mediano";
vertebradoDos.familia = "Pastor Aleman";
vertebradoDos.tipo = "mamifero";
vertebradoDos.tienePatas = true;
vertebradoDos.esDomestico = true;
vertebradoDos.esHevivoro = false;
vertebradoDos.esCarnivoro = true;

vertebradoDos.imprimir();

Console.WriteLine();

invertebrado.nombre = "Abeja";
invertebrado.color = "negro con amarillo";
invertebrado.tamanio = "pequeña";
invertebrado.familia = "reina";
invertebrado.tipo = "isecto";
invertebrado.tienePatas = true;
invertebrado.tieneConcha = true;

invertebrado.imprimir();

Console.WriteLine();

invertebradoDos.nombre = "araña";
invertebradoDos.color = "negro";
invertebradoDos.tamanio = "grande";
invertebradoDos.familia = "Tarantula";
invertebradoDos.tipo = "isecto";
invertebradoDos.tienePatas = true;
invertebradoDos.tieneConcha = false;

invertebradoDos.imprimir();