using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOC.memorias
{
    class Linha
    {
        public long id = 0;
        public long Bloco = 0;
        public string Processo = " ";
        public Linha(long id, long tag, string processo)
        {
            this.id = id;
            this.Bloco = tag;
        }
        public void SetBloco(Bloco bloco)
        {
            this.Bloco = bloco.id;
            this.Processo = bloco.Processo;
        }
    }
}
