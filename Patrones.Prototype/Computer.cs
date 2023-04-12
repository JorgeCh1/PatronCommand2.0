using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones.Prototype
{
    public class Computer : ICloneable
    {
        public string Modelo { get; set; }
        public string Procesador { get; set; }
        public int Memory { get; set; }
        public int Almacenamiento { get; set; }


        public Computer(string modelo, string procesador, int memory, int almacenamiento)
        {
            Modelo = modelo;
            Procesador = procesador;
            Memory = memory;
            Almacenamiento = almacenamiento;
        }

        public object Clone()
        {
            return new Computer(Modelo, Procesador, Memory, Almacenamiento);
        }
    }
}
