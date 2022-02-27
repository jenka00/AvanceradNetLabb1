using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace AvanceradNetLabb1
{
    public class LådaEnumerator : IEnumerator<Låda>
    {
        private LådaCollection _Lådor;
        private int index;
        private Låda ValdLåda;

        public LådaEnumerator(LådaCollection lådor)
        {
            this._Lådor = lådor;
            index = -1;
            ValdLåda = default(Låda);

        }

        public Låda Current { get { return ValdLåda; } }

        object IEnumerator.Current { get { return Current; } }

        public void Dispose() { }

        public bool MoveNext()
        {
            if (++index >= _Lådor.Count)
            {
                return false;
            }
            else
            {               
                ValdLåda = _Lådor[index];
            }
            return true;
        }
        public void Reset()
        {
            index = -1;
        }

    }
}
