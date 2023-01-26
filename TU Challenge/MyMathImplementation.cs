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
            return (a % b == 0);
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
            for (int i = 0; i < list.Count - 1; i++)
            {
                if (list[i] > list[i + 1])
                {
                    return false;
                }
            }
            return true;
        }

        public static bool IsMajeur(int age)
        {
            return age >= 18;
        }

        public static bool IsPrimary(int a)
        {
            if (a == 2) return true;
            if (a % 2 == 0 || a < 2) return false;
            for (int i = 3; i <= Math.Sqrt(a); i += 2)
            {
                if (a % i == 0) return false;
            }
            return true;
        }

        public static int Power(int a, int b)
        {
            return Convert.ToInt32(Math.Pow(a, b));
        }

        public static int Power2(int a)
        {
            return a*a;
        }

        public static List<int> Sort(List<int> toSort)
        {
            for (int i = 0; i < toSort.Count - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < toSort.Count; j++)
                {
                    if (toSort[j] < toSort[minIndex])
                    {
                        minIndex = j;
                    }
                }
                int temp = toSort[i];
                toSort[i] = toSort[minIndex];
                toSort[minIndex] = temp;
            }
            return toSort;
        }
    }
}
