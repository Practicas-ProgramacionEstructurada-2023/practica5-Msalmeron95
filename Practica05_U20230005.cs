using System;

namespace MyApp// Note: actual namespace depends on the project name.
{
    internal class Program
    {
         static void Main(string[] args)
        {
            Console.WriteLine("\n********Calculadora de promedio universitario********");

            //Solicitando al estudiante que ingrese las notas del primer computo
            Console.WriteLine("\nIngrese la primer nota del primer computo: ");
            Console.WriteLine("Ingrese la nota del Laboratorio 1: ");
            double Lab1 = Convert.ToDouble(Console.ReadLine());

            //Ingresar la nota del parcial 1
            Console.WriteLine("\nIngrese la nota del Parcial 1: ");
            double Parc1 = Convert.ToDouble(Console.ReadLine()); 


            //Solicitando al estudiante que ingrese las notas del segundo computo
            Console.WriteLine("\nIngrese la primer nota del segundo computo: ");
            Console.WriteLine("Ingrese la nota del Laboratorio 2: ");
            double Lab2 = Convert.ToDouble(Console.ReadLine());

            //Ingresar la nota del parcial 2
            Console.WriteLine("\nIngrese la nota del Parcial 2: ");
            double Parc2 = Convert.ToDouble(Console.ReadLine()); 

            //Solicitando al estudiante que ingrese las notas del tercer computo
            Console.WriteLine("\nIngrese la primer nota del tercer computo: ");
            Console.WriteLine("Ingrese la nota del Laboratorio 3: ");
            double Lab3 = Convert.ToDouble(Console.ReadLine());

            //Ingresar la nota del parcial 3
            Console.WriteLine("\nIngrese la nota del Parcial 3: ");
            double Parc3 = Convert.ToDouble(Console.ReadLine());    

            //Calcular el promedio 
            double promedioLab = (Lab1 + Lab2 + Lab3) * 0.6;
            double promedioParc = (Parc1 + Parc2 + Parc3) * 0.40;
            double notafinal = (promedioLab / 3) + (promedioParc / 3);

            //Aproximando la nota a un entero con 1 decimal
            double rounfinalgrade = Math.Round(notafinal, 1);

            //Mostrar la nota final
            Console.WriteLine("\nSu nota final fue: " + rounfinalgrade);

            //Comparar el promedio de las notal final
            if (rounfinalgrade < 6)
            {
                Console.WriteLine("Nota menor a 5 su nota es: " + rounfinalgrade + " por lo tanto ha reprobado la materia...");
            }
            else if(rounfinalgrade == 6)
            {
                Console.WriteLine("Su nota es exactamente la nota minma para pasar la materia, su nota es: " + rounfinalgrade);
            }
            else if(rounfinalgrade > 6 & rounfinalgrade <=10)
            {
                Console.WriteLine("Su nota es mayor a 6, su nota es: " + rounfinalgrade + " usted paso la materia");
            }
            else
            {
                Console.WriteLine("Sus notas ingresadas son mayores de 10 ingresarlas nuevamente");
            }

            Console.ReadKey();
        }
    }
}