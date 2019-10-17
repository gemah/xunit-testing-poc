namespace xUnitPoc.Lib
{
    public class SimpleMath
    {
        public static int AddInt(int a, int b)
        {
            return a + b;
        }

        public static int SubInt(int a, int b)
        {
            return a - b;
        }

        public static int MulInt(int a, int b)
        {
            return a * b;
        }

        public static int DivInt(int a, int b)
        {
            if (b == 0)
            {
                return int.MaxValue;
            }
            else
            {
                return a / b;
            }
        }
    }
}
