using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_1.Polimorfismo
{
    internal class Trabajador_Ruta : ITrabajador
    {
        public int Id { get; set; }
        public int rutas_hechas { get; set; }
        public string nombre { get; set; }

        public double Salario()
        {
            return this.rutas_hechas * 30000; // Se establece 30 000 como precio por cada ruta hecha
        }
    }
}
