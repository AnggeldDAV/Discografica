﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discografica
{
    public interface IReproducible
    {
        public TimeSpan Duracion {  get; set; }
    }
}
