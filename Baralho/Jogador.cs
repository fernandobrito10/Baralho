using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baralhos {
    public class Jogador {
        private Carta[] mao = new Carta[5];
        List<Carta> baralho_cartas = new List<Carta>();
        public Jogador() {

        }
        public Carta popularLista() {

        }
        public Jogador criarMao(Baralho baralho) {
            for(int i = 0;i < 5;i++) {
                mao[i] = baralho.ComprarCarta();
            }
            return mao;
        }
    }
}
