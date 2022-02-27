using System;
using System.Collections.Generic;
using System.Text;

namespace AvanceradNetLabb1
{
    public class LådaSameVol : EqualityComparer<Låda>
    {
        public override bool Equals(Låda L1, Låda L2)
        {
            if ((L1.höjd * L1.bredd * L1.längd) == (L2.höjd * L2.bredd * L2.längd))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override int GetHashCode(Låda låda)
        {
            int hCode = låda.höjd ^ låda.bredd ^ låda.längd;
            return hCode.GetHashCode();
        }
    }
}
