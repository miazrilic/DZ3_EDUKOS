using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ3_EDUKOS
{
     interface ICharacterFactory
    {
        public ITrueDamage CreateGoblin();
        public IMagicDamage CreateWizard();
    }
}
