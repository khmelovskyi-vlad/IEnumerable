using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerable
{
    class VladNumerable <TElements>
    {
        public VladNumerable(TElements[] days)
        {
            this.Days = days;

        }
        public TElements[] Days;
        public int index = -1;
        public bool MoveNext()
        {
            if (index < Days.Length - 1)
            {
                index++;
                return true;
            }
            return false;
        }
        public void Reset()
        {
            index = -1;
        }
        public object Current
        {
            get
            {
                if (index == -1 || index >= Days.Length)
                {
                    throw new InvalidOperationException();
                }
                return Days[index];
            }
        }
    }
}
