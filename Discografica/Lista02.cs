using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Discografica
{
    public class Lista02 : Lista1
    {
        
        public IAnunciable Anuncios = new Anuncio();
        public decimal CosteTotal = 0;

        public decimal CosteAnuncios()
        {
            for (var i = 0 ; i < base.Count(); i++ ) {
                CosteTotal += Anuncios.Coste;
            }
            return CosteTotal;
            
        }
    }
}
