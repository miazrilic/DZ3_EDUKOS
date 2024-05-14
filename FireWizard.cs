using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DZ3_EDUKOS
{
    internal class FireWizard : IMagicDamage
    {
        public void DealMagicDamage()
        {
            Console.WriteLine("Do Fire Magic");
        }
    }
}
