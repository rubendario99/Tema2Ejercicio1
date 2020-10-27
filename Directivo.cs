using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema2Ejercicio1
{
    class Directivo : Persona, IPastaGansa
    {
        public string DepartamentoDirigido { set; get; }

        private double porcentajeBeneficios;
        public double PorcentajeBeneficios
        {
            set
            {
                porcentajeBeneficios = value;
                if (porcentajeBeneficios < 0)
                {
                    porcentajeBeneficios = 0;
                }
            }
            get
            {
                return porcentajeBeneficios;
            }
        }
        private int personasACargo;
        public int PersonasACargo
        {
            set
            {
                personasACargo = value;

                if (personasACargo < 10)
                {
                    PorcentajeBeneficios = 2;
                }
                else if (personasACargo < 50 && personasACargo > 10)
                {
                    PorcentajeBeneficios = 3.5;
                }
                else if (personasACargo > 50)
                {
                    PorcentajeBeneficios = 4;
                }
            }
            get
            {
                return personasACargo;
            }
        }
        public Directivo(string nombre, string apellidos, int edad, string dni, string departamentoDirigido,
            double porcentajeBeneficios, int PersonasACargo) : base(nombre, apellidos, edad, dni)
        {
            DepartamentoDirigido = departamentoDirigido;
            PorcentajeBeneficios = porcentajeBeneficios;
            PersonasACargo = personasACargo;
        }

        public Directivo() : this("", "", 0, "", "", 0, 0)
        {

        }
        public static Directivo operator --(Directivo directivo)
        {
            return new Directivo(directivo.Nombre, directivo.Apellidos, directivo.Edad, directivo.DNI, directivo.DepartamentoDirigido,
                directivo.PorcentajeBeneficios - 1, directivo.PersonasACargo);
        }

        public override void mostrarCampos()
        {
            base.mostrarCampos();
            Console.WriteLine("Departamento dirigido: {0}",DepartamentoDirigido);
            Console.WriteLine("Personas a cargo: {0}",PersonasACargo);
            Console.WriteLine("Porcentaje beneficios: {0}",PorcentajeBeneficios);
        }

        public override void rellenarCampos()
        {
            base.rellenarCampos();
            Console.WriteLine("Introduce departamento que dirige");
            DepartamentoDirigido = Console.ReadLine();
            Console.WriteLine("Introduce número de personas a cargo");
            PersonasACargo = int.Parse(Console.ReadLine());
        }
        public override double hacienda()
        {
            throw new NotImplementedException();
        }

        public double ganarPasta(double beneficios)
        {
            throw new NotImplementedException();
        }
    }
}
