using System;

namespace MyPrograms
{
    public class ClassicPrograms
    {
        public bool IsPrime(int a)
        {
            bool result = true;
            if (a >= 0)
            {
                for(int i = 2; i <= a / 2; i++)
                {
                    if (a % i == 0)
                    {
                        result = false;
                        break;
                    }
                }
                return result;
            }
            else
            {
                return false;
            }
        }

        public bool IsEven(int a)
        {
            bool result = true;
            if (a % 2 == 0)
            {
                result = true;
                return result;
            }
            else
            {
                return false;
            }
        }

        public bool IsOdd(int a)
        {
            bool result = true;
            if (a % 2 == 0)
            {
                result = false;
                return result;
            }
            else
            {
                return true;
            }
        }
    }
}