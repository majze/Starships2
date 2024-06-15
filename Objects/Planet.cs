using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starships.Objects
{
    internal class Planet : OrbitalPlane
    {
        public string Name { get; set; }
        public HabitableLevel HabitalLevel { get; set; }
    }
}
