// Métodos

using System;

class Aula24 {

    static void Main() {

            int v1, v2 = 0;

            Console.Write("Digite o 1º número: ");
            v1 = int.Parse(Console.ReadLine());

            Console.Write("Digite o 2º número: ");
            v2 = int.Parse(Console.ReadLine());

            Console.Write("A soma dos números {0} e {1} é: {2}", v1, v2, soma(v1,v2));


    }

    static int soma(int n1, int n2){
        return n1 + n2;
    }

}