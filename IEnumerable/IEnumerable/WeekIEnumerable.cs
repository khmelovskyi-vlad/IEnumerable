using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerable
{
    class WeekIEnumerable : IEnumerator
    {
        public WeekIEnumerable(string[] days)
        {
            this.Days = days;
            
        }
        public string[] Days;
        public int index = -1;
        bool IEnumerator.MoveNext()
        {
            if(index < Days.Length - 1)
            {
                index++;
                return true;
            }
            return false;
        }
        void IEnumerator.Reset()
        {
            index = -1;
        }
        object IEnumerator.Current
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
