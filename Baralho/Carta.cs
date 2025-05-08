using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baralhos {
    public class Carta {
        public string Valor { get; set; }
        public string Naipe { get; set; }
        public Carta(string valor, string naipe) {
            Valor = valor;
            Naipe = naipe;
        }
    }
}
