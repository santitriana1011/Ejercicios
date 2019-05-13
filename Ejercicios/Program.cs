using System;
using System.Linq;

namespace Ejercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            Proyecto project = new Proyecto();
            project.proyectos = project.AgregarProyecto2();
            var proy = project.proyectos;
            project.ImprimirProyectos();
            Console.ReadKey();

            //Primer Punto
            var MayorMenor = proy.Where(x => x.Duracion > 6 && x.Duracion < 12).ToList();
        }
            
    }
}
