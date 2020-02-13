// Operações de Bitwise

/*
    << desloca valor para esquerda (dobra)
    >> desloca valor para direita (diminui pela metade)
*/

using System;

class Aula09 {

    static void Main() {

        int num = 10;

        num = num << 1;  //deslocar valor de num em 1 vez para esquerda (dobrar valor 1 vez)

        num = num >> 1;  //deslocar valor de num em 1 vez para esquerda (dobrar valor 1 vez)

        Console.WriteLine(num);

    }

}