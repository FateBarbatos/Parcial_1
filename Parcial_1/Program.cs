using System;
using System.Collections;

namespace Parcial_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int validador = 0;

            do
            {
                Console.WriteLine("Ingrese el numero de estudiantes a evaluar");
                int numEstudia = int.Parse(Console.ReadLine());
                int contador = 0;
                ArrayList lista = new ArrayList();
                string nombre;
                double lab1;
                double lab2;
                double parc;

                while (contador < numEstudia)
                {
                    Console.WriteLine("Ingrese el nombre completo del estudiante:");
                    nombre = Console.ReadLine();
                    Console.WriteLine("Ingrese la nota del laboratorio 1");
                    lab1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese la nota del laboratorio 2");
                    lab2 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese la nota del examen parcial");
                    parc = double.Parse(Console.ReadLine());

                    double notaFinal = NotaFinal(lab1, lab2, parc);
                    string apr = Aprob(notaFinal); 


                    Estudiantes estudiantes = new Estudiantes { Nombre = nombre, NotaFinal = notaFinal, Aprob = apr};
                    lista.Add(estudiantes);

                    contador++;
                }

                foreach(Estudiantes st in lista)
                {
                    Console.WriteLine(st.getData());
                }

                Console.WriteLine("");
                Console.WriteLine("Si desea ingresar nuevos datos de estudiantes,digite cero y de click en enter");
                validador = int.Parse(Console.ReadLine());
            } while (validador == 0);

            //funciones
            static double NotaFinal(double Lab1,double Lab2,double Parc)
            {
                double notaFinal = (Lab1 * 0.3) + (Lab2 * 0.3) + (Parc * 0.4);
                return notaFinal;
            }

            static string Aprob(double NotaFinal)
            {
                if(NotaFinal > 6)
                {
                    return "aprobado";
                }
                else
                {
                    return "reprobado";
                }
            }

        }
    }
}

public class Estudiantes
{
    private string _nombre;
    private double _notaFinal;
    private string _aprobo;

    public string Nombre
    {
        get => _nombre;
        set => _nombre = value;
    }
    
    public double NotaFinal
    {
        get => _notaFinal;
        set => _notaFinal = value;
    }

    public string Aprob
    {
        get => _aprobo;
        set => _aprobo = value;
    }

    public string getData()
    {
        return "El nombre es:" + _nombre + " ,la nota final es: " + _notaFinal + " ,por lo tanto el estudiante esta:" + Aprob;
    }
}