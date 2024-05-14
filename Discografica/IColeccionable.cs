using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discografica
{
    public interface IColeccionable
    {
        public void Add(IReproducible elemento);
        public int Count();
        public TimeSpan DameDuracionTotal();



    }
}
