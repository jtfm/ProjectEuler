namespace ProjectEuler.Solutions
{
    public static class MultiplesOf3And5
    {
        public static int Evaluate()
        {
            int result = 0;

            for (int i = 0; i < 1000; i++)
            {
                if (i % 3 == 0)
                {
                    result += i;
                }
                else if (i % 5 == 0)
                {
                    result += i;
                }
            }
            return result;
        }
    }
}
