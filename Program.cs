using System;

namespace lab1ex8
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Ex 8
            Scrieti un program care interschimba valoarea a doua variabile intregi.
             */

            Console.WriteLine("introduceti valoarea pentru variabila1");
            int variabila1 = int.Parse(Console.ReadLine());

            Console.WriteLine("introduceti valoarea pentru variabila2");
            int variabila2 = int.Parse(Console.ReadLine());

            int variabilaIntermediara = variabila1;
            variabilaIntermediara = variabila1;
            variabila1 = variabila2;
            variabila2 = variabilaIntermediara;

            Console.WriteLine("variabila1: noua valoare valoarea " + variabila1);
            Console.WriteLine("variabila2: noua valoare valoarea " + variabila2);

        }
    }
}
