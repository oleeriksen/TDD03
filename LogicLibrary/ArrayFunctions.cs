using System;
using System.Linq;

namespace LogicLibrary
{
    public class ArrayFunctions
    {
        public ArrayFunctions()
        {
        }

        public bool IsUnique(int[] a)
        {
            if (a == null)
                throw new ArgumentNullException();
            for (int i = 0; i < a.Length - 1; i++)
                if ( a.Count(x => x == a[i]) > 1)
                    return false;
            return true;
        }

    }
}
