using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baralhos {
    public class Baralho {
        private Carta[] carta = new Carta[52];
        public Baralho() {

        }
        public Carta[] criarBaralho() {
            string[] valores = { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };
            string[] naipes = { "paus", "ouros", "espadas", "copas" };
            int i = 0;
            foreach(string naipe in naipes) {
                foreach(string valor in valores) {
                    carta[i] = new Carta(valor, naipe);
                    i++;

                }
            }
            return carta;
        }
        public void printBaralho() {
            for(int x = 0;x < 52;x++) {
                Console.WriteLine($"{carta[x].Valor} de {carta[x].Naipe}");
            }
        }
        public Carta[] embaralhar() {
            Carta cartaAux;
            List<int> numerosUtilizados = new List<int>();
            Random rand = new Random();
            for (int x = 0;x < 52;x++) {
                int numAleatorio;
                do {
                    numAleatorio = rand.Next(0, 52);
                } while (numerosUtilizados.Contains(numAleatorio));
                numerosUtilizados.Add(numAleatorio);

                cartaAux = carta[x];
                carta[x] = carta[numAleatorio];
                carta[numAleatorio] = cartaAux;
                }
            return carta;
        }
        public Carta ComprarCarta() {
            Carta cartaComprada = carta[0];
            return cartaComprada;
        }
    }
}
