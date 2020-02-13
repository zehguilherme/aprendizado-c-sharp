using System;

namespace Aula02
{
    class Program
    {
        static void Main(string[] args)  //args - argumentos de entrada
        {
            Console.WriteLine("Curso C#");

            if(args.GetLength(0) > 0)
                Console.Write(args.GetValue(0));
        }
    }
}
