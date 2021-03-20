using System;
using System.Threading;

namespace progra_t5
{
    class Program
    {
        public static string Mid(string parametro, int startIndex, int length)
        {
            string result = parametro.Substring(startIndex, length);
            return result;
        }

        static void Main(string[] args)
        {
            string NOMBRE;
            string LETRA_FINAL;
            int IR_POCICION = 0;
            int PASAR_CARACTERES = 0;
            int CARACTERES = 0;
            int POSICION = 0;
            Console.WriteLine("ingrese su nombre:");
            NOMBRE = Console.ReadLine();
            Console.SetCursorPosition(25, 8);//PRIMER NUMERO PARA POSICIONAR EL NOMBRE, EL SEGUNDO PARA DONDE SE VA A MOVER
            Console.Write(NOMBRE);
            CARACTERES = NOMBRE.Length; //CUENTA LOS CARACTERES DE LA CADENA

            POSICION = 12; //POSICIÓN A LA QUE SE VA A MOVER LA CADENA HORIZZONTALMENTE

            NOMBRE = NOMBRE.ToUpper(); //DEVUELVE LOS CARACTERES EN MAYUSCULA
            for (PASAR_CARACTERES = NOMBRE.Length; PASAR_CARACTERES >= 1; PASAR_CARACTERES--)
            {
                LETRA_FINAL = Mid(NOMBRE, PASAR_CARACTERES - 1, 1);//EMPIEZA A CARGAR LOS CARACTERES DESDE LA ULTIMA LETRA 
                for (IR_POCICION = CARACTERES; IR_POCICION <= POSICION; IR_POCICION++) //CADA CARACTER SE IRÁ REPITIENDO HASTA LLEGAR A SU POSICION
                {
                    Console.SetCursorPosition(IR_POCICION, 8);
                    Console.Write("" + LETRA_FINAL);
                    Thread.Sleep(50);//tiempo en cargar los caracteres
                }
                POSICION = POSICION - 1; //POSICIONA LOS CARACTERES ANTES QUE EL OTRO
                CARACTERES = CARACTERES - 1;//PASAN LOS CARCATERES PARA LA POSICION ESPECIFICADA
            }
        }







    }
}




        