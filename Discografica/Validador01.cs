using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discografica
{
    internal class Validador01 : IValidable
    {
        public bool IsValid(IReproducible elemento)
        {
            return (elemento.Duracion > 0 && elemento.Duracion < 10);
        }
    }
}
