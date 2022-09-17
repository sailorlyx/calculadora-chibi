using System;
class calculadora
{
    static void Main() {
        Console.WriteLine("¿qué operación te gustaría realizar");
        Console.WriteLine("pulsa 1 para suma");
        Cconsole.WriteLine("pulsa 2 para resta");
        Console.WriteLine("pulsa 3 para multiplicación");
        Console.WriteLine("pulsa 4 para división");

        int suma;
        int resta;
        int multi;
        int division;

        int numerito1;
            Console.WriteLine("dime un numerito");
        numerito1 = Convert.ToInt32(
            Console.ReadLine());

        int numerito2;
            Console.WriteLine("dime otro numerito");
        numerito2 = ConvertToInt32(
            Console.ReadLine());

        int total = 0;

        switch {
            case 1:
                result = suma(numerito1+numerito2)
                break;

            case 2:
                    result = resta(numerito1 - numerito2)
                break;

            case 3:
                result = multi(numerito1*numerito2)
                break;

            case 4:
                result = division(numerito1/numerito2)
                break;
                }
          default:
            Console.WriteLine("no puedes dejar esto en blanco :(");
                break;
    }
           Console.WriteLine("el resultado de la operación es {0}", total);
            
}