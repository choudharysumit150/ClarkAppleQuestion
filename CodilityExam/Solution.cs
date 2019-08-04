using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodilityExam
{
    public static class Solution
    {
        public static int solution(int[] A, int K, int L)
        {
            int maxmimumApples = 0;
            int noOfTrees = A.Length;

            if ((K + L) > noOfTrees)
            {
                return -1;
            }
            int maxAppleAlice = 0;
            int maxAppleBob = 0;
            for (int i = 0; i < noOfTrees; i++)
            {

            }
            return maxmimumApples;
        }
    }
}
