using System.Reflection.Metadata.Ecma335;
using Baralhos;
Console.OutputEncoding = System.Text.Encoding.UTF8;

Baralho baralho = new Baralho();
Jogador jogador1 = new Jogador();
Jogador jogador2 = new Jogador();
int jog1 = 0;
int jog2 = 0;

baralho.CriarBaralho();
baralho.Embaralhar();
jogador1.CriarMao(baralho);
jogador2.CriarMao(baralho);
do {
    Console.Clear();
    if(jog1 == 0) {
        jogador1.PrintMao();
        Console.Write("Jogador 1:\nDigite 1 para comprar mais uma carta ou 2 para desistir: ");
        int? escolha = int.Parse(Console.ReadLine()!);

        if(escolha == null) 
        {
            Console.WriteLine("Valor nulo meu chapa!");
        }

        if(escolha == 1) {
            jogador1.PuxarCarta(baralho);
        }
        else if(escolha == 2) {
            Console.WriteLine("Jogador 1 finalizou!");
            jog1 = 1;
        }
    }
    mostrarLog(jog1, jog2);
    Console.Clear();
    if(jog2 == 0) {
        jogador2.PrintMao();
        Console.Write("Jogador 2:\nDigite 1 para comprar mais uma carta ou 2 para desistir: ");
        int escolha = int.Parse(Console.ReadLine()!);
        if(escolha == 1) {
            jogador2.PuxarCarta(baralho);
        }
        else if(escolha == 2) {
            Console.WriteLine("Jogador 2 finalizou!");
            jog2 = 1;
        }
    }
    mostrarLog(jog1, jog2);
} while(jog1 == 0 || jog2 == 0);
Console.Clear();
int total1 = jogador1.ContarTotal();
int total2 = jogador2.ContarTotal();
Console.WriteLine($"Mão de jogador 1 ({total1} pontos): ");
jogador1.PrintMao();
Console.WriteLine($"Mão de jogador 2 ({total2} pontos): ");
jogador2.PrintMao();

if(total1 <= 21 && total2 <= 21) {
    if(total1 > total2)
        Console.WriteLine("Jogador 1 venceu!");
    else if(total2 > total1)
        Console.WriteLine("Jogador 2 venceu!");
    else if(total1 == total2)
        Console.WriteLine("Empate!");
}
else if(total1 > 21 && total2 <= 21) {
    Console.WriteLine("Jogador 2 venceu!");
}
else if(total2 > 21 && total1 <= 21) {
    Console.WriteLine("Jogador 1 venceu!");
}
else if(total1 == total2)
    Console.WriteLine("Empate");
else
    Console.WriteLine("Ninguém venceu!");

static void mostrarLog(int jog1, int jog2) {
    Console.Clear();
    if(jog1 == 0 || jog2 == 0) {
        Console.Write("Vire seu rosto, vez do outro jogador");
        for (int i = 0; i < 3; i++) {
            Console.Write(".");
            Thread.Sleep(1000);
        }
    }
    
}