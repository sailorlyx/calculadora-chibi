using System;
class calculadora
{
    static void Main()
    {
        double numerito1;
        Console.WriteLine("¡bienvenido a la mini calculadora! dime un numerito, porfi");
        numerito1 = Convert.ToDouble(
            Console.ReadLine());

        double numerito2;
        Console.WriteLine("dime otro numerito, porfi");
        numerito2 = Convert.ToDouble(
            Console.ReadLine());

        Console.WriteLine("¿qué operación te gustaría realizar");
        Console.WriteLine("pulsa 1 para suma");
        Console.WriteLine("pulsa 2 para resta");
        Console.WriteLine("pulsa 3 para multiplicación");
        Console.WriteLine("pulsa 4 para división");

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
    }
}