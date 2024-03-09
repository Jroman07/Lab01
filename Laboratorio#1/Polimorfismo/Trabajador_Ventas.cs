using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_1.Polimorfismo
{
    public class Trabajador_Ventas : ITrabajador
    {
        public int Id { get; set; }
        public int ventas_realizadas { get; set; }

        public double Salario()
        {
            return this.ventas_realizadas*10000; // Se establece en 10 000 la tarifa por venta realizada
        }
    }
}
