// Argumento out - permite com que um método retorne mais de um valor (argumento de saída)

using System;

class Aula26 {

    static void Main() {

        int dividendo, divisor, quociente, resto;

        Console.Write("Digite o dividendo: ");
        dividendo = int.Parse(Console.ReadLine());

        Console.Write("\nDigite o divisor: ");
        divisor = int.Parse(Console.ReadLine());

        quociente = divide(dividendo, divisor, out resto);

        Console.WriteLine("\n{0} / {1} => quociente = {2} e resto {3}", dividendo, divisor, quociente, resto);

    }

    static int divide(int dividendo, int divisor, out int resto) {
        resto = dividendo % divisor;
        return dividendo / divisor;  //retorna quociente
    }

}