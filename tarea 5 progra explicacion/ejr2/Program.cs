using System;
using System.Threading;

namespace ejr2
{
    class Program
    {
        public static void dibuja(int cantidad)
        {
            int CARACTERES_VERTICALES = 5;
            int CARACTERES_HORIZONTALES = 5;
            int forma_vertical = 3;
            int Forma_horizontal = 3;
            int F, C, A;

            for (A = 1; A <= cantidad; A++)
            {
                for (F = Forma_horizontal; F <= CARACTERES_HORIZONTALES; F++)
                {
                    Console.SetCursorPosition(F, CARACTERES_VERTICALES); Console.Write("?");
                    Console.SetCursorPosition(F, forma_vertical); Console.Write("?");
                }
                for (C = forma_vertical; C <= CARACTERES_VERTICALES; C++)
                {
                    Console.SetCursorPosition(Forma_horizontal, C); Console.Write("X");
                    Console.SetCursorPosition(CARACTERES_HORIZONTALES, C); Console.Write("X");

                }
                forma_vertical = forma_vertical + 1;
                CARACTERES_VERTICALES = CARACTERES_VERTICALES - 1;
                Forma_horizontal = Forma_horizontal + 1;
                CARACTERES_HORIZONTALES = CARACTERES_HORIZONTALES - 1;
            }
        }

        static void Main(string[] args)
        {
            for (int tam = 1; tam < 10; tam++)
            {
                dibuja(tam);
                Thread.Sleep(50);

            }
            Console.ReadKey();
        }

    }



}

       
