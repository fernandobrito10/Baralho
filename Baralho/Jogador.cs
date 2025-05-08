using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baralhos {
    public class Jogador {
        private List<Carta> mao = new List<Carta>();
        public Jogador() {

        }

        public List<Carta> criarMao(Baralho baralho) {
            for(int i = 0;i < 2;i++) {
                mao.Add(baralho.ComprarCarta());
            }
            return mao;
        }
        public List<Carta> puxarCarta(Baralho baralho) {
            mao.Add(baralho.ComprarCarta());
            return mao;
        }
        public void printMao() {
            foreach(Carta cartas in mao) {
                Console.WriteLine($"{cartas.Valor} de {cartas.Naipe}");
            }
        }
        public int contarTotal() {
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
