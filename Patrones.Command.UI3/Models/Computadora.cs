using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Patrones.Command.UI3.Models
{
    //EN ESTA INTERFFAZ GENÉRICA SE DEFINE UN ÚNICO MÉTODO CLONAR()
    public interface IClonable<T>
    {
        T Clonar();
    }

    //EN LA CLASE COMPUTADORA AGREGAMOS LAS PROPIEDADES QUE REPRESENTAN UNA COMPUTADORA, ADEMAS
    //DE IMPLEMENTAR LA INTERFAZ IClonable<Computadora>
    public class Computadora : IClonable<Computadora>
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int MemoriaRAM { get; set; }
        public int Almacenamiento { get; set; }


        //ESTA CLASE TIENE DOS CONSTRUCTORES UNO SIN PARAMETROS QUE ES NECESARIO PARA EL ENLACE DE MODELOS
        //EN ASP.NET MVC FUNCIONE Y EL CONSTRUCTOR CON PARAMETROS ES PARA CREAR UNA INSTANCIA DE LA CLASE
        //COMPUTADORA.
        public Computadora()
        {
        }

        // Constructor con parámetros (si es necesario)
        public Computadora(string marca, string modelo, int memoriaRAM, int almacenamiento)
        {
            Marca = marca;
            Modelo = modelo;
            MemoriaRAM = memoriaRAM;
            Almacenamiento = almacenamiento;
        }
        //ESTE METODO IMPLEMENTA EL METODO CLONAR DEFINIDO POR LA INTERFAZ ICLONABLE<COMPUTADORA>
        //CREA UNA NUEVA INSTANCIA DE LA CLASE COMPUTADORA Y COPIA LAS PROPIEDADES DEL OBJETO ACTUAL AL
        //OBJETO CLONADO SIN AFECTAR AL ORIGINAL
        public Computadora Clonar()
        {
            return new Computadora(Marca, Modelo, MemoriaRAM, Almacenamiento);
        }
    }
}