namespace Baralhos {
    public class Carta {
        public string Valor { get; set; }
        public string Naipe { get; set; }
        public Carta(string valor, string naipe) {
            Valor = valor;
            Naipe = naipe;
        }
        public void PrintCarta() {
            int valor;
            string naipe;

            if (Valor == "A") valor = 1;
            else if (Valor == "J" || Valor == "Q" || Valor == "K") valor = 11;
            else valor = int.Parse(Valor);
            if (Naipe == "ouros") naipe = "♦";
            else if (Naipe == "copas") naipe = "♥";
            else if (Naipe == "paus") naipe = "♣";
            else naipe = "♠";

            Console.WriteLine($"┌─────────┐\n│{Valor,2}       │");
            if (valor <= 3) {
                for (int i = 0; i < valor; i++) {
                    Console.WriteLine($"│    {naipe}    │");
                }
            }
            else if(valor >= 3 && valor <= 6 && valor % 2 == 0){
                for (int i = 0; i < valor/2; i++) {
                    Console.WriteLine($"│  {naipe}   {naipe}  │");
                }
            }
            else if(valor == 9) {
                Console.WriteLine($"│  {naipe}   {naipe}  │");
                Console.WriteLine($"│  {naipe}   {naipe}  │");
                Console.WriteLine($"│    {naipe}    │");
                Console.WriteLine($"│  {naipe}   {naipe}  │");
                Console.WriteLine($"│  {naipe}   {naipe}  │");

            }
            else if(valor == 10) {
                Console.WriteLine($"│  {naipe}   {naipe}  │");
                Console.WriteLine($"│    {naipe}    │");
                Console.WriteLine($"│  {naipe}   {naipe}  │");
                Console.WriteLine($"│  {naipe}   {naipe}  │");
                Console.WriteLine($"│    {naipe}    │");
                Console.WriteLine($"│  {naipe}   {naipe}  │");
            }
            else {
                for (int i = 1; i <= valor/2; i++) {
                    if(i % 2 != 0)
                        Console.WriteLine($"│  {naipe}   {naipe}  │");
                    else
                        Console.WriteLine($"│    {naipe}    │");
                }
                Console.WriteLine($"│  {naipe}   {naipe}  │");
            }
            Console.WriteLine($"│       {Valor,2}│\n└─────────┘");
        }
    }
}
