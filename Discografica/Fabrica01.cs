using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discografica
{
    public class Fabrica01 : IFactory
    {
        public IValidable Validador { get; set; }
        public IReproducible CreaRepoducible(TipoRepoducible tipo)

        {
            IReproducible reproducible = null;
            switch (tipo)
            {
                case TipoRepoducible.Canciones: reproducible = new Canciones();break;
                case TipoRepoducible.Videos: reproducible = new Videos(); break;
                case TipoRepoducible.Podcast: reproducible = new Podcasts();break;
                default: return null;
            }
            if (Validador.IsValid(reproducible))
            {
                return reproducible;
            } else
            {
                return null;
            }
        }
    }
}
