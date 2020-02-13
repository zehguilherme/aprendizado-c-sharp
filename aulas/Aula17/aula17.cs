// Array

using System;

class Aula17 {

    static void Main() {

        int[] n = new int[5];  //1ª forma de declaração

        int[] num = new int[4] {55, 77, 71, 41}; //2ª forma

        int[] num = {14, 35, 78, 21}; //3ª forma - tamanho é dado pela quantidade de elementos que estão presentes

        n[0] = 111;
        n[1] = 3;

        Console.WriteLine(num);

    }

}