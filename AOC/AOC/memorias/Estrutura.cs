using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOC.memorias
{
    class Estrutura
    {
        public long id = -1;
        public long Entrada = 0;
        public long Tempo = 0;
        public long Quantidade = 0;
        public Estrutura(long id, long entrada, long tempo, long quantidade)
        {
            this.id = id;
            this.Entrada = entrada;
            this.Tempo = tempo;
            this.Quantidade = quantidade;
        }
    }
}
