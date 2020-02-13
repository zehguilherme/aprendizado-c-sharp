// Argumento params - permite a entrada de zero ou mais argumentos para uma função
// Não é preciso especificar quantos argumentos vão ser usados

using System;

class Aula27 {

    static void Main() {

        int v1, v2;

        Console.Write("Digite o 1º valor: ");
        v1 = int.Parse(Console.ReadLine());

        Console.Write("\nDigite o 2º valor: ");
        v2 = int.Parse(Console.ReadLine());

        soma(v1, v2);

    }

    static void soma(params int[]n) {

        int res = 0;

        // Verificar tamanho do vetor n
        if (n.Length < 1) {
            Console.WriteLine("Não existem valores a serem somados");
        }
        else if (n.Length < 2) {
            Console.WriteLine("Valores insuficientes para soma: {0}", n[0]);
        }
        else {
            for (int i = 0; i < n.Length; i++)
            {
                res += n[i];  //res recebe a posição atual percorrida no vetor
            }
        }


        Console.WriteLine("A soma de {0} e {1} é: {2}", n1, n2, n1 + n2);
    }

}