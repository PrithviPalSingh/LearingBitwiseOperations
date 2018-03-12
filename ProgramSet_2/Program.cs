using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramSet_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //var abc = Add(5, 11);
            //var abc = russianPeasant(4, 3);
            //var abc = NegateNumber(10);
            var abc = subtract(3, 4);
            Console.WriteLine(abc);
            Console.Read();
        }
       ////Sum of two bits can be obtained by performing XOR(^) of the two bits.
       ////Carry bit can be obtained by performing AND (&) of two bits.
       ////Above is simple Half Adder logic that can be used to add 2 single bits.
       ////We can extend this logic for integers.If x and y don’t have set bits at same position(s),
       ////then bitwise XOR (^) of x and y gives the sum of x and y.
       ////To incorporate common set bits also, bitwise AND(&) is used.
       ////Bitwise AND of x and y gives all carry bits.We calculate (x & y) << 1 and add it to x ^ y to get the required result.
        static int Add(int x, int y)
        {
            //if (y == 0)
            //    return x;
            //else
            //    return Add(x ^ y, (x & y) << 1);

            while (y != 0)
            {
                // carry now contains common set bits of x and y
                int carry = x & y;

                // Sum of bits of x and y where at least one of the bits is not set
                x = x ^ y;

                // Carry is shifted by one so that adding it to x gives the required sum
                y = carry << 1;
            }
            return x;
        }

        //  Diff   = y ⊕ x
        //  Borrow = x' . y 
        static int subtract(int x, int y)
        {
            //return x + (~y + 1);

            // Iterate till there is no carry
            while (y != 0)
            {
                // borrow contains common set bits of y and unset
                // bits of x
                int borrow = (~x) & y;

                // Subtraction of bits of x and y where at least
                // one of the bits is not set
                x = x ^ y;

                // Borrow is shifted by one so that subtracting it from
                // x gives the required sum
                y = borrow << 1;
            }

            return x;
        }

        static int russianPeasant(int a,  int b)
        {
            int res = 0;  // initialize result

            // While second number doesn't become 1
            while (b > 0)
            {
                // If second number becomes odd, add the first number to result
                if ((b & 1) == 1)
                    res = res + a;

                // Double the first number and halve the second number
                a = a << 1;
                b = b >> 1;
            }
            return res;
        }

        static int NegateNumber(int x)
        {
            return (~x) + 1;
        }
    }
}
