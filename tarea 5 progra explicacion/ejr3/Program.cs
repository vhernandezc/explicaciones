using System;

namespace ejr3
{
    class Program
    {
        public static string generaletra(int min, int max)
        {
            Random ran = new Random();//escoge carcateres aleatoriamente
            int num = Convert.ToInt32(ran.Next(64, 91));//rango de caracteres a imprimir
            string letrarespuesta = "";
            if (((num > min) & (num < max)))
            {

                letrarespuesta = Convert.ToString((char)num);

            }
            return letrarespuesta;//imprime la función

        }


        static void Main(string[] args)
        {
            byte convertirNumero, elegir;

            string caracteres;
            Console.Write("cuantos caracteres?");
            caracteres = Console.ReadLine();
            convertirNumero = byte.Parse(caracteres);//convierte la variable numero a bytes

            string letra = "";
            for (elegir = 1; elegir <= convertirNumero; elegir++)//va 
            {
                letra = generaletra(64, 91);//rango de caracteres a imprimir
                Console.WriteLine($" letragenerada={letra}");
            }

        }
    }

}

       
