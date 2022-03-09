namespace LeetCodes
{
    public static class Set
    {
        public static int minDistance(int n)
        {
            int leastDistance = n;
            int previousNumber = 0;
            int factorCount = 0;
            for(int i = 2; i<= n/2; i++)
            {
                if (n % i != 0) continue;
                leastDistance =  previousNumber != 0 && (i - previousNumber) < leastDistance ? (i - previousNumber) : leastDistance;
                previousNumber = i;
                factorCount++;
            }

            if (factorCount == 0)
            {
                return -1;
            }
            if (factorCount == 1)
            {
                return 0;
            }
            return leastDistance;
        }
    }
}
