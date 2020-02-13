// While

using System;

class Aula20 {

    static void Main() {

        int[] num = new int[10];

        int a = num.Length;

        while (a < 0) {  //Lenght - pega o tamanho do array
            Console.WriteLine(num[a] = a);

            a++;
        }

        // for(int i = 0; i < num.Length; i++) {  //Length - pega o tamanho do array
        //     num[i] = i;
        // }

        // for(int i = 0; i < num.Length; i++) {
        //     Console.WriteLine("Valor de num na posição {0} é {1}", i, num[i]);
        // }
        


    }

}