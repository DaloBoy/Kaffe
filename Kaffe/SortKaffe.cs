using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Kaffe
{
    public class SortKaffe : Kaffe
    {
        public override int pris()
        {
            int prismedrabat = 20 - Rabat;
            if (prismedrabat <= 0)
                throw new ArgumentException("Whoops, du gav for meget rabat, RETARD!");

                return prismedrabat;
        }

        public SortKaffe()
        {
            
        }

        public SortKaffe(int rabat)
            : base()
        {
            
        }
    }
}
