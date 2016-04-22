using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Hilos1
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread hilo = new Thread(pintarCaracter);
            hilo.Start();

            Thread hilo2 = new Thread(()=> pintarPalabra(".NET","C#"));
            hilo2.Start();
            
           // hilo.Join();
            //Thread.Sleep(2000);
            //hilo.Start("z");
            pintarX();
            Console.Read();
        }
        static void pintarCaracter(Object letra)
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.Write(letra.ToString());

            }
        }

        //static void pintarCaracter()
        //{
        //    for (int i = 0; i < 1000; i++)
        //    {
        //        Console.Write("y");
        //    }
        //}

        static void pintarPalabra(String palabra1, String palabra2)
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.Write(palabra1 + "-" + palabra2);
            }
        }


        static void pintarX()
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.Write("x");

            }
        }

    }
}
