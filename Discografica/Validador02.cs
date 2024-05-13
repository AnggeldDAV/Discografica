using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discografica
{
    public class Validador02 : IValidable
    {
        public bool IsValid(IReproducible elemento)
        {
            return (elemento.Duracion > 7 && elemento.Duracion <15);
        }
    }
}
