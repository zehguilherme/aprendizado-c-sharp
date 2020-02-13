// Foreach - indicado para a leitura de elementos

// Não é indicado para inicializar elementos

using System;

class Aula20 {

    static void Main() {

        int[] num = new int[3] {10,20,30};

        // Inicialização dos elementos
        for (int i = 0; i < num.Length; i++) {  //i será usado somente dentro do for, não ocuará espaço na memória do programa inteiro
            num[i] = 0;
        }

        // Leitura dos elementos
        foreach (int n in num)  //n - variável que vai receber cada item do array num (deve ser do mesmo tipo - int)
        {
            Console.WriteLine(n);
        }

    }

}