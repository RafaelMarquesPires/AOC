using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOC.memorias
{
    class Linha
    {
        public long id;
        public long Tag;
        public string Processo;
        public Linha(long id, long tag, string processo)
        {
            this.id = id;
            this.Tag = tag;
            this.Processo = processo;
        }
    }
}
