using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
enum Stato {Disponibile, InPrestito }

namespace _28._4
{
    internal class Documento
    {
        public string Codice { get; set; }
        public string Titolo { get; set; }
        public int Anno { get; set; }
        public string Settore { get; set; }
        public Stato Stato { get; set; }
        public  Scaffale Scaffale { get; set; }
        public List<Autore> Autore { get; set; }
    }
}
