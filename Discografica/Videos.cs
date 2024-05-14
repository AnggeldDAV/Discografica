using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discografica
{
    public class Videos : IReproducible
    {
        public TimeSpan Duracion { get; set; } = new TimeSpan(0, 5, 20);
    }
}
