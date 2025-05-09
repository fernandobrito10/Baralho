namespace Baralhos {
    public class Jogador {
        private List<Carta> mao = new List<Carta>();
        public Jogador() {

        }

        public List<Carta> CriarMao(Baralho baralho) {
            for(int i = 0;i < 2;i++) {
                mao.Add(baralho.ComprarCarta());
            }
            return mao;
        }
        public List<Carta> PuxarCarta(Baralho baralho) {
            mao.Add(baralho.ComprarCarta());
            return mao;
        }
        public void PrintMao() {
            foreach(Carta cartas in mao) {
                cartas.PrintCarta();
            }
        }
        public int ContarTotal() {
            int total = 0;
            foreach(Carta cartas in mao) {
                if(cartas.Valor == "A") {
                    total++;
                }
                else if(cartas.Valor == "J" || cartas.Valor == "Q" || cartas.Valor == "K" ) {
                    total += 11;
                }
                else {
                    total += int.Parse(cartas.Valor);
                }
            }
            return total;
        }
    }
}
