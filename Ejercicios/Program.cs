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
            Console.ReadKey();

            //Primer Punto
            //var MayorMenor = proy.Where(x => x.Duracion > 6 && x.Duracion < 12).ToList();
            //project.ImprimirProyectos(MayorMenor);
            //Console.ReadLine();

            //Segundo Punto
            //var letra = from b in proy
            //            where (b.Nombre.StartsWith("B"))
            //            select b;
            //project.ImprimirProyectos(letra.ToList());
            //Console.ReadLine();

            //Tercer Punto
            //var multiplo = proy.Where(x=> x.Codigo %7 == 0).ToList();
            //project.ImprimirProyectos(multiplo);
            //Console.ReadLine();

            //Cuarto Punto 
            //Console.WriteLine("Proyectos con Duracion Inferior a 6");
            //var grupo1 = proy.Where(x => x.Duracion < 6).OrderBy(x => x.Duracion).ToList();
            //project.ImprimirProyectos(grupo1);

            //Console.WriteLine("Proyectos con duracion Mayor a 6 Pero Menor a 10");
            //var grupo2 = proy.Where(x => x.Duracion > 6 && x.Duracion < 10).OrderBy(x => x.Duracion).ToList();
            //project.ImprimirProyectos(grupo2);
            //Console.WriteLine("Proyectos con duracion Mayor a 10");
            //var grupo3 = proy.Where(x => x.Duracion > 10).OrderBy(x => x.Duracion).ToList();
            //project.ImprimirProyectos(grupo3);
            //Console.ReadLine();

            //Quinto Punto
            //var Promedio = proy.Average(x => x.Duracion);
            //Console.WriteLine("El promedio de la duracion de todos los proyectos es: " + Promedio);
            //Console.ReadLine();

            //Sexto Punto
            //var masDura = proy.Max(x => x.Duracion);
            //var sisa = proy.Where(x => x.Duracion == masDura).Select(x => x.Nombre).Max();
            //Console.WriteLine("La maxima duracion de los proyectos es: " + masDura);
            //Console.WriteLine("La nombre es: " + sisa);
            //Console.ReadLine();

            //Septimo Punto
            
            var mayorque = proy.Where(x => x.Duracion > 6).Select(x => x.Nombre + x.Area);
            Console.WriteLine("Nombre de Proyecto: " + mayorque);

            Console.ReadLine();

        }
            
    }
}
