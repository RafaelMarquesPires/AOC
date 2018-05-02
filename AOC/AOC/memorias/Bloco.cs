using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOC.memorias
{
    class Bloco
    {
        public long id;
        public long Tag;
        public string Processo;
        public Bloco(long id, long tag, string processo)
        {
            this.id = id;
            this.Tag = tag;
            this.Processo = processo;
        }
        public Object ToObject()
        {
            return new { id = id, Tag = Tag, Processo = Processo };
        }
    }
}
