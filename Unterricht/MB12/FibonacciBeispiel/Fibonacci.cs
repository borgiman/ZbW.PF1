namespace MB12.FibonacciBeispiel
{
    public static class Fibonacci
    {

        public static int FibIterativ(int n)
        {
            //hier iterative Methode implementieren

            return 1;
        }


        public static int FibRecursiv(int n)
        {
            if (n <= 1)
                return n;

            return FibRecursiv(n - 1) + FibRecursiv(n - 2);
        }

    }
}
