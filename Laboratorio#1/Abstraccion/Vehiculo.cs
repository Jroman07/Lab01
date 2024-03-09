using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_1.Abstraccion
{
    public class Vehiculo: IVehiculo  {
        public int placa { get; set; }
        public int ruedas { get; set; }
        public int cilindraje { get; set; }
        public int modelo { get; set; }
        public string marca { get; set; }

        public void Consumo_Combustible()
        {
            Console.WriteLine("Consume mucho!!");
        }

        public void Transitar()
        {
            Console.WriteLine("Ha transitado 20km!!");
        }
    }
}
