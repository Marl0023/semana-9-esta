using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABB_semana_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Arbol a = new Arbol();
            a.Insertar(45);
            a.Insertar(25);
            a.Insertar(65);
            a.Insertar(15);
            a.Insertar(35);
            a.Insertar(75);
            a.Insertar(30);
            a.Insertar(40);
            a.Insertar(70);






            Console.WriteLine("Recorrido en pre:");
            a.RecorrerPreOrden(a.Raiz);
            Console.WriteLine("");
            Console.WriteLine("Recorrido en orden:");
            a.RecorrerEnOrden(a.Raiz);
            Console.WriteLine("");
            Console.WriteLine("Recorrido en pos:");
            a.RecorrerPosOrden(a.Raiz);


            
            bool t = true;
            while (t) {
                Console.WriteLine("\nOpciones: \n1.Insertar\n2.Buscar\n3.Imprimir\n0.salir");
                Console.Write("Ingrese Opcion: ");
                int op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        Console.WriteLine("Ingrese numero a ingresar: ");
                        int ins = int.Parse(Console.ReadLine());
                        a.Insertar(ins);
                        break;
                    case 2:
                        Console.WriteLine("Ingrese numero a buscar: ");
                        int i = int.Parse(Console.ReadLine());
                        bool b = a.Buscar(a.Raiz, i);
                        if (b)
                        {
                            Console.WriteLine("Valor encontrado en el arbol");
                        }
                        else
                        {
                            Console.WriteLine("Valor no encontrado en el arbol");
                        }
                        break;
                    case 3:
                        Console.WriteLine("Recorrido en pre:");
                        a.RecorrerPreOrden(a.Raiz);
                        Console.WriteLine("");
                        Console.WriteLine("Recorrido en orden:");
                        a.RecorrerEnOrden(a.Raiz);
                        Console.WriteLine("");
                        Console.WriteLine("Recorrido en pos:");
                        a.RecorrerPosOrden(a.Raiz);
                        Console.ReadKey();
                        break;
                    case 0:
                        t = false;
                        break;
                    default:
                        Console.WriteLine("Ingrese un numero adecuado");
                        break;


                }
                Console.Clear();

            }       
            
        }
    }
}
