using System.Collections.Specialized;

namespace Ejercicio105
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un día de la semana que no sea Lunes: ");
            String opcion = Console.ReadLine;
            String dia;
            switch (opcion)
            {
                case "Martes":
                    Console.WriteLine("Has elegido Martes");
                    dia = opcion;
                    break;
                case "Miércoles":
                    Console.WriteLine("Has elegido Miércoles");
                    dia = opcion;
                    break; 
                case "Jueves":
                    Console.WriteLine("Has elegido Jueves");
                    dia = opcion;
                    break;
                case "Viernes":
                    Console.WriteLine("Has elegido Viernes");
                    dia = opcion;
                    break;
                case "Sábado":
                    Console.WriteLine("Has elegido Sábado");
                    dia = opcion;
                    break;
                case "Domingo":
                    Console.WriteLine("Has elegido Domingo");
                    dia = opcion;
                    break;
                default:
                    Console.WriteLine("El día ingresado no es válido.");
            }
        }
    }
}
