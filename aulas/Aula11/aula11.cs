// Conversão de tipos
// Conversão implícita - segura
// Conversão explícita - não segura (será alertada pelo compilador) - cast

using System;

class Aula11 {

    static void Main() {

        // Conversão implícita

        // int n1 = 10;
        // float n2 = n1;

        // Console.WriteLine(n2);

        ///////////////////////////////////////////

        // Conversão explícita

        float n1 = 15.5f;
        int n2 = (int)n1;  //type cast

        Console.WriteLine(n2);
    }

}