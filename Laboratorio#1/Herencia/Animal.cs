using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_1.Herencia
{
    public class Animal {
        public string reino { get; set; }
        public string clase { get; set; }
        public string orden { get; set; }
        public string familia { get; set; }
        public string genero { get; set; }
        public string years { get; set; }

        public void Comer() {
            Console.WriteLine("Esta comiendo!");
        }
        
        public void Reproduce() {
            Console.WriteLine("..");
        }


    }
}
