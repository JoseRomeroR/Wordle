using System;

namespace Wordle
{ 
    internal class Program
    {
        static void Main(string[] args)
        {
            ResetColor();
            Wordle wordle = new Wordle("RUEDA");
            string palabraGanadora = "CAMPO";
            string palabraComprobar ;
            bool exit=false;
            bool win = false;
            int n = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("Adivina la palabra!");
                for (int k = 0; k < wordle.Words.Length; k++) // RECORRE LA ARRAY DE PALABRAS
                {
                    palabraComprobar = wordle.Words[k]; // ASIGANAMOS A PALABRA INTRODUCIDA
                    for (int i = 0; i < palabraGanadora.Length; i++) 
                    {
                        for (int j = 0; j < palabraGanadora.Length; j++)
                        {
                            if (palabraComprobar[i] == palabraGanadora[j] && i == j) ColorGreen(); // SI LA LETRA COINCIDE CON LA LETRA Y EN EL MISMO SITIO CAMBIAMOS COLOR
                            if (palabraComprobar[i] == palabraGanadora[j] && i != j) ColorYellow(); // SI LA LETRA ESTÁ EN LA PALABRA PERO NO EN EL MISMO SITIO CAMBIAMOS COLOR
                        }
                        Console.Write($"{palabraComprobar[i]} "); //print letra 
                        ResetColor();
                    }
                    Console.WriteLine();  
                }
                
                for (int i = 0; i < wordle.Words.Length; i++)
                {
                    if (wordle.Words[i] == palabraGanadora)
                    {
                        exit = true; //RECORREMOS ARRAY PARA VER SI HEMOS DICHO LA PALABRA CORRECTA
                        win = true;
                    } 
                }
                   
                if (!exit==true) wordle.Words[n] = Console.ReadLine().ToUpper(); // SI ES CORRECTA LA PALABRA NO PEDIMOS MAS DATOS Y SALIMOS
                if (n == 6)
                {
                    exit = true;
                    win = false;
                }

                n++;
            } while (!exit);

            if (win)
            {
                Console.WriteLine("WIN WIN WIN WIN");
            }
            else
            {
                Console.WriteLine("LOSE LOSE LOSE LOSE");
            }

            //PrintWords(wordle);
            //Console.WriteLine("Adivina la palabra!");
            //wordle.UserDecision = Console.ReadLine(); // decision del usuario
            //wordle.Words[0] = wordle.UserDecision;
            //PrintWords(wordle);
        }
        //Imprime las palabras  (interfaz de juego)
       
        public static void ColorGreen()
        {
            Console.ForegroundColor = ConsoleColor.Green;
        }
        public static void ColorYellow()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
        }
        public static void ResetColor()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
        }
    }
}
