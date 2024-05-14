using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discografica
{
    public class Podcasts : IReproducible
    {
        public TimeSpan Duracion { get; set; } = new TimeSpan(0, 8, 10);
    }
}
