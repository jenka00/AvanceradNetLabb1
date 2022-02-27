using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace AvanceradNetLabb1
{
    public class LådaCollection : ICollection<Låda>
    {
        public IEnumerator<Låda> GetEnumerator()
        {
            return new LådaEnumerator(this);
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return new LådaEnumerator(this);
        }

        private List<Låda> innerCol;

        public LådaCollection()
        {
            innerCol = new List<Låda>();
        }

        public Låda this[int index]
        {
            get { return (Låda)innerCol[index]; }
            set { innerCol[index] = value; }
        }

        public bool Contains(Låda item)
        {
            bool found = false;

            foreach (Låda bx in innerCol)
            {

                if (bx.Equals(item))
                {
                    found = true;
                }
            }
            return found;
        }

        public bool Contains(Låda item, EqualityComparer<Låda> comp)
        {
            bool found = false;

            foreach (Låda bx in innerCol)
            {
                if (comp.Equals(bx, item))
                {
                    found = true;
                }
            }
            return found;
        }

        public void Add(Låda låda)
        {
            if (!Contains(låda))
            {
                innerCol.Add(låda);
            }
            else
            {
                Console.WriteLine("En låda med måtten {0} x {1} x {2} har redan lagts till i samlingen",
                    låda.höjd.ToString(), låda.bredd.ToString(), låda.längd.ToString());
            }
        }

        public bool Remove(Låda låda)
        {
            bool foundBox = false;

            for (int i = 0; i < innerCol.Count; i++)
            {
                Låda L1 = (Låda)innerCol[i];
                if (new LådaSameDimension().Equals(L1, låda))
                {
                    innerCol.RemoveAt(i);
                    foundBox = true;
                    break;
                }

            }
            return foundBox;

        }

        public void Clear()
        {
            innerCol.Clear();
        }

        public void CopyTo(Låda[] array, int arrayIndex)
        {
            for (int i = 0; i < innerCol.Count; i++)
            {
                array[i + arrayIndex] = innerCol[i];
            }
        }

        public bool IsReadOnly
        { get { return false; } }

        public int Count
        {
            get
            {
                return innerCol.Count;
            }
        }
    }
}

      
