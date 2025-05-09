namespace Baralhos {
    public class Baralho {
        private List<Carta> cartas = new List<Carta>();
        public Baralho() {

        }
        public List<Carta> CriarBaralho() {
            string[] valores = { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };
            string[] naipes = { "paus", "ouros", "espadas", "copas" };
            foreach(string naipe in naipes) {
                foreach(string valor in valores) {
                    cartas.Add(new Carta(valor, naipe));

                }
            }
            return cartas;
        }
        public Carta ComprarCarta() {
            if(cartas.Count == 0) {
                return null;
            }
            Carta cartaComprada = cartas[0];
            cartas.RemoveAt(0);
            return cartaComprada;
        }
        public void PrintBaralho() {
            foreach(Carta carta in cartas) {
                Console.WriteLine($"{carta.Valor} de {carta.Naipe}");
            }
        }
        public void Embaralhar() {
            Random rand = new Random();
            int n = cartas.Count;
            for(int i = n - 1; i > 0; i--) {
                int j = rand.Next(0, i + 1);

                Carta temp = cartas[i];
                cartas[i] = cartas[j];
                cartas[j] = temp;
            }
        }
    }
}
