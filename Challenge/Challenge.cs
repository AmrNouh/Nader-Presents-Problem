class Challenge
{
    #region SolutionV1.0
    public static float PresentList(float budget, float bagVolume, int people, int Npresents, float[] presentVolume, float[] presentPrice)
    {
        float[,] result = new float[Npresents + 1, (int)Math.Ceiling(bagVolume)];
        float sol = 0;
        for (int i = 0; i < result.GetLength(0); i++)
        {
            for (int j = 0; j < result.GetLength(1); j++)
            {
                if (i == 0 || j == 0) continue;
                else if (presentVolume[i - 1] <= j)
                {
                    sol = presentPrice[i - 1] + result[i - 1, (int)(j - presentVolume[i - 1])];
                    result[i, j] = Math.Max(sol, result[i - 1, j]);
                    Console.WriteLine(result[i,j]);
                }
                else
                {
                    result[i, j] = result[i - 1, j];
                }
            }

        }

        for (int i = result.GetLength(1) - 1; i > 0; i--)
        {
            int j = result.GetLength(0) - 1;
            if (result[j, i] <= budget)
            {
                sol = result[j, i];
                break;
            }
            else
            {
                continue;
            }
        }

        return sol;
    }
    #endregion

    #region SolutionV2.0

    //private static float SolutionAlgorithm(int numberOfPrestents, float volume,float[] presentVolumes,float[] presnetPrices)
    //{

    //}

    //public static float PresentList(float budget, float bagVolume, int people, int Npresents, float[] presentVolume, float[] presentPrice)
    //{

    //}
    #endregion
}