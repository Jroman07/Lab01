

using Laboratorio_1.Abstraccion;
using Laboratorio_1.Encapsulamiento;
using Laboratorio_1.Herencia;

Vehiculo carro = new Vehiculo();
carro.Consumo_Combustible();

Perro perrito = new Perro();
perrito.Comer();
perrito.Ladrar();

Empleado empleado = new Empleado(200000);
Console.WriteLine("El salario es: " + empleado._salario);