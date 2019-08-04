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
            int moreTrees = K>L ?K: L;
            int lessTrees = K > L ? L : K;

            int[] firstPesron = getMaxContigousArrayForFirstPerson(A, moreTrees);
            int maxAppleFetchByFirstPerson = firstPesron[0];
            int indexofMaxByFirstPerson = firstPesron[1];

            Console.WriteLine("Maximum Apple Pluck by Frist Perosn : " + maxAppleFetchByFirstPerson);
            Console.WriteLine("Index where first person fonnd max :" + indexofMaxByFirstPerson);
            int[] secondPesron =getMaxContigousArrayForSecondPerson(A, lessTrees, moreTrees, indexofMaxByFirstPerson);
            int maxAppleFetchBySecondPerson = secondPesron[0];
            int indexofMaxBySecondPerson = secondPesron[1];

            Console.WriteLine("Maximum Apple Pluck by Second Perosn : " + maxAppleFetchBySecondPerson);
            Console.WriteLine("Index where Second person fonnd max :" + indexofMaxBySecondPerson);
            return maxAppleFetchBySecondPerson + maxAppleFetchByFirstPerson;
        }

        public static int[] getMaxContigousArrayForSecondPerson(int[] A, int numberOfRecordBySecond,int numberofRecordByFirst,int indexMaxByFirst)
        {
            int tempMax = 0;
            int actualMax = 0;
            int indexMaxFound = 0;

            bool checkbeforeIndexLength = false;
            if (!(indexMaxByFirst - numberOfRecordBySecond >= 0))
            {
                checkbeforeIndexLength = true;
            }
            bool checkAfterIndexLength = false;
            if (A.Length-( indexMaxByFirst + (numberofRecordByFirst - 1)) >=numberOfRecordBySecond)
            {
                checkAfterIndexLength = true;
            }

            if (!checkbeforeIndexLength)
            {
                for (int i = 0; i < indexMaxByFirst; i++)
                {
                    if (i <= indexMaxByFirst - numberOfRecordBySecond)
                    {
                        
                        for (int j = i; j < i + numberOfRecordBySecond; j++)
                        {
                            if (j < indexMaxByFirst)
                            {
                                tempMax += A[j];
                            }
                        }
                    }
                    if (tempMax > actualMax)
                    {
                        actualMax = tempMax;
                        indexMaxFound = i;
                    }
                    tempMax = 0;
                }
            }
            if (checkAfterIndexLength)
            {
                for (int i = indexMaxByFirst+1; i < A.Length; i++)
                {
                    

                        for (int j = i; j < i + numberOfRecordBySecond; j++)
                        {
                            if (j < A.Length)
                            {
                                tempMax += A[j];
                            }
                        }
                    
                    if (tempMax > actualMax)
                    {
                        actualMax = tempMax;
                        indexMaxFound = i;
                    }
                    tempMax = 0;
                }
            }
           
            int[] dataReturn = { actualMax, indexMaxFound };
            return dataReturn;
        }

        public static int[] getMaxContigousArrayForFirstPerson(int[] A, int numberOfRecord)
        {
            int tempMax = 0;
            int actualMax = 0;
            int indexMaxFound = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (i <= A.Length - numberOfRecord)
                {
                    for (int j = i; j < i + numberOfRecord; j++)
                    {
                        tempMax += A[j];
                    }
                }
                if (tempMax > actualMax)
                {
                    actualMax = tempMax;
                    indexMaxFound = i;
                }
                tempMax = 0;
            }
            int[] dataReturn = { actualMax, indexMaxFound };
            return dataReturn;
        }
    }
}
