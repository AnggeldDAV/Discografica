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
            var Min = new TimeSpan(0,7,0);
            var Max = new TimeSpan(0, 15, 0);
            return (elemento.Duracion > Min && elemento.Duracion < Max);
        }
    }
}
