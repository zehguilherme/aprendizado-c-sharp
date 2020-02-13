// Métodos para arrays


using System;

class Aula23 {

    static void Main() {

        int[] vetor1 = new int[5];
        int[] vetor2 = new int[5];
        int[] vetor3 = new int[5];
        int[,] matriz = new int[2,5] {{11,22,00,44,55} , {66,77,88,99,00}};

        Random random = new Random();  //gera números aleatórios

        for(int i = 0; i < vetor1.Length; i++) {
            vetor1[i] = random.Next(50);  //preencher o vetor com numeros entre 0 e 49 aletóriamente
        }

        Console.Write("\nElementos do vetor 1: \n");

        foreach (int i in vetor1)
        {
            Console.WriteLine(i);
        }

        // public static void BinarySearch(array, valor) - retorna a posição do elemento procurado (valor)

        Console.WriteLine("\nBinarySearch");
        int procurado = 33;
        int pos = Array.BinarySearch(vetor1,procurado);
        Console.WriteLine("Valor {0} está na posição {1}",procurado,pos);
        Console.WriteLine("---------------------------------------------------------");

        // public static void Copy(Ar_origem, Ar_destino, qtd_elementos) - copia elementos de um vetor para outro

        Console.WriteLine("\nCopy");
        Array.Copy(vetor1,vetor2,vetor1.Length);  //serão copiados a quantidade de elementos do vetor1

        foreach (int n in vetor2)  //imprime os elementos copiados
        {
            Console.WriteLine(n);
        }
        Console.WriteLine("---------------------------------------------------------");

        // public void CopyTo(Array_destino, a_partir_desta_posicao);

        Console.WriteLine("\nCopyTo");
        vetor1.CopyTo(vetor3,0);  //copia os elementos do vetor1 para vetor3 a partir da posição 0

        foreach (int n in vetor3)
        {
            Console.WriteLine(n);
        }
        Console.WriteLine("---------------------------------------------------------");

        // public long GetLongLength (dimensão) - retorna a qtd de elementos de um vetor
        // dimensão 0: vetor
        // dimensão 1: matriz (mais de uma dimensão)
        Console.WriteLine("\nGetLongLength");
        long qtdElementosVetor = vetor1.GetLongLength(0);
        Console.WriteLine("Quantidade de elementos {0}",qtdElementosVetor);
        Console.WriteLine("---------------------------------------------------------");
        
        // public int GetLowerBound (dimensão) - retorna o menor índice do vetor ou matriz
        Console.WriteLine("\nGetLowerBound");
        int menorIndiceVetor = vetor1.GetLowerBound(0);
        int menorIndiceMatriz_D1 = matriz.GetLowerBound(1);
        Console.WriteLine("Menor índice do vetor1 {0}",menorIndiceVetor);
        Console.WriteLine("---------------------------------------------------------");

        // public int GetUpperBound (dimensão) - retorna o maior índice do vetor ou matriz
        Console.WriteLine("\nGetUpperBound");
        int maiorIndiceVetor = vetor1.GetUpperBound(0);
        int maiorIndiceMatriz_D1 = matriz.GetUpperBound(1);
        Console.WriteLine("Menor índice do vetor1 {0}",maiorIndiceVetor);
        Console.WriteLine("---------------------------------------------------------");

        // public object GetValue (long índice) - retorna o valor a partir de um índice
        Console.WriteLine("\nGetValue");
        int valor0 = Convert.ToInt32(vetor1.GetValue(3));  //retorna o valor do elemento do índice 3
        int valor1 = Convert.ToInt32(matriz.GetValue(1,3));
        Console.WriteLine("Valor da posição 3 do vetor1: {0}",valor0);
        Console.WriteLine("---------------------------------------------------------");

        // public static int IndexOf(array,valor) - retorna o índice do primeiro valor a ser indicado no 2º parâmetro
        Console.WriteLine("\nIndexOf");
        int indice1 = Array.IndexOf(vetor1,3);
        Console.WriteLine("Índice do primeiro valor 33: {0}",indice1);
        Console.WriteLine("---------------------------------------------------------");
        
        // public static int LastIndexOf(array,valor) - retorna o índice do último valor a ser indicado no 2º parâmetro
        Console.WriteLine("\nLastIndexOf");
        int indice2 = Array.LastIndexOf(vetor1,3);
        Console.WriteLine("Índice do último valor 33: {0}",indice2);
        Console.WriteLine("---------------------------------------------------------");

        // public static Reverse(array) - inverte a posição dos elementos de um vetor
        Console.WriteLine("\nReverse");
        Array.Reverse(vetor1);
        foreach (int n in vetor1)
        {
            Console.WriteLine(n);
        }
        Console.WriteLine("---------------------------------------------------------");

        // public void SetValue(object valor, long post) - define um valor em uma posição de um vetor
        vetor2.SetValue(99,0); //coloca o valor 99 na posiçao 0

        for (int i = 0; i < vetor2.Length; i++)
        {
            vetor2.SetValue(0,i);  //coloca 0 em todas as posições do vetor2
        }
        Console.WriteLine("\nVetor 2");
        foreach (int n in vetor2)
        {
            Console.WriteLine(n);
        }
        Console.WriteLine("---------------------------------------------------------");

        // public static void Sort(array) - ordenar em ordem crescente os elementos do vetor
        Console.WriteLine("\nSort");
        Array.Sort(vetor1);
        Array.Sort(vetor2);
        Array.Sort(vetor3);

        Console.WriteLine("\nVetor 1");
        foreach (int n in vetor1)
        {
            Console.WriteLine(n);
        }

        Console.WriteLine("\nVetor 2");
        foreach (int n in vetor2)
        {
            Console.WriteLine(n);
        }

        Console.WriteLine("\nVetor 3");
        foreach (int n in vetor3)
        {
            Console.WriteLine(n);
        }
    }

}