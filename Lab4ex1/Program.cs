using System;

namespace Lab4ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Scrieti un program care va citi un vector de intregi de dimensiune n de la tastaura. Scrieti o functie care va inversa elementele vectorului, apelati-o si afisati-I rezultatul*/

            Console.WriteLine("Introduceti dimensiunea vectorului: ");
            int n = int.Parse(Console.ReadLine());
            int[] vectorNumere = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Introduceti elementul vectorului de pe pozitia " + i);
                vectorNumere[i] = int.Parse(Console.ReadLine());
            }

            int[] rezultat = InversareVector(vectorNumere);

            Console.WriteLine("Vectorul inversat este: ");

            for (int i = 0; i < n; i++)
            {
                Console.Write(rezultat[i] + " ");
            }
        }


        static int[] InversareVector(int[] vector)
        {
            int n = vector.Length;
            int[] vectorNumereInversate = new int[n];

            for (int i = 0; i < n; i++)
            {
                vectorNumereInversate[i] = vector[n - i - 1]; 
            }

            return vectorNumereInversate;
        }


    }
}
