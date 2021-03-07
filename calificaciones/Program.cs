using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calificaciones
{
    class Program
    {
        static void Main(string[] args)
        {
            int examen; 
            int habilidades; 
            int emprendedores; 
            int actitud;
            int calexamen;
            int calhabilidades;
            int calemprendedores;
            int calactitud;
            double resexamen;
            double reshabilidades;
            double resemprendedores;
            double resactitud;
            double profinal;


            examen = 30;
            habilidades = 30;
            emprendedores = 20;
            actitud = 20;



            Console.WriteLine("Escribe el valor del rubro examen: ");
            calexamen = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Escribe el valor del rubro habilidades: ");
            calhabilidades = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Escribe el valor del rubro emprendedores: ");
            calemprendedores = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Escribe el valor del rubro actitud: ");
            calactitud = Convert.ToInt32(Console.ReadLine());



            resexamen = (calexamen * examen) / 100;
            reshabilidades = (calhabilidades * habilidades ) / 100;
            resemprendedores = (calemprendedores * emprendedores ) / 100;
            resactitud = (calactitud * actitud ) / 100;


            profinal = resexamen + reshabilidades + resemprendedores + resactitud;

            Console.WriteLine("El valor del promedio es: " + profinal);


            if (profinal >= 70)
                Console.WriteLine("Estas aprobado.");
            else
                Console.WriteLine("No estas aprobado.");


            Console.ReadKey();
        }   
    }
}
