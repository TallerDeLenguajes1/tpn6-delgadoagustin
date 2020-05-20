using System;

namespace tp6
{
    class Program
    {
        static void Main(string[] args)
        {
            float opcion, a, b;
                       

            Console.WriteLine("\nCalculadora de Enteros\n");
            do{
                Console.Clear();
                Console.WriteLine("Opciones");
                Console.WriteLine("1) Sumar.");
                Console.WriteLine("2) Restar.");
                Console.WriteLine("3) Multiplicar.");
                Console.WriteLine("4) Dividir.");
                Console.WriteLine("5) Valor Absoluto de un numero.");
                Console.WriteLine("6) Cuadrado de un numero.");
                Console.WriteLine("7) Raiz cuadrada de un numero.");
                Console.WriteLine("8) Seno de un numero.");
                Console.WriteLine("9) Coseno de un numero.");
                Console.WriteLine("10) Invertir un numero.");
                Console.WriteLine("11) Parte entera de un real.");
                Console.WriteLine("12) Maximo entre dos valores.");
                Console.WriteLine("13) Minimo entre dos valores.");
                Console.Write("Opcion: ");
                opcion = Convert.ToSingle(Console.ReadLine());
                switch (opcion){
                    case 1:
                        Console.Write("Ingresa primer valor: ");
                        a = Convert.ToSingle(Console.ReadLine());
                        Console.Write("Ingresa segundo valor: ");
                        b = Convert.ToSingle(Console.ReadLine());
                        Console.WriteLine(a + b);
                        break;
                    case 2:
                        Console.Write("Ingresa primer valor: ");
                        a = Convert.ToSingle(Console.ReadLine());
                        Console.Write("Ingresa segundo valor: ");
                        b = Convert.ToSingle(Console.ReadLine());
                        Console.WriteLine(a - b);
                        break;
                    case 3:
                        Console.Write("Ingresa primer valor: ");
                        a = Convert.ToSingle(Console.ReadLine());
                        Console.Write("Ingresa segundo valor: ");
                        b = Convert.ToSingle(Console.ReadLine());
                        Console.WriteLine(a * b);
                        break;
                    case 4:
                        Console.Write("Ingresa dividendo: ");
                        a = Convert.ToSingle(Console.ReadLine());
                        Console.Write("Ingresa divisor(distinto de 0): ");
                        b = Convert.ToSingle(Console.ReadLine());
                        while (b == 0){
                            Console.WriteLine("No se puede dividir en cero.");
                            Console.Write("Ingresa divisor(distinto de 0): ");
                            b = Convert.ToSingle(Console.ReadLine());
                        }
                        Console.WriteLine(a / b);
                        break;
                    case 5:
                        Console.Write("Ingresa el valor: ");
                        a = Convert.ToSingle(Console.ReadLine());
                        a = Math.Abs(a);
                        Console.WriteLine(a);
                        break;
                    case 6:
                        Console.Write("Ingresa el valor: ");
                        a = Convert.ToSingle(Console.ReadLine());
                        a = Convert.ToSingle(Math.Pow(a,2));
                        Console.WriteLine(a);
                        break;
                    case 7:
                        Console.Write("Ingresa el valor: ");
                        a = Convert.ToSingle(Console.ReadLine());
                        a = Convert.ToSingle(Math.Sin(a));
                        Console.WriteLine(a);
                        break;
                    case 8:
                        Console.Write("Ingresa el valor: ");
                        a = Convert.ToSingle(Console.ReadLine());
                        a = Convert.ToSingle(Math.Cos(a));
                        Console.WriteLine(a);
                        break;
                    case 9:
                        Console.Write("Ingresa el valor: ");
                        a = Convert.ToSingle(Console.ReadLine());
                        a = Convert.ToSingle(Math.Cos(a));
                        Console.WriteLine(a);
                        break;
                    case 10:
                        Console.Write("Ingresa un numero a invertir: ");
                        int invertir = Convert.ToInt32(Console.ReadLine());

                        while (invertir > 0)
                        {
                            Console.Write(invertir % 10);
                            invertir /= 10;
                        }                       
                        break;
                    case 11:
                        Console.Write("Ingresa el valor: ");
                        a = Convert.ToSingle(Console.ReadLine());
                        a = Convert.ToSingle(Math.Truncate(a));
                        Console.WriteLine(a);
                        break;
                    case 12:
                        Console.Write("Ingresa primer valor: ");
                        a = Convert.ToSingle(Console.ReadLine());
                        Console.Write("Ingresa segundo valor: ");
                        b = Convert.ToSingle(Console.ReadLine());
                        Console.WriteLine("Maximo entre "+a+" y "+b+": "+Math.Max(a,b));
                        break;
                    case 13:
                        Console.Write("Ingresa primer valor: ");
                        a = Convert.ToSingle(Console.ReadLine());
                        Console.Write("Ingresa segundo valor: ");
                        b = Convert.ToSingle(Console.ReadLine());
                        Console.WriteLine("Minimo entre " + a + " y " + b + ": " + Math.Min(a, b));
                        break;                      
                }
                Console.Write("\nDesea Realizar otra operacion?(1=si/0=no): ");
                opcion = Convert.ToSingle(Console.ReadLine());
            } while(opcion!=0);
            Console.Clear();
            Console.Write("Ingresa una cadena de texto: ");
            string cadena1 = Console.ReadLine();
            Console.WriteLine("Longitud de "+cadena1+": "+cadena1.Length);
            Console.Write("Ingresa otra cadena de texto: ");
            string cadena2 = Console.ReadLine();
            Console.WriteLine("Concatenando " + cadena1 + " y " + cadena2 + ": " + String.Concat(cadena1,cadena2));
            Console.WriteLine("Desarmando "+cadena1);
            foreach (char letter in cadena1){
                Console.WriteLine(letter);
            }
            Console.Write("Ingresa cadena a buscar: ");
            string buscar = Console.ReadLine();
            if (cadena1.Contains(buscar)){
                Console.WriteLine("Encontrado");
            }
            else{
                Console.WriteLine(buscar+" no se encuentra en la cadena "+cadena1);
            }
            Console.WriteLine("En mayusculas: "+cadena1.ToUpper());
            Console.WriteLine("En minusculas: "+cadena1.ToLower());
            Console.Write("Ingresa una letra donde separar la cadena:");
            string separar = Console.ReadLine();
            string[] cadenas = cadena1.Split(separar);
            foreach (string c in cadenas){
                Console.WriteLine("Cadena separada: "+c);
            }
            Console.WriteLine("Presiona una tecla para continuar.");
            Console.ReadLine();
            Console.Clear();
            Console.Write("Ingresa una operacion simple como cadena: ");
            string operacion = Console.ReadLine();
            char[] separadores = { '+', '-', '*', '/' };
            decimal x, y;
            string[] elementos;
            if (operacion.Contains('+')){
                elementos = operacion.Split(separadores);
                x = Convert.ToDecimal(elementos[0]);
                y = Convert.ToDecimal(elementos[1]);
                Console.WriteLine(x + y);
                
            }
            else if (operacion.Contains('-')){
                elementos = operacion.Split(separadores);
                x = Convert.ToDecimal(elementos[0]);
                y = Convert.ToDecimal(elementos[1]);
                Console.WriteLine(x - y);
            }
            else if (operacion.Contains('*')){
                elementos = operacion.Split(separadores);
                x = Convert.ToDecimal(elementos[0]);
                y = Convert.ToDecimal(elementos[1]);
                Console.WriteLine(x * y);
            }
            else if (operacion.Contains('/')){
                elementos = operacion.Split(separadores);
                x = Convert.ToDecimal(elementos[0]);
                y = Convert.ToDecimal(elementos[1]);
                Console.WriteLine(x / y);
            }     
        }
    }
}
