using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_1.Encapsulamiento
{
    public class Empleado {
        private double salario;

        public double _salario
        {
            get { return salario; }
            set { salario = value;}
        }

        public Empleado(double _Salario)
        {
            this.salario = _Salario;
        }
    }
}
