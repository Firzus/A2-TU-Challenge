using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TU_Challenge
{
    public class MyMathImplementation
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static List<int> GenericSort(List<int> toSort, Func<int, int, bool> isInOrder)
        {
            throw new NotImplementedException();
        }

        public static List<int> GetAllPrimary(int a)
        {
            throw new NotImplementedException();
        }

        public static bool IsDivisible(int a, int b)
        {
            return (a == b);
        }

        public static bool IsEven(int a)
        {
            return (a % 2 == 0);
        }

        public static bool IsInOrder(int a, int b)
        {
            throw new NotImplementedException();
        }

        public static bool IsInOrderDesc(int arg1, int arg2)
        {
            throw new NotImplementedException();
        }

        public static bool IsListInOrder(List<int> list)
        {
            throw new NotImplementedException();
        }

        public static bool IsMajeur(int age)
        {
            return age >= 18;
        }

        public static bool IsPrimary(int a)
        {
            return ((a / 1) == a) && ((a / a) == 1) && ((a % 2 == 0));
        }

        public static int Power(int a, int b)
        {
            throw new NotImplementedException();
        }

        public static int Power2(int a)
        {
            throw new NotImplementedException();
        }

        public static List<int> Sort(List<int> toSort)
        {
            throw new NotImplementedException();
        }
    }
}
