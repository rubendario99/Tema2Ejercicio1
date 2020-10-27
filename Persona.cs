using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema2Ejercicio1
{
    abstract class Persona
    {
        public string Nombre { set; get; }
        public string Apellidos { set; get; }
        private int edad;
        public int Edad
        {
            set
            {
                if (value < 0)
                {
                    edad = 0;
                }
                else
                {
                    edad = value;
                }
            }
            get
            {
                return edad;
            }
        }
        public string DNI { set; get; }

        public Persona(string nombre, string apellidos, int edad, string dni)
        {
            Nombre = nombre;
            Apellidos = apellidos;
            Edad = edad;
            DNI = dni;
        }

        public Persona() : this("", "", 0, "")
        {
        }

        public virtual void mostrarCampos()
        {
            Console.WriteLine("Nombre: " + Nombre);
            Console.WriteLine("Apellidos: " + Apellidos);
            Console.WriteLine("Edad: " + Edad);
            Console.WriteLine("DNI: " + DNI);
        }

        public virtual void rellenarCampos()
        {
            Console.WriteLine("Introduce nombre");
            Nombre = Console.ReadLine();
            Console.WriteLine("Introduce apellidos");
            Apellidos = Console.ReadLine();
            Console.WriteLine("Introduce edad");
            Edad = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduce DNI");
            DNI = Console.ReadLine();
        }
        public abstract double hacienda();
    }
}
