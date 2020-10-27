using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema2Ejercicio1
{
    class Empleado : Persona
    {
        private double salario;
        private int irpf;
        public double Salario
        {
            set
            {
                salario = value;

                if (salario < 600)
                {
                    irpf = 7;
                }
                if (salario >= 600 && salario <= 3000)
                {
                    irpf = 15;
                }
                if (salario > 3000)
                {
                    irpf = 20;
                }
            }
            get
            {
                return salario;
            }
        }

        private string numTelefono;
        public string NumTelefono
        {
            set
            {
                numTelefono = value;
            }
            get
            {
                return "+34" + numTelefono;
            }
        }
        public Empleado(string nombre, string apellidos, int edad, string dni, double salario, string telefono) 
            : base(nombre, apellidos, edad, dni)
        {
            Salario = salario;
            NumTelefono = telefono;
        }
        public Empleado() : this("", "", 0, "", 0, "")
        {

        }
        public override void mostrarCampos()
        {
            base.mostrarCampos();
            Console.WriteLine("Salario: " + Salario);
            Console.WriteLine("IRPF: " + irpf + "%");
            Console.WriteLine("Teléfono: " + NumTelefono);
        }
        public void mostrarCampos(int n)
        {
            switch (n)
            {
                case 1:
                    Console.WriteLine("Nombre: " + Nombre);
                    break;
                case 2:
                    Console.WriteLine("Apellidos: " + Apellidos);
                    break;
                case 3:
                    Console.WriteLine("Edad: " + Edad);
                    break;
                case 4:
                    Console.WriteLine("DNI: " + DNI);
                    break;
                case 5:
                    Console.WriteLine("Salario: " + Salario);
                    break;
                case 6:
                    Console.WriteLine("IRPF: " + irpf);
                    break;
                case 7:
                    Console.WriteLine("Teléfono: " + NumTelefono);
                    break;
            }
        }
        public override double hacienda()
        {
            return irpf * salario / 100;
        }
    }
}