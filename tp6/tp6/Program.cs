using System;

namespace tp6
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion, a, b;
            Console.Write("Ingresa un numero a invertir: ");
            int invertir = Convert.ToInt32(Console.ReadLine());

            while (invertir > 0){
                Console.Write(invertir % 10);
                invertir /= 10;
            }

            Console.WriteLine("Welcome!!\n");
            do{
                Console.WriteLine("Opciones");
                Console.WriteLine("1) Sumar.");
                Console.WriteLine("2) Restar.");
                Console.WriteLine("3) Multiplicar.");
                Console.WriteLine("4) Dividir.");
                Console.WriteLine("0) Salir.");
                opcion = Convert.ToInt32(Console.ReadLine());
                switch (opcion){
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                }
            }while(opcion!=0);
        }
    }
}
