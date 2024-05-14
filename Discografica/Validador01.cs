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
            var Min = new TimeSpan(0);
            var Max = new TimeSpan(0,10,0);
            return (elemento.Duracion > Min && elemento.Duracion < Max);
        }
    }
}
