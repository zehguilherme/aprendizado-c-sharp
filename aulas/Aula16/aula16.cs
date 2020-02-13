using System;

class Aula16 {

    static void Main() {

        float tempo = 0;
        char escolha = ' ';

        inicio:  //label a ser usado no goto

        Console.Clear();

        Console.WriteLine("Bauru a Penápolis");
        Console.WriteLine("Escolha o transporte: [a]Avião | [c]Carro | [o]Ônibus ");

        escolha = char.Parse(Console.ReadLine());

        switch (escolha)
        {
            case 'a':
            case 'A':
                tempo = 0.2f;
                break;

            case 'c':
            case 'C':
                tempo = 1.5f;
                break;
            case 'o':
            case 'O':
                tempo = 3f;
                break;

            default:
                tempo = -1f;
                break;
        }

        if(tempo < 0)
            Console.WriteLine("Transporte indisponível");
        else {
            Console.WriteLine("Para o transporte escolhido o tempo é: {0} horas", tempo);
        }

        Console.Write("\nCalcular outro transporte? [s / n] ");
        escolha = char.Parse(Console.ReadLine());

        if(escolha == 's' || escolha == 'S')
            goto inicio;  //goto apontando para o label criado anteriormente
        else {
            Console.Clear();
            Console.WriteLine("Fim do programa");
        }

    }

}