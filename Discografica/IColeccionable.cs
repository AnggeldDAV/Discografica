using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discografica
{
    public interface IColeccionable
    {
        public List<IReproducible> Reproducibles { get; set; }
        public void Add(IReproducible elemento);
        public int Count();
        public int DameDuracionTotal();



    }
}
