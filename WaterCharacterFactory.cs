using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ3_EDUKOS
{
    internal class WaterCharacterFactory : ICharacterFactory
    {
        public ITrueDamage CreateGoblin()
        {
            return new WaterGoblin();
        }

        public IMagicDamage CreateWizard()
        {
            return new WaterWizard();
        }
    }
}
