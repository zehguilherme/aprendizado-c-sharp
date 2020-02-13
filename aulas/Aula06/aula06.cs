using System;

class Aula06 {

    static void Main() {

        int n1, n2, n3;

        n1 = 10; n2 = 20; n3 = 30;

        // Uso de índices
        // Console.Write("n1 = {0}, n2 = {1}, n3 = {2}", n1, n2, n3);

        // Uso de \n - Enter
        // Console.Write("n1 = {0}\nn2 = {1}\nn3 = {2}", n1, n2, n3);

        // Uso de \t - Insere uma tabulação (espaçamento)
        // Console.Write("n1 = \t{0}\nn2 = \t{1}\nn3 = \t{2}", n1, n2, n3);

        double valorCompra = 5.5;
        double valorVenda;
        double lucro = 0.1;
        string produto = "Pastel";

        valorVenda = valorCompra + (valorCompra * lucro);

        Console.WriteLine("Produto................: {0,15}", produto);  //,15 - tamanho do espaçamento a ser colocado
        Console.WriteLine("Valor de compra........: {0,15:c}", valorCompra);  //:c - formato de saída monetário (R$)
        Console.WriteLine("Lucro..................: {0,15:p}", lucro);  //:p - formato de saída porcentagem
        Console.WriteLine("Valor de venda.........: {0,15:c}", valorVenda);  

    }

}