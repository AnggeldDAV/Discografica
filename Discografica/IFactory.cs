using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discografica
{
    public interface IFactory
    {
        IValidable Validador { get; set; }
        public IReproducible CreaRepoducible(TipoRepoducible tipo);
    }
}
