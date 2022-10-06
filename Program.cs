using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace chibicalcu
{
    public class Program
    {
        static string EjecutarCalculadora()
        {
            double numerito1 = PedirNumerito("¡bienvenido a la minicalculadora! dime un numerito porfi");

            double numerito2 = PedirNumerito("dime otro numerito, porfi");

            MenuCalculadora();

            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine("el total es " + (numerito1 + numerito2));
                    break;

                case "2":
                    Console.WriteLine("el total es " + (numerito1 - numerito2));
                    break;

                case "3":
                    Console.WriteLine("el total es " + (numerito1 * numerito2));
                    break;

                case "4":
                    Console.WriteLine("el total es " + (numerito1 / numerito2));
                    break;

                default:
                    Console.WriteLine("ha habido un error, intentalo de nuevo!");
                    break;
            }
            Console.WriteLine("¿te gustaría realizar otra operación? sip/nop");
            string seguir = Console.ReadLine();
            return seguir;
        }
        static void MenuCalculadora()
        {
            Console.WriteLine("¿qué operación te gustaría realizar");
            Console.WriteLine("pulsa 1 para suma");
            Console.WriteLine("pulsa 2 para resta");
            Console.WriteLine("pulsa 3 para multiplicación");
            Console.WriteLine("pulsa 4 para división");

        }

        public static double PedirNumerito(string peticion)
        {
            double numerito;
            Console.WriteLine(peticion);
            numerito = Convert.ToDouble(Console.ReadLine());
            return numerito;
        }
        static void Main(string[] args)
        {
            string seguir = "sip";

            while (seguir == "sip")
            {
                seguir = EjecutarCalculadora();
            }
        }
    }
}
