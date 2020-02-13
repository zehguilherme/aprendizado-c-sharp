using System;

class Aula08 {

    static void Main() {

        float val1, val2, resultado = 0;
        int opcao = 0;

        Console.Write("Digite o 1º valor: ");
        val1 = int.Parse(Console.ReadLine());

        Console.Write("Digite o 2º valor: ");
        val2 = int.Parse(Console.ReadLine());

        Console.WriteLine("1- Soma");
        Console.WriteLine("2- Subtração");
        Console.WriteLine("3- Multiplicação");
        Console.WriteLine("4- Divisão");
        Console.WriteLine("0- Sair");
        Console.Write("\nEscolha uma operação: ");

        opcao = int.Parse(Console.ReadLine());

        switch(opcao) {

            case 1: resultado = val1 + val2; break;
            case 2: resultado = val1 - val2; break;
            case 3: resultado = val1 * val2; break;
            case 4: resultado = val1 / val2; break;
            case 0: return;
        }

        Console.WriteLine("Resultado: {0}", resultado);

    }

}