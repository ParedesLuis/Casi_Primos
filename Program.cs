using System;
using System.IO;

namespace Numeros_Casi_primos
{
    class Program
    {
        static void Main(string[] args)
        {
            int conNumb ;//cuenta cuantos primos encontro
            int NumLine;
            int I,F;
            string []Line;
            StreamReader sr = new StreamReader("./casi.txt");

            String line;
            try
            {
                
                line = sr.ReadLine();
                NumLine = int.Parse(line);
                line = sr.ReadLine();
                
                while (NumLine!=0){

                Line= line.Split(" "); 
                I = int.Parse(Line[0]);
                F = int.Parse(Line[1]);
                conNumb = 0;
                
                 for (int i = I; i <= F; i++){

                if (!numbersPrimos(i)){//me indica si el numero no es primo

                    if (i != 1){

                        conNumb = conNumb + primos(i);

                    }

                }
            
            }
            Console.WriteLine(conNumb);

                line = sr.ReadLine();
                NumLine--;

                }

                sr.Close();
                Console.ReadLine();

            }
            catch (Exception e)
            {
                Console.WriteLine("Exceptionn: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
    }

           

/////////////////////////////////////////////////////////////////
            int primos(int number)
            {

                int prim = 0;

                for (int i = number; i >= 1; i--)
                {

                    if (number % i == 0)
                    {
                        if (numbersPrimos(i))
                        {
                            prim++;
                            if (prim == 2)
                            { // es primo de 2 o mas
                                return 0;
                            }
                        }
                    }
                }

                if (prim == 1)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }

            }

            bool numbersPrimos(int number)
            {

                if (number == 1)
                {

                    return false;

                }
                else if (number == 2)
                {

                    return true;

                }

                for (int i = number - 1; i > 1; i--)
                {

                    if (number % i == 0)
                    {

                        return false;
                    }

                }
                return true;
            }
        }



    }
}
