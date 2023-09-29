namespace Codility_MissingInteger
{
    internal static class Solution
    {
        public static int RetrieveMinMissingNumberFromArray(int[] A)
        {
            int min = 1;
            HashSet<int> numbers = new HashSet<int>();

            foreach (int n in A)
            {
                if (!numbers.Contains(n))
                {
                    numbers.Add(n);

                    if (n == min)
                    {
                        while (numbers.Contains(min))
                        {
                            min++;
                        }
                    }
                }
            }

            return min;
        }
    }
}
