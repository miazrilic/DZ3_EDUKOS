using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ3_EDUKOS
{
    internal class FireCharacterFactory : ICharacterFactory
    {
        public ITrueDamage CreateGoblin()
        {
            return new FireGoblin();
        }

        public IMagicDamage CreateWizard()
        {
            return new FireWizard();
        }
    }
}
