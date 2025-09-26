using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Arena.Core
{
    public interface IDamageable
    {
        string Name { get; set; }
        int Health { get; set; }
        int HealthMax { get; set; }

        int Defense();

        bool IsAlive();
    }
}
