using System;

namespace WindowsFormsApp1
{
    public class HelperClass
    {
        private dynamic current = 0;

        public bool CheckForTie(int madeSteps, int totalSteps)
        {

            if (madeSteps == totalSteps)
                return true;
            else
                return false;
        }

        public string CheckColumn(int j, string XorO, int halfSteps, string[,]array)
        {
            bool checking = true;
            int matching = 0;
            for (int i = 0; i < halfSteps; i++)
                if (array[i, j] == XorO && checking)
                {
                    matching++;
                    //if (matching > 2)
                    //checkFor3x3(i, j, XorO);
                    if (matching == halfSteps)
                        return XorO;
                }
                else
                    break;
            return "None";
        }

        public string CheckRow(int i, string XorO, int halfSteps, string[,]array)
        {
            bool checking = true;
            int matching = 0;
            for (int j = 0; j < halfSteps; j++)
                if (array[i, j] == XorO && checking)
                {
                    matching++;
                    if (matching == halfSteps)
                        return XorO;
                }
                else
                    break;
            return "None";
        }

        public string CheckLeftDiagonal(string XorO, int halfSteps, string[,]array)
        {
            int matching = 0;
            for (int i = 0; i < halfSteps; i++)
                for (int j = 0; j < halfSteps; j++)
                {
                    if (i == halfSteps - j - 1)
                    {
                        if (array[i, j] == XorO)
                            matching++;
                        else
                            break;

                        if (matching == halfSteps)
                            return XorO;
                    }
                }
            return "None";
        }

        public string CheckRightDiagonal(string XorO, int halfSteps, string[,] array)
        {
            int matching = 0;
            for (int i = 0; i < halfSteps; i++)
                for (int j = 0; j < halfSteps; j++)
                {
                    if (i == j)
                    {
                        if (array[i, j] == XorO)
                            matching++;
                        else
                            break;

                        if (matching == halfSteps)
                            return XorO;
                    }
                }
            return "None";
        }
    }
}