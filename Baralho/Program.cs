using Baralhos;

Baralho baralho = new Baralho();
Jogador jogador1 = new Jogador();
Jogador jogador2 = new Jogador();
int jog1 = 0;
int jog2 = 0;

baralho.criarBaralho();
baralho.embaralhar();
jogador1.criarMao(baralho);
jogador2.criarMao(baralho);
do {
    Console.Clear();
    if(jog1 == 0) {
        jogador1.printMao();
        Console.Write("Jogador 1:\nDigite 1 para comprar mais uma carta ou 2 para desistir: ");
        int escolha = int.Parse(Console.ReadLine());
        if(escolha == 1) {
            jogador1.puxarCarta(baralho);
        }
        else if(escolha == 2) {
            Console.WriteLine("Jogador 1 finalizou!");
            jog1 = 1;
        }
    }
    Thread.Sleep(2000);
    Console.Clear();
    if(jog2 == 0) {
        jogador2.printMao();
        Console.Write("Jogador 2:\nDigite 1 para comprar mais uma carta ou 2 para desistir: ");
        int escolha = int.Parse(Console.ReadLine());
        if(escolha == 1) {
            jogador2.puxarCarta(baralho);
        }
        else if(escolha == 2) {
            Console.WriteLine("Jogador 2 finalizou!");
            jog2 = 1;
        }
    }
} while(jog1 == 0 || jog2 == 0);
Console.Clear();
int total1 = jogador1.contarTotal();
int total2 = jogador2.contarTotal();
Console.WriteLine($"Mão de jogador 1 ({total1} pontos): ");
jogador1.printMao();
Console.WriteLine($"Mão de jogador 2 ({total2} pontos): ");
jogador2.printMao();

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

