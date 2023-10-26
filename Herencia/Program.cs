
using Herencia;

//instacia de objeto
Vertebrado vertebrado = new Vertebrado();
Vertebrado vertebradoDos = new Vertebrado();

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



