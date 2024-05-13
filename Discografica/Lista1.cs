using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discografica
{
    public class Lista1 : IColeccionable
    {
        public int TotalDuracion { get; set; } = 0;
        public List<IReproducible> Reproducibles { get; set; } = new();

        public void Add(IReproducible elemento)
        {
            this.Reproducibles.Add(elemento);
        }
        public int Count()
        {
            return Reproducibles.Count();
        }
        public int DameDuracionTotal()
        {
            foreach (var element in Reproducibles)
            {
                TotalDuracion += element.Duracion;
            }
            return TotalDuracion;
        }
    }
}
