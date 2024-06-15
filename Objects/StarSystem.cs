using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Starships.Enumeration;

namespace Starships.Objects
{
    internal class StarSystem
    {
        public int Size { get; set; }
        public StarType Star { get; set; }
        public List<OrbitalPlane> Orbits { get; set; }
    }
}
