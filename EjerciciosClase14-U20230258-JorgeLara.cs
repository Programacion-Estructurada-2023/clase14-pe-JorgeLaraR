using System;

namespace MyApp// Note: actual namespace depends on the project name.
{
    internal class Program
    {
         static void Main(string[] args)
        {
            //Declarar una variable int para opciones.

            int opciones;

            do
            {
                Console.WriteLine("\n\nMenú:");
                Console.WriteLine("1.Programa que muestre que sume los números pares hasta el 75");
                Console.WriteLine("2.Programa que muestre  el recorrido de una lista de 9 números enteros y que encuentre el número más grande");
                Console.WriteLine("3.Programa que muestre la representación de una tabla de multiplicar de un numero n, del 1 al 12 y que al valor de “n x i” le sume 2");
                Console.WriteLine("4. Salir");
                Console.WriteLine("Selecciones una opción {1-4}: ");

                if (int.TryParse(Console.ReadLine(), out opciones))
                {
                    switch (opciones)
                    {
                        case 1:
                            int sumados = 0;
                            for (int i =2; i <=75; i+=2)
                            {
                                sumados += i;  
                            }

                            Console.WriteLine($"Los numeros pares sumados hasta 75 son = {sumados}");

                            break;
                        case 2:

                            List<int> numerosgrandes = new List<int> {23,45,2,4,56,9,7,26,38};

                            int maximo = numerosgrandes[0]; 

                            foreach (int numerolista in numerosgrandes)
                            {
                                if(numerolista > maximo)
                                {
                                    maximo = numerolista; 
                                }
                            }

                            Console.WriteLine("El numero mas grande en la lista es > " + maximo);

                            break;
                        case 3:
                            Console.WriteLine("\nIngrese un numero para elaborar su tabla de multiplicar ");
                            int numero=Convert.ToInt32(Console.ReadLine());

                            for (int i = 1; i <=12; i++)
                            {
                                
                                int multiplicacion = numero * i;

                                Console.WriteLine($"{numero} x {i} = {multiplicacion}");

                                int multiplicacion2 = numero * i + 2;

                                Console.WriteLine($"{numero} x {i} = {multiplicacion2}");


                            }

                            break;
                        case 4:

                            break;
                        default:
                            Console.WriteLine("Opción no válida. Por favor, seleccione una opción válida.");
                            break;
                    }

                }
                else{
                    Console.WriteLine("\nEntrada no válida. Debe ingresar un número {1-4}.");
                }

            }while (opciones !=4);
        }
    }
}