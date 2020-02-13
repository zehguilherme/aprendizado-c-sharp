// Passagem por valor e referência

// Passagem por valor - é criado um novo espaço na memória

using System;

class Aula25 {

    static void Main() {

        int num = 10;
        dobrarValor1(ref num);  //ref - usa o endereço de memória da variável que é passada por argumento (efetivamente altera o valor dessa memória)
        Console.WriteLine("Passagem de parâmetro por refeência: {0}", num);

        num = 10;
        dobrarValor2(num);
        Console.WriteLine("Passagem de parâmetro por valor: {0}", num);  //cria outro endereço na memória e copia o valor da variável que está sendo passada por parâmetro para essa nova                                                                  posição

    }

    // Passagem por referência
    static void dobrarValor1(ref int valor) {
        valor*=2;
    }

    // Passagem por valor
    static void dobrarValor2(int valor) {
        valor*=2;
    }

}