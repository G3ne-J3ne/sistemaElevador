using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_elevador_1378524
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
   
                bool elevadorLibre = true;
                string opcion;
                bool salir = false;

                while (!salir)
                {
                    if (elevadorLibre)
                    {
                        Console.Clear();
                        Console.WriteLine("=== SISTEMA ELEVADOR ===");
                        Console.WriteLine("El elevador se encuentra LIBRE");
                        Console.WriteLine("\nOpciones:");
                        Console.WriteLine("0 - Llamar elevador");
                        Console.WriteLine("1 - Salir del programa");
                        Console.Write("\nSeleccione una opción: ");

                        opcion = Console.ReadLine();

                        if (opcion == "0")
                        {
                            elevadorLibre = false;
                            Console.WriteLine("\nLlamando elevador...");
                            Console.WriteLine("Presione cualquier tecla para continuar");
                            Console.ReadKey();
                        }
                        else if (opcion == "1")
                        {
                            salir = true;
                        }
                        else
                        {
                            Console.WriteLine("\nOpción no válida. Presione cualquier tecla para continuar");
                            Console.ReadKey();
                        }
                    }
                    else 
                    {
                        Console.Clear();
                        Console.WriteLine("=== SISTEMA ELEVADOR ===");
                        Console.WriteLine("El elevador se encuentra OCUPADO");
                        Console.WriteLine("\nOpciones:");
                        Console.WriteLine("false - Llamar elevador (no disponible)");
                        Console.WriteLine("true - Dejar de usar elevador");
                        Console.WriteLine("1 - Salir del programa");
                        Console.Write("\nSeleccione una opción: ");

                        opcion = Console.ReadLine();

                        if (opcion.ToLower() == "true")
                        {
                            elevadorLibre = true;
                            Console.WriteLine("\nElevador liberado...");
                            Console.WriteLine("Presione cualquier tecla para continuar");
                            Console.ReadKey();
                        }
                        else if (opcion == "1")
                        {
                            salir = true;
                        }
                        else
                        {
                            Console.WriteLine("\nOpción no válida. Presione cualquier tecla para continuar");
                            Console.ReadKey();
                        }
                    }
                }

                Console.Clear();
                Console.WriteLine("Programa finalizado. Presione cualquier tecla para salir...");
                Console.ReadKey();
                
            }
        }
    }
    
