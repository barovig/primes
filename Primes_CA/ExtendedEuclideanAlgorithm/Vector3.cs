using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtendedEuclideanAlgorithm
{
    class Vector3
    {
        public long a0, a1, a2;
        // ctor
        public Vector3(long x, long y, long z) { a0 = x; a1 = y; a2 = z; }
        // two operations(* and -) needed for our computations
        // scalar multiply
        public static Vector3 operator*(long left, Vector3 right)
        {
            return new Vector3(left * right.a0, left * right.a1, left * right.a2);
        }
        // vector subtract
        public static Vector3 operator-(Vector3 left, Vector3 right)
        {
            return new Vector3(left.a0 - right.a0, left.a1 - right.a1, left.a2 - right.a2);
        }
        // transform Vector into long[] array 
        public long[] ToLongArray()
        {
            return new long[] { this.a0, this.a1, this.a2 };
        }
    }
}
