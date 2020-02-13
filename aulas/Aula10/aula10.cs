// Enmerador Enum - criar um tipo próprio com valores predefinidos
// Os valores são associados ao índice que é a sua posição dentro daquele determinado conjunto de valores do Enum

using System;


class Aula10 {

//enum Nome / Tipo {Índice 0, 1, 2...}
enum DiasSemana {Domimgo, Segunda, Terça, Quarta, Quinta, Sexta, Sábado}

    static void Main() {

        // DiasSemana ds = DiasSemana.Domimgo;
        // DiasSemana ds = (DiasSemana)3;  //Índice sendo convertido para tipo DiasSemana (cast)

        int ds = (int)DiasSemana.Sexta;  //uso de cast (int) para converter índice Enum para variável ds

        Console.Write(ds);

    }

}